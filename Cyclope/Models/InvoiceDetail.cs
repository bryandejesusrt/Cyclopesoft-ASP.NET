using System;

namespace Cyclopesoft.Model
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public int Id_Product { get; set; }
        public int Amount { get; set; }
        public int Sale_Price { get; set; }
        public int Discout { get; set; }
    }
}
