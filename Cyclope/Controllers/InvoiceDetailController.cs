using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Cyclope.Controllers
{
    public class InvoiceDetailController : Controller
    {
        // GET: InvoiceDetailController
        public ActionResult Index()
        {
            IEnumerable<Cyclopesoft.Model.InvoiceDetail> invoiceDetails = new List<Cyclopesoft.Model.InvoiceDetail>()
            {
                new Cyclopesoft.Model.InvoiceDetail{Id = 1, Id_Product =  1 , Amount = 1, Sale_Price = 1, Discout = 1}
            };
            return View(invoiceDetails);
        }

        // GET: InvoiceDetailController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InvoiceDetailController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InvoiceDetailController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Cyclopesoft.Model.InvoiceDetail model = new Cyclopesoft.Model.InvoiceDetail();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvoiceDetailController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvoiceDetailController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvoiceDetailController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InvoiceDetailController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
