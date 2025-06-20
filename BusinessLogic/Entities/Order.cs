﻿namespace DataAccess.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
        public User? User { get; set; }
        public double TotalPrice { get; set; }
        public ICollection<Car>? Products { get; set; }
    }
}
