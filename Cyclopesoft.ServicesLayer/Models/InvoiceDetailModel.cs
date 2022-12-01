using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Models
{
    public class InvoiceDetailModel
    {
        public int Id { get; set; }
        public int Id_Product { get; set; }
        public int Amount { get; set; }
        public int Sale_Price { get; set; }
        public int Discout { get; set; }
    }
}
