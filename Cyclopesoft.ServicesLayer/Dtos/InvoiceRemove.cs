using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Dtos
{
    internal class InvoiceRemove
    {
        public int Id { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime DeleteData { get; set; }
        public bool Deleted { get; set; }
    }
}
