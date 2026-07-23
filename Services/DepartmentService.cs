using AutoMapper;
using InvoiceMenagment.Api.DTOs.Requests;
using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Http;
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Repositories.Interface;
using InvoiceMenagment.Api.Services.Interface;

namespace InvoiceMenagment.Api.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repository;
        private readonly IMapper _mapper;

        public DepartmentService(IDepartmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<IEnumerable<DepartmentResponse>>> GetAllAsync()
        {
            var departments = await _repository.GetAllActiveAsync();
            var response = _mapper.Map<IEnumerable<DepartmentResponse>>(departments);

            return new ResponseModel<IEnumerable<DepartmentResponse>>
            {
                MessageType = 1,
                Message = "Departments fetched successfully.",
                Result = response,
                HttpStatusCode = 200
            };
        }

        public async Task<ResponseModel<DepartmentResponse?>> GetByIdAsync(int id)
        {
            var department = await _repository.GetByIdAsync(id);
            if (department == null)
            {
                return new ResponseModel<DepartmentResponse?>
                {
                    MessageType = 0,
                    Message = "Department not found.",
                    Result = null,
                    HttpStatusCode = 404,
                    Errors = { "Department not found." }
                };
            }

            var response = _mapper.Map<DepartmentResponse>(department);
            return new ResponseModel<DepartmentResponse?>
            {
                MessageType = 1,
                Message = "Department fetched successfully.",
                Result = response,
                HttpStatusCode = 200
            };
        }

        // Combined Create + Update — Id check decides the path
        public async Task<ResponseModel<DepartmentResponse?>> SaveAsync(UpdateDepartmentRequest request)
        {
            if (request.Id > 0)
            {
                // ---- UPDATE ----
                var department = await _repository.GetByIdAsync(request.Id);
                if (department == null)
                {
                    return new ResponseModel<DepartmentResponse?>
                    {
                        MessageType = 0,
                        Message = "Department not found.",
                        Result = null,
                        HttpStatusCode = 404,
                        Errors = { "Department not found." }
                    };
                }

                var nameExists = await _repository.IsNameExistsAsync(request.DepartmentName, request.Id);
                if (nameExists)
                {
                    return new ResponseModel<DepartmentResponse?>
                    {
                        MessageType = 0,
                        Message = "Department name already exists.",
                        Result = null,
                        HttpStatusCode = 400,
                        Errors = { "Department name already exists." }
                    };
                }

                department.DepartmentName = request.DepartmentName;
                department.DepartmentCode = request.DepartmentCode;
                department.Description = request.Description;
                department.IsActive = request.IsActive;
                department.ModifiedOn = DateTime.UtcNow;

                await _repository.UpdateAsync(department);

                var updatedResponse = _mapper.Map<DepartmentResponse>(department);
                return new ResponseModel<DepartmentResponse?>
                {
                    MessageType = 1,
                    Message = "Department updated successfully.",
                    Result = updatedResponse,
                    HttpStatusCode = 200
                };
            }
            else
            {
                // ---- CREATE ----
                var exists = await _repository.IsNameExistsAsync(request.DepartmentName);
                if (exists)
                {
                    return new ResponseModel<DepartmentResponse?>
                    {
                        MessageType = 0,
                        Message = "Department name already exists.",
                        Result = null,
                        HttpStatusCode = 400,
                        Errors = { "Department name already exists." }
                    };
                }

                var department = _mapper.Map<Department>(request);
                department.CreatedOn = DateTime.UtcNow;
                department.IsActive = true;

                var created = await _repository.AddAsync(department);

                var createdResponse = _mapper.Map<DepartmentResponse>(created);
                return new ResponseModel<DepartmentResponse?>
                {
                    MessageType = 1,
                    Message = "Department created successfully.",
                    Result = createdResponse,
                    HttpStatusCode = 201
                };
            }
        }

        public async Task<ResponseModel<bool>> DeactivateAsync(int id)
        {
            var department = await _repository.GetByIdAsync(id);
            if (department == null)
            {
                return new ResponseModel<bool>
                {
                    MessageType = 0,
                    Message = "Department not found.",
                    Result = false,
                    HttpStatusCode = 404,
                    Errors = { "Department not found." }
                };
            }

            department.IsActive = false;
            department.ModifiedOn = DateTime.UtcNow;

            await _repository.UpdateAsync(department);

            return new ResponseModel<bool>
            {
                MessageType = 1,
                Message = "Department deactivated successfully.",
                Result = true,
                HttpStatusCode = 200
            };
        }
    }
}