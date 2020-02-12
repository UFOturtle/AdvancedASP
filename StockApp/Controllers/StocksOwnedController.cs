using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using DataContextLayer.DataContext;  
using Microsoft.AspNetCore.Mvc;
using StockApp.Models;


namespace StockApp.Controllers  
{  
    public class StocksOwnedController : Controller  
    {  
  
        EFDataContext _dbContext = new EFDataContext();  
  
        public IActionResult Portfolio()  
        {  
            List<StockOwned> data = this._dbContext.StocksOwned.ToList();
            
            _dbContext.StocksOwned.Add(new StockOwned {Name = "Amazon", userID = "1", initialInvestment = "2000", CurrentValue = "4300", numOfStocks = "4", dateBought = "01/12/2005"} );  
            _dbContext.SaveChanges();

            return View(data);  
        }  
  
        public IActionResult CreateStockOWned()  
        {  
            return View();  
        }  
  
        [HttpPost]  
        public IActionResult CreateStockOWned(StockOwned model)  
        {  
            ModelState.Remove("Stock_ID");  
            if (ModelState.IsValid)  
            {  
                _dbContext.StocksOwned.Add(model);  
                _dbContext.SaveChanges();  
                return RedirectToAction("Portfolio");  
            }  
            return View();  
        }  
  
        public IActionResult EditStockOwned(int id)  
        {  
            StockOwned data = _dbContext.StocksOwned.Where(p => p.Stock_ID == id).FirstOrDefault();  
            return View("Create", data);  
        }  
  
        [HttpPost]  
        public IActionResult EditStockOwned(StockOwned model)  
        {  
            ModelState.Remove("Stock_ID");  
            if (ModelState.IsValid)  
            {  
                _dbContext.StocksOwned.Update(model);  
                _dbContext.SaveChanges();  
                return RedirectToAction("Portfolio");  
            }  
            return View("Create", model);  
        }  
  
        public IActionResult DeleteStockOwned(int id)  
        {  
            StockOwned data = _dbContext.StocksOwned.Where(p => p.Stock_ID == id).FirstOrDefault();  
            if (data != null)  
            {  
                _dbContext.StocksOwned.Remove(data);  
                _dbContext.SaveChanges();  
            }  
            return RedirectToAction("Portfolio");  
        }  
    }  
}  