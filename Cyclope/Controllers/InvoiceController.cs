﻿using Cyclope.Extentions;
using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.ServicesLayer.Contracts;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Cyclope.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly ILogger<InvoiceController> _logger;
        private readonly IInvoiceService _invoiceService;
        public InvoiceController(ILogger<InvoiceController> logger, IInvoiceService invoiceService)
        {
            _logger = logger;
            _invoiceService = invoiceService;
        }
        // GET: InvoiceController
        public ActionResult Index()
        {

            var invoices = ((List<InvoiceModel>)_invoiceService.GetAll().Data).ConvertInvoiceModelToModel();

            return View(invoices);
        }

        // GET: InvoiceController/Details/5
        public ActionResult Details(int id)
        {
            var invoice = ((InvoiceModel)_invoiceService.GetById(id).Data).ConvertInvoiceToModel();
            return View(invoice);
        }

        // GET: InvoiceController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: InvoiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Invoice invoiceModel)
        {
            try
            {
                //Cyclopesoft.Model.Invoice invoice = new Cyclopesoft.Model.Invoice();
                InvoiceSaveDto invoiceSaveDto = new InvoiceSaveDto()
                {
                    Serie = invoiceModel.Serie,
                    RNC = invoiceModel.RNC,
                    Expiration_Date = invoiceModel.Expiration_Date,
                    Payment_Type = invoiceModel.Payment_Type,
                    Client_Id = invoiceModel.Client_Id,
                    User_Id = invoiceModel.User_Id,
                    Subtotal = invoiceModel.Subtotal,
                    Taxes = invoiceModel.Taxes,
                    Total = invoiceModel.Total,
                    Status = invoiceModel.Status,
                    Note = invoiceModel.Note
                };
                _invoiceService.SaveInvoice(invoiceSaveDto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvoiceController/Edit/5
        public ActionResult Edit(int id)
        {
            var invoice = (InvoiceModel)_invoiceService.GetById(id).Data;
            InvoiceModel invoiceModel = new InvoiceModel()
            {
                Serie = invoice.Serie,
                RNC = invoice.RNC,
                Expiration_Date = invoice.Expiration_Date,
                Payment_Type = invoice.Payment_Type,
                Client_Id = invoice.Client_Id,
                User_Id = invoice.User_Id,
                Subtotal = invoice.Subtotal,
                Taxes = invoice.Taxes,
                Total = invoice.Total,
                Status = invoice.Status,
                Note = invoice.Note
            };
            return View();
        }

// POST: InvoiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InvoiceModel invoiceModel)
        {
            try
            {
                InvoiceUpdateDto invoice = new InvoiceUpdateDto()
                {
                    Serie = invoiceModel.Serie,
                    RNC = invoiceModel.RNC,
                    Expiration_Date = invoiceModel.Expiration_Date,
                    Payment_Type = invoiceModel.Payment_Type,
                    Client_Id = invoiceModel.Client_Id,
                    User_Id = invoiceModel.User_Id,
                    Subtotal = invoiceModel.Subtotal,
                    Taxes = invoiceModel.Taxes,
                    Total = invoiceModel.Total,
                    Status = invoiceModel.Status,
                    Note = invoiceModel.Note
                };
                _invoiceService.UpdateInvoice(invoice);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

// GET: InvoiceController/Delete/5
public ActionResult Delete(int id)
{
            var invoice = (InvoiceModel)_invoiceService.GetById(id).Data;
            InvoiceModel invoiceModel = new InvoiceModel()
            {
                Serie = invoice.Serie,
                RNC = invoice.RNC,
                Expiration_Date = invoice.Expiration_Date,
                Payment_Type = invoice.Payment_Type,
                Client_Id = invoice.Client_Id,
                User_Id = invoice.User_Id,
                Subtotal = invoice.Subtotal,
                Taxes = invoice.Taxes,
                Total = invoice.Total,
                Status = invoice.Status,
                Note = invoice.Note
            };
            return View(invoiceModel);
}

// POST: InvoiceController/Delete/5
[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Delete(InvoiceModel invoiceModel)
{
    try
    {
                var currentModel = invoiceModel;
                InvoiceRemoveDto invoiceRemove = new InvoiceRemoveDto()
                {
                    Serie = invoiceModel.Serie,
                    RNC = invoiceModel.RNC,
                    Expiration_Date = invoiceModel.Expiration_Date,
                    Payment_Type = invoiceModel.Payment_Type,
                    Client_Id = invoiceModel.Client_Id,
                    User_Id = invoiceModel.User_Id,
                    Subtotal = invoiceModel.Subtotal,
                    Taxes = invoiceModel.Taxes,
                    Total = invoiceModel.Total,
                    Status = invoiceModel.Status,
                    Note = invoiceModel.Note
                };

                _invoiceService.RemoveInvoice(invoiceRemove);
        return RedirectToAction(nameof(Index));
    }
    catch
    {
        return View();
    }
}
    }
}
