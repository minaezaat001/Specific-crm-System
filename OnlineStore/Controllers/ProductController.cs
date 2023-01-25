using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using OnlineStore.Models.Data;
using OnlineStore.Models.Repository;

namespace OnlineStore.Controllers
{
  
    public class ProductController : Controller
    {
        private readonly IStore<Product> product;
        private readonly AppDbContext dp;

        public ProductController(IStore<Product> product , AppDbContext dp)
        {
            this.product = product;
            this.dp = dp;
        }
        // GET: ProductController
         
        public IActionResult Index()
        {
            ViewBag.COU = "formadd";
            ViewBag.alldata = product.List();
            return View();



        }

        // POST: ProductController/Create
        [HttpPost]

        public void Create(Product product)
        {
            
            
              this.product.Add(product);

        }


        // GET: ProductController/Edit/5
        public IActionResult Edit(int id )
        {

            var product = this.product.Find(id);
            ViewBag.alldata = this.product.List();
            ViewBag.COU = "formupdate";
            return View("Index", product);

           

        }


        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product  product)
        {
            //this.product.Update(product.ProdID, product);

            dp.Products.Update(product);
            dp.SaveChanges();
            return RedirectToAction(nameof(Index));
        
        }

      
        public ActionResult Delete(int id)
        {
            this.product.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        

       




























    }
}
