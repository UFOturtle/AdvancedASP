using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockApp.Models;
using System.Windows;
using System.IO;
using System.Text;
using CsvHelper;
using Microsoft.VisualBasic;

namespace StockApp.Controllers
{
    public class HomeController : Controller
    {
        //get csv file
        public IActionResult StockInfo()
        {

            string file = "../StockApp/App_Data/companylist.csv";

            using(var reader = new StreamReader(file))
            {
                List<Stock> stocks = new List<Stock>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    stocks.Add(new Stock { Name = values[1], Symbol = values[0] });
                 
                }
                ViewBag.Records = stocks;
            }


            

            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
