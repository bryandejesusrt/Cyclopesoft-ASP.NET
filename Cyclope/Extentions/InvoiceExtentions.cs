using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.ServicesLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cyclope.Extentions
{
    public static class InvoiceExtentions
    {
        public static List<Invoice> ConvertInvoiceModelToModel(this List<InvoiceModel> invoiceModels)
        {
            var invoices = invoiceModels.Select(inv => new Invoice()
            {
                Id = inv.Id,
                Serie = inv.Serie,
                RNC = inv.RNC,
                Expiration_Date = inv.Expiration_Date,
                Payment_Type = inv.Payment_Type,
                Client_Id = inv.Client_Id,
                User_Id = inv.User_Id,
                Subtotal = inv.Subtotal,
                Taxes = inv.Taxes,
                Total = inv.Total,
                Status = inv.Status,
                Note = inv.Note

            }).ToList();

            return invoices;
        }

        public static Invoice ConvertInvoiceToModel(this InvoiceModel invoiceModel)
        {
            return new Invoice()
            {
                Id = invoiceModel.Id,
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
        }
    }
}
