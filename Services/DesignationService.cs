using AutoMapper;
using InvoiceMenagment.Api.DTOs.Requests;
using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Http;
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Repositories.Interface;
using InvoiceMenagment.Api.Services.Interface;

namespace InvoiceMenagment.Api.Services
{
    public class DesignationService : IDesignationService
    {
        private readonly IDesignationRepository _repository;
        private readonly IMapper _mapper;

        public DesignationService(IDesignationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<IEnumerable<DesignationResponse>>> GetAllAsync()
        {
            var designations = await _repository.GetAllActiveAsync();
            var response = _mapper.Map<IEnumerable<DesignationResponse>>(designations);

            return new ResponseModel<IEnumerable<DesignationResponse>>
            {
                MessageType = 1,
                Message = "Designations fetched successfully.",
                Result = response,
                HttpStatusCode = 200
            };
        }

        public async Task<ResponseModel<DesignationResponse?>> GetByIdAsync(int id)
        {
            var designation = await _repository.GetByIdAsync(id);
            if (designation == null)
            {
                return new ResponseModel<DesignationResponse?>
                {
                    MessageType = 0,
                    Message = "Designation not found.",
                    Result = null,
                    HttpStatusCode = 404,
                    Errors = { "Designation not found." }
                };
            }

            var response = _mapper.Map<DesignationResponse>(designation);
            return new ResponseModel<DesignationResponse?>
            {
                MessageType = 1,
                Message = "Designation fetched successfully.",
                Result = response,
                HttpStatusCode = 200
            };
        }

        // Combined Create + Update — Id check decides the path
        public async Task<ResponseModel<DesignationResponse?>> SaveAsync(DesignationRequest request)
        {
            if (request.Id > 0)
            {
                // ---- UPDATE ----
                var designation = await _repository.GetByIdAsync(request.Id);
                if (designation == null)
                {
                    return new ResponseModel<DesignationResponse?>
                    {
                        MessageType = 0,
                        Message = "Designation not found.",
                        Result = null,
                        HttpStatusCode = 404,
                        Errors = { "Designation not found." }
                    };
                }

                var titleExists = await _repository.IsTitleExistsAsync(request.DesignationTitle, request.Id);
                if (titleExists)
                {
                    return new ResponseModel<DesignationResponse?>
                    {
                        MessageType = 0,
                        Message = "Designation title already exists.",
                        Result = null,
                        HttpStatusCode = 400,
                        Errors = { "Designation title already exists." }
                    };
                }

                designation.DesignationTitle = request.DesignationTitle;
                designation.DepartmentId = request.DepartmentId;
                designation.Description = request.Description;
                designation.IsActive = request.IsActive;
                designation.ModifiedOn = DateTime.UtcNow;

                await _repository.UpdateAsync(designation);

                var updatedResponse = _mapper.Map<DesignationResponse>(designation);
                return new ResponseModel<DesignationResponse?>
                {
                    MessageType = 1,
                    Message = "Designation updated successfully.",
                    Result = updatedResponse,
                    HttpStatusCode = 200
                };
            }
            else
            {
                // ---- CREATE ----
                var exists = await _repository.IsTitleExistsAsync(request.DesignationTitle);
                if (exists)
                {
                    return new ResponseModel<DesignationResponse?>
                    {
                        MessageType = 0,
                        Message = "Designation title already exists.",
                        Result = null,
                        HttpStatusCode = 400,
                        Errors = { "Designation title already exists." }
                    };
                }

                var designation = _mapper.Map<Designation>(request);
                designation.CreatedOn = DateTime.UtcNow;
                designation.IsActive = true;

                var created = await _repository.AddAsync(designation);

                var createdResponse = _mapper.Map<DesignationResponse>(created);
                return new ResponseModel<DesignationResponse?>
                {
                    MessageType = 1,
                    Message = "Designation created successfully.",
                    Result = createdResponse,
                    HttpStatusCode = 201
                };
            }
        }

        public async Task<ResponseModel<bool>> DeactivateAsync(int id)
        {
            var designation = await _repository.GetByIdAsync(id);
            if (designation == null)
            {
                return new ResponseModel<bool>
                {
                    MessageType = 0,
                    Message = "Designation not found.",
                    Result = false,
                    HttpStatusCode = 404,
                    Errors = { "Designation not found." }
                };
            }

            designation.IsActive = false;
            designation.ModifiedOn = DateTime.UtcNow;

            await _repository.UpdateAsync(designation);

            return new ResponseModel<bool>
            {
                MessageType = 1,
                Message = "Designation deactivated successfully.",
                Result = true,
                HttpStatusCode = 200
            };
        }
    }

}
