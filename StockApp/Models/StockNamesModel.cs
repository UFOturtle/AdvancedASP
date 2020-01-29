using System;
using System.Collections.Generic;

namespace StockApp.Models
{
    public class StockNamesModel
    {
        public List<Stonk> Stonks {get; set;}
    }

    public class Stonk 
    {
        public string Name{get; set;}
        public string Symbol{get; set;}
    }
}