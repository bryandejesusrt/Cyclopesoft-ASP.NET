using System;

namespace Cyclopesoft.Model
{
    public class Client: Person
    {
        public string type { get; set; }
        public int Id_Fiscal { get; set; }
        public string RNC { get; set; }
        public string business_Name { get; set; }
        public string Directin { get; set; }
        public string Note { get; set; }
        public DateTime Creation_Date { get; set; }
    }
}
