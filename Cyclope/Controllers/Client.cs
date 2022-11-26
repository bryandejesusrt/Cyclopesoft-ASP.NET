using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection;

namespace Cyclopesoft.Controler
{
    public class Client : Controller
    {
        // GET: Client

        public ActionResult Index()
        {
            IEnumerable<Cyclopesoft.Model.Client> clients = new List<Cyclopesoft.Model.Client>() {
              new Model.Client{ type ="Nota",
                  Id_Fiscal = 1,
                  RNC = "0213", 
                  business_Name = "Cyclopsoft",
                  Note = "Nota",
                  Creation_Date = System.DateTime.Now,}
            };
            return View(clients);
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            
            return View();
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                
                return RedirectToAction(nameof(Index));
                Model.Client client = new Model.Client();   

            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
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

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
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
