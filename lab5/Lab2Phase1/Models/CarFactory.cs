using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Data.Entity;

namespace Lab2Phase1.Models
{
    public class CarFactory : DbContext
    {
        public DbSet<Car> Cars { get; set; } //Creates a set of DB entities that uses Car

        //Constructor
        public CarFactory()
        {
            Database.SetInitializer(new CarInitializer());  //Initializes the DB
        }
    }

#pragma warning disable CS0246 // The type or namespace name 'DropCreateDatabaseIfModelChanges<>' could not be found (are you missing a using directive or an assembly reference?)
    public class CarInitializer : DropCreateDatabaseIfModelChanges<CarFactory>
#pragma warning restore CS0246 // The type or namespace name 'DropCreateDatabaseIfModelChanges<>' could not be found (are you missing a using directive or an assembly reference?)
    {

        protected override void Seed(CarFactory context)
        {
            context.Cars.Add(new Car() { Model = "Rabbit", MaxSpeed = 300 });

            context.Cars.Add(new Car() { Model = "Turtle", MaxSpeed = 150});
        }
    }  
}
