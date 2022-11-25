
using System;

namespace Cyclopesoft.ServicesLayer.Models
{
    public class GetInvoiceClient: ClientModel
    {      
        public int IdClientInvoice { get; set; }
        public int TotalInvoice { get; set; }
        public DateTime DateInvoice { get; set; }
    }
}
