using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;  
using System.ComponentModel.DataAnnotations.Schema;  

namespace StockApp.Models
{
    public class StockOwned 
    {
        [Key]
        public int Stock_ID { get; set; }
        public string Name { get; set; } 
        public string userID { get; set; }
        public string initialInvestment { get; set; }
        public string CurrentValue { get; set; }
        public string numOfStocks { get; set; }
        public string dateBought { get; set; }
    }

    
}