using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Lab2Phase1.Models
{
    public class Car
    {
        [Key]
        public int Car_Id { get; set; }
        public string Model { get; set; }
        public double MaxSpeed { get; set; }
    }
}