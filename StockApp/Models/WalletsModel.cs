using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;  
using System.ComponentModel.DataAnnotations.Schema;  

namespace StockApp.Models
{
    [Table("Wallets", Schema = "dbo")]  
    public class Wallet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
        public int Wallet_ID { get; set; }

        [Required]  
        [Column(TypeName = "float")]  
        public float BuyingPower { get; set; }

        [Required]  
        [Column(TypeName = "float")]   
        public float Investing { get; set; }
        
        [Required]  
        [Column(TypeName = "varchar(2000)")]  
        public string userID { get; set; }
    }

    
}