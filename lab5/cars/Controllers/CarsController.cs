using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cars.Models;
using cars.Data;

namespace Cars.Controllers
{
    public class CarsController : Controller
    {
        private readonly CarsContext _context;

        public CarsController(CarsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> CarsList()
        {
            return View(await _context.Cars.ToListAsync());
        }
    }
}