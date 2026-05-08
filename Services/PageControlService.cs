using InvoiceMenagment.Api.Data;
using InvoiceMenagment.Api.DTOs.Request;
using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Http; // Common response model
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Services.Interfaces;
using InvoiceMenagment.Api.UOW;
using AutoMapper;

namespace InvoiceMenagment.Api.Services
{
    public class PageControlService : IPageControlService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public PageControlService(IUnitOfWork unitOfWork, IMapper mapper, ApplicationDbContext context)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        //// Create a PageControl
        //public async Task<ResponseModel<PageControlResponse>> AddPageControlAsync(PageControlRequestDto request)
        //{
        //    var entity = _mapper.Map<Control>(request);
        //    await _unitOfWork.PageControlRepository.AddAsync(entity);
        //    var response = _mapper.Map<PageControlResponse>(entity);

        //    return new ResponseModel<PageControlResponse>
        //    {
        //        Result = response,
        //        Message = "PageControl added successfully",
        //        HttpStatusCode = 201
        //    };
        //}


        //// Retrieve a PageControl by ID
        //public async Task<ResponseModel<PageControlResponse?>> GetPageControlByIdAsync(int id)
        //{
        //    var entity = await _unitOfWork.PageControlRepository.GetByIdAsync(id);
        //    if (entity == null)
        //    {
        //        return new ResponseModel<PageControlResponse?>
        //        {
        //            Result = null,
        //            Message = "PageControl not found",
        //            HttpStatusCode = 404
        //        };
        //    }

        //    var response = _mapper.Map<PageControlResponse>(entity);
        //    return new ResponseModel<PageControlResponse?>
        //    {
        //        Result = response,
        //        Message = "PageControl retrieved successfully",
        //        HttpStatusCode = 200
        //    };
        //}

        //// Retrieve all PageControls
        //public async Task<ResponseModel<IEnumerable<PageControlResponse>>> GetAllPageControlsAsync()
        //{
        //    var entities = await _unitOfWork.PageControlRepository.GetAllAsync();
        //    var response = _mapper.Map<IEnumerable<PageControlResponse>>(entities);

        //    return new ResponseModel<IEnumerable<PageControlResponse>>
        //    {
        //        Result = response,
        //        Message = "PageControls retrieved successfully",
        //        HttpStatusCode = 200
        //    };
        //}

        //// Update a PageControl
        //public async Task<ResponseModel<PageControlResponse?>> UpdatePageControlAsync(int id, PageControlRequestDto request)
        //{
        //    var entity = await _unitOfWork.PageControlRepository.GetByIdAsync(id);
        //    if (entity == null)
        //    {
        //        return new ResponseModel<PageControlResponse?>
        //        {
        //            Result = null,
        //            Message = "PageControl not found",
        //            HttpStatusCode = 404
        //        };
        //    }

        //    _mapper.Map(request, entity);
        //    _unitOfWork.PageControlRepository.UpdateAsync(entity);

        //    var response = _mapper.Map<PageControlResponse>(entity);
        //    return new ResponseModel<PageControlResponse?>
        //    {
        //        Result = response,
        //        Message = "PageControl updated successfully",
        //        HttpStatusCode = 200
        //    };
        //}

        //// Delete a PageControl
        //public async Task<ResponseModel<bool>> DeletePageControlAsync(Guid globalId)
        //{
        //    var entity = await _unitOfWork.PageControlRepository.GetByGlobalIdAsync(globalId);
        //    if (entity == null)
        //    {
        //        return new ResponseModel<bool>
        //        {
        //            Result = false,
        //            Message = "PageControl not found",
        //            HttpStatusCode = 404
        //        };
        //    }

        //    _unitOfWork.PageControlRepository.SoftDeleteAsync(globalId);

        //    return new ResponseModel<bool>
        //    {
        //        Result = true,
        //        Message = "PageControl deleted successfully",
        //        HttpStatusCode = 200
        //    };
        //}

        // Create a PageControl
        public async Task<ResponseModel<PageControlResponse>> AddPageControlAsync(PageControlRequest request)
        {
            var entity = _mapper.Map<Control>(request);
            await _unitOfWork.PageControlRepository.AddAsync(entity);
            var response = _mapper.Map<PageControlResponse>(entity);

            return new ResponseModel<PageControlResponse>
            {
                Result = response,
                Message = "PageControl added successfully",
                HttpStatusCode = 201
            };
        }


        // Retrieve a PageControl by ID
        public async Task<ResponseModel<PageControlResponse?>> GetPageControlByIdAsync(int id)
        {
            var entity = await _unitOfWork.PageControlRepository.GetByIdAsync(id);
            if (entity == null)
            {
                return new ResponseModel<PageControlResponse?>
                {
                    Result = null,
                    Message = "PageControl not found",
                    HttpStatusCode = 404
                };
            }

            var response = _mapper.Map<PageControlResponse>(entity);
            return new ResponseModel<PageControlResponse?>
            {
                Result = response,
                Message = "PageControl retrieved successfully",
                HttpStatusCode = 200
            };
        }

        // Retrieve all PageControls
        public async Task<ResponseModel<IEnumerable<PageControlResponse>>> GetAllPageControlsAsync()
        {
            var entities = await _unitOfWork.PageControlRepository.GetAllAsync();
            var response = _mapper.Map<IEnumerable<PageControlResponse>>(entities);

            return new ResponseModel<IEnumerable<PageControlResponse>>
            {
                Result = response,
                Message = "PageControls retrieved successfully",
                HttpStatusCode = 200
            };
        }

        // Update a PageControl
        public async Task<ResponseModel<PageControlResponse?>> UpdatePageControlAsync(int id, PageControlRequest request)
        {
            var entity = await _unitOfWork.PageControlRepository.GetByIdAsync(id);
            if (entity == null)
            {
                return new ResponseModel<PageControlResponse?>
                {
                    Result = null,
                    Message = "PageControl not found",
                    HttpStatusCode = 404
                };
            }

            _mapper.Map(request, entity);
            _unitOfWork.PageControlRepository.UpdateAsync(entity);

            var response = _mapper.Map<PageControlResponse>(entity);
            return new ResponseModel<PageControlResponse?>
            {
                Result = response,
                Message = "PageControl updated successfully",
                HttpStatusCode = 200
            };
        }

        // Delete a PageControl
        public async Task<ResponseModel<bool>> DeletePageControlAsync(Guid globalId)
        {
            var entity = await _unitOfWork.PageControlRepository.GetByGlobalIdAsync(globalId);
            if (entity == null)
            {
                return new ResponseModel<bool>
                {
                    Result = false,
                    Message = "PageControl not found",
                    HttpStatusCode = 404
                };
            }

            _unitOfWork.PageControlRepository.SoftDeleteAsync(globalId);

            return new ResponseModel<bool>
            {
                Result = true,
                Message = "PageControl deleted successfully",
                HttpStatusCode = 200
            };
        }
    }
}
