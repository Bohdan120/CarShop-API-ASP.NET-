using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using DataAccess.Data.Entities;
using DataAccess.Repositories;

namespace BusinessLogic.Services
{
    public class ReviewsService : IReviewsService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Review> reviewRepo;

        public ReviewsService(IMapper mapper, IRepository<Review> reviewRepo)
        {
            this.mapper = mapper;
            this.reviewRepo = reviewRepo;
        }

        public async Task<IEnumerable<ReviewDto>> GetAll()
        {
            var reviews = reviewRepo.GetAll(r => r.Car); 
            return mapper.Map<IEnumerable<ReviewDto>>(reviews);
        }

    }
}
