using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.DataLayer.Entities
{
    public class Client : Core.Person
    {
        public DateTime EnrollomentDate;

        public string Type { get; set; }
        public string FiscalId { get; set; }
        public string RNC { get; set; }
        public string BusinessName { get; set; }
        public string Direction { get; set; }
        public string Note { get; set; }
    }
}
