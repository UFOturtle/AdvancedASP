using System;
using System.Collections.Generic;

namespace StockApp.Models
{
    public class StockNamesModel
    {
        public List<Stock> Stocks {get; set;}

    }

    public class Stock 
    {
        public string Symbol{get; set;}
        public string Name {get; set;}
    }

    
}