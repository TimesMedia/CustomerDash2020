using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderView.Dataacc;
using OrderView.Models;

namespace OrderView.Controllers
{
    public class HomeController : Controller
    {
        ProductDAL _adress = new ProductDAL();
        
        public ActionResult Index()
        {
            List<Products>  lProducts = _adress.GetAllProducts();
            return View("Index", lProducts);
        }

        [HttpGet]

        public ActionResult Address(string Address)
        {
            //Addresee lAddressee = new Addresee();
            //lAddressee.Address = AddressString;

            List<Products> lProducts = _adress.GetAllProducts();


            Products lProduct = lProducts.Where(x => x.Address == Address).Single();


            return View("Address", lProduct);
        }


        [HttpPost]

        public ActionResult Address(OrderView.Models.Products Address)
        {
            ViewBag.Message = Address.Name;


            // Update the database.

            ViewBag.Message = "The database has been updated to " + Address.Name;



            //Addresee lAddressee = new Addresee();
            //lAddressee.Address = AddressString;
            return View( "Index");
        }






        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
    }
}