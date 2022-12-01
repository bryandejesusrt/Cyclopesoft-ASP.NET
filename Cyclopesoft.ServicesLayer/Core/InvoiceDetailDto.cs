using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Core
{
    public class InvoiceDetailDto : BaseDto
    {
        public int Id_Product { get; set; }
        public int Amount { get; set; }
        public int Sale_Price { get; set; }
        public int Discout { get; set; }
    }
}
