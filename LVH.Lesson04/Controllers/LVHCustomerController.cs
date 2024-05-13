using LVH.Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LVH.Lesson04.Controllers
{
    public class LVHCustomerController : Controller
    {
        // GET: LVHCustomer
        public ActionResult Index()
        {
            return View();
        }
        //Action: LVHCustomerDetail
        public ActionResult LVHCustomerDetail()
        {
            //tạo đối tượng dữ liệu
            var customer = new LVHCustomer()
            {
                CustomerID = 1,
                FirstName = "Lê Vinh",
                LastName = "Huy",
                Address = "K22CNT1",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;

            return View();
        }
        public ActionResult LVHListCustomer()
        {
            var list = new List<LVHCustomer>()
            {
                new LVHCustomer()
                {
                    CustomerID = 1,
                    FirstName = "Lê Vinh",
                    LastName = "Huy",
                    Address = "K22CNT1",
                    YearOfBirth = 2004
                },
                new LVHCustomer()
                {
                    CustomerID = 2,
                    FirstName = "Lê Vinh",
                    LastName = "Huy 2",
                    Address = "K22CNT1",
                    YearOfBirth = 2004
                },
                new LVHCustomer()
                {
                    CustomerID = 3,
                    FirstName = "Lê Vinh",
                    LastName = "Huy 3",
                    Address = "K22CNT1",
                    YearOfBirth = 2004
                },
                new LVHCustomer()
                {
                    CustomerID = 4,
                    FirstName = "Lê Vinh",
                    LastName = "Huy 4",
                    Address = "K22CNT1",
                    YearOfBirth = 2004
                },
            };
            //ViewBag.list = list; //đưa dữ liệu ra view bằng đối tượng viewbag
            return View(list);

        }
    }
}