using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockApp.Models;
using CsvHelper;
using System.Windows;
using System.IO;
using System.Text;

namespace StockApp.Controllers
{
    public class HomeController : Controller
    {
        //get csv file
        public IActionResult StockInfo()
        {
            string file = "~/App_Data/companylist.csv";
            List<string> result = new List<string>();
            string value;
            using(TextReader fileReader = File.OpenText(file)) {
                var csv = new CsvReader(fileReader);
                csv.Configuration.HasHeaderRecord = false;
                while (csv.Read()) {
                    for(int i=0; csv.TryGetField<string>(i, out value); i++) {
                        result.Add(value);
                    }
                }
                ViewBag.Records = result;
            }

            return view();
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
