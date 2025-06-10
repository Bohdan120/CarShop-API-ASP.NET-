using BusinessLogic.Entities;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }     
        public int Year { get; set; }
        public double Price { get; set; }
        public int Mileage { get; set; }       
        public string Engine { get; set; }
        public int Horsepower { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? Description { get; set; }
        public bool InStock { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Order>? Orders { get; set; }
        public ICollection<Review>? Reviews { get; set; }

    }
}
