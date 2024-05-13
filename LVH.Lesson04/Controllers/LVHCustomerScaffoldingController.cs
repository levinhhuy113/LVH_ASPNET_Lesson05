using LVH.Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LVH.Lesson04.Controllers
{
    public class LVHCustomerScaffoldingController : Controller
    {
        //mốc data
        private static List<LVHCustomer> listCutomer = new List<LVHCustomer>()
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
        // GET: LVHCustomerScaffolding
        //listcustomer
        public ActionResult Index()
        {
            return View(listCutomer);
        }
        [HttpGet]
        public ActionResult LVHCreate()
        {
            var model = new LVHCustomer();
            return View();
        }
        [HttpPost]
        public ActionResult LVHCreate(LVHCustomer model)
        {
            //Thêm mới đối tượng khách hàng vào ds dữ liệu
            listCutomer.Add(model);
            //return View();
            //chuyển về trang danh sách
            return RedirectToAction("Index");
        }
        public ActionResult LVHEdit(int id)
        {
            var customer = listCutomer.FirstOrDefault(x => x.CustomerID == id);
            return View(customer);
        }
        public ActionResult LVHDetails(int id)
        {
            var customer = listCutomer.FirstOrDefault(s => s.CustomerID == id);
            return View(customer);
        }
    }
}