using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Http;

namespace BusinessLogic.DTOs
{
    public class CreateCarModel
    {      
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }      
        public int Mileage { get; set; }       
        public string? Engine { get; set; }
        public int Horsepower { get; set; }
        public int CategoryId { get; set; }       
        public string? Description { get; set; }
        public bool InStock { get; set; }
        public string ImageUrl { get; set; }
    }
}
