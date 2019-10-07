using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarRental.Models;


namespace CarRental.Controllers{
    public class CatalogController : Controller
    {

        private DataContext db {get; set;}

        public CatalogController(DataContext context){
            this.db = context;
        }
        public IActionResult Index(){
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetCatalog()
        {
            
            List<Car> cars = new List<Car>();
        

            foreach(var Car in db.Cars){
                cars.Add(Car);
            }
         
            return Json(cars);



        }
          

          [HttpPost]
        public IActionResult SaveCar([FromBody] Car carToRegister)
        {

             db.Cars.Add(carToRegister); //add car (on memory ONLY)
             db.SaveChanges();//submit changes to DB
              return Json(carToRegister);
              

        }
    }
}