using cars.Models;
using System;
using System.Linq;
namespace cars.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CarsContext context)
        {
            context.Database.EnsureCreated();

            if (context.Cars.Any())
            {
                return;
            }

            var cars = new Car[]
            {
                new Car{Model="Rabbit", MaxSpeed=300},
                new Car{Model="Tortoise", MaxSpeed=150}
            };

            foreach(Car c in cars)
            {
                context.Cars.Add(c);
            }

            context.SaveChanges();
        }
    }
    
}