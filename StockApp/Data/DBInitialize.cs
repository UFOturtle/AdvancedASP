using StockApp.Models;
using Microsoft.EntityFrameworkCore;  
using System;  
using System.Collections.Generic;  
using System.Data.SqlClient;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace DataContextLayer.DataContext  
{  
    public class EFDataContext : DbContext  
    {  
        public DbSet<User> Users { get; set; }  
        public DbSet<StockOwned> StocksOwned { get; set; }
        public DbSet<Wallet> Wallets { get; set; } 
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  
        {  
            optionsBuilder.UseSqlServer(@"connectionString");  
        }        
        
                    
    }  
} 