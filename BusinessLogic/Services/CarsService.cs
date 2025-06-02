using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using BusinessLogic.Specifications;
using DataAccess.Data;
using DataAccess.Data.Entities;
using DataAccess.Repositories;
using Shop_Api_PV221;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class CarsService : ICarsService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Car> carsR;
        private readonly IRepository<Category> categoriesR;

        public CarsService(IMapper mapper,
                                IRepository<Car> carsR,
                                IRepository<Category> categoriesR)
        {
            this.mapper = mapper;
            this.carsR = carsR;
            this.categoriesR = categoriesR;
        }

        public void Create(CreateCarModel car)
        {
            carsR.Insert(mapper.Map<Car>(car));
            carsR.Save();
        }

        public void Delete(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            // delete car by id
            var car = carsR.GetById(id);

            if (car == null) throw new HttpException(Errors.CarNotFound, HttpStatusCode.NotFound);

            carsR.Delete(car);
            carsR.Save();
        }

        public void Edit(CarDto car)
        {
            carsR.Update(mapper.Map<Car>(car));
            carsR.Save();
        }

        public async Task<CarDto?> Get(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var item = await carsR.GetItemBySpec(new CarSpecs.ById(id));
            if (item == null) throw new HttpException(Errors.CarNotFound, HttpStatusCode.NotFound);

            var dto = mapper.Map<CarDto>(item);

            return dto;
        }

        public async Task<IEnumerable<CarDto>> Get(IEnumerable<int> ids)
        {
            return mapper.Map<List<CarDto>>(await carsR.GetListBySpec(new CarSpecs.ByIds(ids)));
        }

        public async Task<(IEnumerable<CarDto> Cars, int TotalCount)> GetAll(int page, int pageSize, string? make, string? category, string? sortDirection)
        {
            if (page <= 0 || pageSize <= 0)
                throw new HttpException("Page and page size must be positive", HttpStatusCode.BadRequest);

            var cars = await carsR.GetListBySpec(new CarSpecs.FilteredPagedSorted(page, pageSize, make, category, sortDirection));
            var totalCount = await carsR.CountAsync(new CarSpecs.FilteredCount(make, category));

            var carDtos = mapper.Map<List<CarDto>>(cars);
            return (carDtos, totalCount);
        }


        public async Task<int> GetTotalCount()
        {
            var allCars = await carsR.GetListBySpec(new CarSpecs.All());
            return allCars.Count();
        }

        public IEnumerable<CategoryDto> GetAllCategories()
        {
            return mapper.Map<List<CategoryDto>>(categoriesR.GetAll());
        }
    }
}
