
using System;

namespace Cyclopesoft.DataLayer.Core
{
    public class BaseEntity
    {
        public BaseEntity(){
            this.Creation_Date = DateTime.Now;
            this.Deleted = false;
        }
        
        public int Creation_User { get; set; }
        public DateTime Creation_Date { get; set; }
        public int? Modify_User { get; set; }
        public DateTime? Modify_Date { get; set; }
        public int? Delete_User { get; set; }
        public DateTime Delete_Data { get; set; }
        public bool Deleted { get; set; }

    }
}
