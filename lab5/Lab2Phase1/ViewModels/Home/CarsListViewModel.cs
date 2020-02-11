using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab2Phase1.Models;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab2Phase1.ViewModels.Home
{
    //View Model to help create list that can be iterated through
    public class CarsListViewModel
    {
        public IEnumerable<SelectListItem> CarsList { get; private set; }

        public Car FastestCar { get; set; }

        //Constructor Recieving list of cars and organizing data for the view
        public CarsListViewModel(IEnumerable<Car> cars)
        {
            //generate list
            CarsList = cars.Select( c => new SelectListItem() { Text = c.Model} );

            //point to fastest car
            FastestCar = cars.OrderByDescending(c => c.MaxSpeed).FirstOrDefault();
        }
    }
}