﻿using BusinessLogic.DTOs;

namespace BusinessLogic.Interfaces
{
    public interface ICartService
    {
        Task<IEnumerable<CarDto>> GetProducts();
        IEnumerable<int> GetProductIds();
        void Add(int id);
        void Remove(int id);
        int GetCount();
        bool IsExists(int id);
        void Clear();

    }
}
