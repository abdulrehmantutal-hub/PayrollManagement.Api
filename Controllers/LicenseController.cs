using InvoiceMenagment.Api.DTOs.Request;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using InvoiceMenagment.Helper;

namespace InvoiceMenagment.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LicenseController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;

        public LicenseController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("File is required.");

            try
            {
                var licenseFolder = Path.Combine(_env.ContentRootPath, "License");
                var generatedPath = Path.Combine(licenseFolder, "generate.lic");
                var clientPath = Path.Combine(licenseFolder, "client.lic");

                Directory.CreateDirectory(licenseFolder);

                if (!System.IO.File.Exists(generatedPath))
                {
                    return BadRequest("License not generated yet, please generate first license.");
                }

                string uploadedContent;
                using (var stream = new StreamReader(file.OpenReadStream()))
                {
                    uploadedContent = await stream.ReadToEndAsync();
                }

                string originalGeneratedContent = await System.IO.File.ReadAllTextAsync(generatedPath);

                if (uploadedContent != originalGeneratedContent)
                    return BadRequest("Uploaded license does not match the generated license.");

                await System.IO.File.WriteAllTextAsync(clientPath, uploadedContent);

                System.IO.File.Delete(generatedPath);

                return Ok(new { message = "License validated and saved successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpPost("generate")]
        public IActionResult GenerateLicense([FromBody] LicenseRequest request)
        {
            if (request.EndDate <= request.StartDate)
                return BadRequest("End date must be after start date");

            string licenseContent = LicenseGenerator.GenerateLicense(request);

            var licenseDir = Path.Combine(_env.ContentRootPath, "License");
            Directory.CreateDirectory(licenseDir);

            var generatePath = Path.Combine(licenseDir, "generate.lic");
            System.IO.File.WriteAllText(generatePath, licenseContent);

            return File(Encoding.UTF8.GetBytes(licenseContent), "application/octet-stream", "client.lic");
        }


    }
}
