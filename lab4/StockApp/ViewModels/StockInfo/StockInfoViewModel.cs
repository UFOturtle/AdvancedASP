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

namespace StockApp.ViewModels.StockInfo
{
    public class StockInfoViewModel
    {
        public StockInfoViewModel()
        {
            List<Stock> Stocks = new List<Stock>();

            string file ="../StockApp/App_Data/companylist.csv";
            using(var reader = new StreamReader(file))
            {
         

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Stocks.Add(new Stock { Name = values[1], Symbol = values[0] });
                }
            }
            
        }
        public IEnumerable<Stock> Stocks { get; set; }
      
    }
}