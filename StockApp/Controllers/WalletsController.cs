using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using DataContextLayer.DataContext;  
using Microsoft.AspNetCore.Mvc;
using StockApp.Models;


namespace StockApp.Controllers  
{  
    public class WalletsController : Controller  
    {  
  
        EFDataContext _dbContext = new EFDataContext();  
  
        public IActionResult MyWallet()  
        {  
            List<Wallet> data = this._dbContext.Wallets.ToList();
            
            _dbContext.Wallets.Add(new Wallet {BuyingPower = 15300 , Investing = 12000, userID = "1"} );  
            _dbContext.SaveChanges();

            return View(data);  
        }  
  
        public IActionResult CreateWalletOWned()  
        {  
            return View();  
        }  
  
        [HttpPost]  
        public IActionResult CreateWallet(Wallet model)  
        {  
            ModelState.Remove("Wallet_ID");  
            if (ModelState.IsValid)  
            {  
                _dbContext.Wallets.Add(model);  
                _dbContext.SaveChanges();  
                return RedirectToAction("MyWallet");  
            }  
            return View();  
        }  
  
        public IActionResult EditWallet(int id)  
        {  
            Wallet data = _dbContext.Wallets.Where(p => p.Wallet_ID == id).FirstOrDefault();  
            return View("Create", data);  
        }  
  
        [HttpPost]  
        public IActionResult EditWallet(Wallet model)  
        {  
            ModelState.Remove("Wallet_ID");  
            if (ModelState.IsValid)  
            {  
                _dbContext.Wallets.Update(model);  
                _dbContext.SaveChanges();  
                return RedirectToAction("MyWallet");  
            }  
            return View("Create", model);  
        }  
  
        public IActionResult DeleteWallet(int id)  
        {  
            Wallet data = _dbContext.Wallets.Where(p => p.Wallet_ID == id).FirstOrDefault();  
            if (data != null)  
            {  
                _dbContext.Wallets.Remove(data);  
                _dbContext.SaveChanges();  
            }  
            return RedirectToAction("MyWallet");  
        }  
    }  
}  