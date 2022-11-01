using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.DataLayer.Entities
{
    public class Client : Core.Person
    {
        public string type { get; set; }
        public int Id_Fiscal { get; set; }
        public string RNC { get; set; }
        public string business_Name { get; set; }
        public string Directin { get; set; }
        public string Note { get; set; }
    }
}
