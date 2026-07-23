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
    public class PageService : IPageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public PageService(IUnitOfWork unitOfWork, IMapper mapper, ApplicationDbContext context)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        // INSERT (Create)
        public async Task<ResponseModel<PagesResponse>> AddPageAsync(PagesRequest request)
        {
            var entity = _mapper.Map<Page>(request);
            await _unitOfWork.PageRepository.AddAsync(entity);

            var response = _mapper.Map<PagesResponse>(entity);
            return new ResponseModel<PagesResponse>
            {
                Result = response,
                Message = "Page added successfully",
                HttpStatusCode = 201
            };
        }

        // GET (Read)
        public async Task<ResponseModel<PagesResponse?>> GetPageByIdAsync(int id)
        {
            var entity = await _unitOfWork.PageRepository.GetByIdAsync(id);
            if (entity == null)
            {
                return new ResponseModel<PagesResponse?>
                {
                    Result = null,
                    Message = "Page not found",
                    HttpStatusCode = 404
                };
            }

            var response = _mapper.Map<PagesResponse>(entity);
            return new ResponseModel<PagesResponse?>
            {
                Result = response,
                Message = "Page retrieved successfully",
                HttpStatusCode = 200
            };
        }


        // GET ALL (Retrieve List)
        public async Task<ResponseModel<IEnumerable<PagesResponse>>> GetAllPagesAsync()
        {
            var entities = await _unitOfWork.PageRepository.GetAllAsync();
            var response = _mapper.Map<IEnumerable<PagesResponse>>(entities);

            return new ResponseModel<IEnumerable<PagesResponse>>
            {
                Result = response,
                Message = "Pages retrieved successfully",
                HttpStatusCode = 200
            };
        }


        // UPDATE
        public async Task<ResponseModel<PagesResponse?>> UpdatePageAsync(int id, PagesRequest request)
        {
            var entity = await _unitOfWork.PageRepository.GetByIdAsync(id);
            if (entity == null)
            {
                return new ResponseModel<PagesResponse?>
                {
                    Result = null,
                    Message = "Page not found",
                    HttpStatusCode = 404
                };
            }

            _mapper.Map(request, entity);
            _unitOfWork.PageRepository.UpdateAsync(entity);


            var response = _mapper.Map<PagesResponse>(entity);
            return new ResponseModel<PagesResponse?>
            {
                Result = response,
                Message = "Page updated successfully",
                HttpStatusCode = 200
            };
        }

        // DELETE
        public async Task<ResponseModel<bool>> DeletePageAsync(Guid globalId)
        {
            var entity = await _unitOfWork.PageRepository.GetByGlobalIdAsync(globalId);
            if (entity == null)
            {
                return new ResponseModel<bool>
                {
                    Result = false,
                    Message = "Page not found",
                    HttpStatusCode = 404
                };
            }

            _unitOfWork.PageRepository.SoftDeleteAsync(globalId);


            return new ResponseModel<bool>
            {
                Result = true,
                Message = "Page deleted successfully",
                HttpStatusCode = 200
            };
        }

        public async Task<ResponseModel<IEnumerable<PagesResponse>>> GetPagesWithControlsAsync()
        {
            // Fetch pages and their controls
            var entities = await _unitOfWork.PageRepository.GetPagesWithControlsAsync();
            foreach (var entity in entities)
            {
            }

            var response = _mapper.Map<IEnumerable<PagesResponse>>(entities);

            return new ResponseModel<IEnumerable<PagesResponse>>
            {
                Result = response,
                Message = "Pages with PageControls retrieved successfully",
                HttpStatusCode = 200
            };
        }

    }

}
