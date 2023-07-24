using Microsoft.AspNetCore.Mvc;
using SimplePaymentSystem.Models;
using System.Collections.Generic;

namespace SimplePaymentSystem.Controllers
{
    public class HomeController : Controller
    {
        private static List<Payment> payments = new List<Payment>();

        public IActionResult Index()
        {
            return View(payments);
        }

        public IActionResult CreatePayment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePayment(Payment payment)
        {
            if (ModelState.IsValid)
            {
                payments.Add(payment);
                return RedirectToAction("Index");
            }

            return View(payment);
        }
    }
}
