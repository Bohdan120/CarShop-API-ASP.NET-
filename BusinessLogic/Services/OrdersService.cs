using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using BusinessLogic.Specifications;
using DataAccess.Data;
using DataAccess.Data.Entities;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace BusinessLogic.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Order> orderR;
        private readonly IRepository<Car> productR;
        private readonly ICartService cartService;

        public OrdersService(IMapper mapper, 
                            IRepository<Order> orderR,
                            IRepository<Car> productR,
                            ICartService cartService)
        {
            this.mapper = mapper;
            this.orderR = orderR;
            this.productR = productR;
            this.cartService = cartService;
        }

        public async Task Create(string userId)
        {

            var ids = cartService.GetProductIds();

            if (!ids.Any())
                throw new InvalidOperationException("Cannot create order with empty cart.");

            var products = await productR.GetListBySpec(new CarSpecs.ByIds(ids));

            var order = new Order()
            {
                Date = DateTime.Now,
                UserId = userId,
                Products = products.ToList(),
                TotalPrice = products.Sum(x => x.Price),
            };

            orderR.Insert(order);
            orderR.Save();

        }

        public async Task<IEnumerable<OrderDto>> GetAllByUser(string userId)
        {
            var items = await orderR.GetListBySpec(new OrderSpecs.ByUser(userId));
            return mapper.Map<IEnumerable<OrderDto>>(items);
        }
    }
}
