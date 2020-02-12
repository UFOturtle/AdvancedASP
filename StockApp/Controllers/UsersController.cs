using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using DataContextLayer.DataContext;  
using Microsoft.AspNetCore.Mvc;
using StockApp.Models;


namespace StockApp.Controllers  
{  
    public class UsersController : Controller  
    {  
  
        EFDataContext _dbContext = new EFDataContext();  
  
        public IActionResult UsersHome()  
        {  
            List<User> data = this._dbContext.Users.ToList();

            foreach(var row in data)
            {
                if (row.Email.ToString() == "lv@gmail.com" || row.Password.ToString() == "123456")
                {
                    break;
                }
                else
                {
                    _dbContext.Users.Add(new User {FName = "Henry", LName = "Joa", Email = "lv@gmail.com", Password = "123456"} );  
                    _dbContext.SaveChanges();
                    break;
                }
            }  
            
            data = this._dbContext.Users.ToList();

            return View(data);  
        }  
  
        public IActionResult Create()  
        {  
            return View();  
        }  
  
        [HttpPost]  
        public IActionResult Create(User model)  
        {  
            ModelState.Remove("Id");  
            if (ModelState.IsValid)  
            {  
                _dbContext.Users.Add(model);  
                _dbContext.SaveChanges();  
                return RedirectToAction("Index");  
            }  
            return View();  
        }  
  
        public IActionResult Edit(int id)  
        {  
            User data = _dbContext.Users.Where(p => p.ID == id).FirstOrDefault();  
            return View("Create", data);  
        }  
  
        [HttpPost]  
        public IActionResult Edit(User model)  
        {  
            ModelState.Remove("ID");  
            if (ModelState.IsValid)  
            {  
                _dbContext.Users.Update(model);  
                _dbContext.SaveChanges();  
                return RedirectToAction("Index");  
            }  
            return View("Create", model);  
        }  
  
        public IActionResult Delete(int id)  
        {  
            User data = _dbContext.Users.Where(p => p.ID == id).FirstOrDefault();  
            if (data != null)  
            {  
                _dbContext.Users.Remove(data);  
                _dbContext.SaveChanges();  
            }  
            return RedirectToAction("Index");  
        }  
    }  
}  