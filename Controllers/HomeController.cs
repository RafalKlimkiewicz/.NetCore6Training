//using Microsoft.AspNetCore.Mvc;
//using LanguageFeatures.Models;

using System.Reflection.Metadata.Ecma335;
using LanguageFeatures.Extensions;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product?[] products = Product.GetProducts();

            //1
            //var p = products[0];
            //string val;

            //if (p != null)
            //    val = p.Name;
            //else
            //    val = "No value";

            //return View(new string[] { val });

            //2
            //string? val2 = products[0]?.Name;

            //if (val2 != null)
            //    return View(new string[] { val2 });

            //return View(new string[] { "No value" });


            //3 ??
            //return View(new string[] { products[0]?.Name ?? "No value" });

            //4 !
            //return View(new string[] { products[0]!.Name });

            //5 interpolation
            //return View(new string[] { $"Name: {products[0]?.Name}, Price: {products[0]?.Price}" });

            //var data = new object[]
            //{
            //    275M, 29.95M, "apple", "orange", 100, 10
            //};

            //decimal total = 0;

            //6
            //for (int i = 0; i < data.Length; i++)
            //    if (data[i] is decimal d)
            //        total += d;

            //7
            //for (int i = 0; i < data.Length; i++)
            //{
            //    switch (data[i])
            //    {
            //        case decimal decimalValue:
            //            total += decimalValue;
            //            break;
            //        case int intValue when intValue > 50:
            //            total += intValue; 
            //            break;
            //    }
            //}

            //8
            ShoppingCart cart = new()
            {
                Products = Product.GetProducts()
            };

            //decimal cartTotal = cart.TotalPrices();

            Product[] productArray =
            {
                new Product { Name= "Kajak", Price = 275M},
                new Product { Name = "LifeJacket", Price = 48.95M},
                new Product { Name = "Soccer ball", Price = 19.50M},
                new Product { Name = "Corner flag", Price = 34.95M}
            };

            var cartTotal = cart.TotalPrices();
            var arrayTotal = productArray.FilterByPrice(20).TotalPrices();

            return View("Index", new string[] { $"Cart Total: {cartTotal:C2} \n Array Total: {arrayTotal:C2}" });
        }
    }
}
