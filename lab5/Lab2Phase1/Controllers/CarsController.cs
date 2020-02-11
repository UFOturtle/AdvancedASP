using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab2Phase1.Models;
using System.Globalization;
using Lab2Phase1.ViewModels.Home;

namespace Lab2Phase1.Controllers
{
    public class CarsController : Controller
    {
        // Get: Cars
        public ActionResult CarsList()
        {
            //factory -> a new instance of the carfactory model
            var factory = new CarContext();

            //viewModel -> the viewmodel filled with the cars list
            var viewModel = new CarsListViewModel(factory.Cars);

            return View(viewModel);
        }
    }
}