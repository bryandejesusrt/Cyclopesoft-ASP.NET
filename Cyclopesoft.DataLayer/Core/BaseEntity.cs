
using System;

namespace Cyclopesoft.DataLayer.Core
{
    public abstract class BaseEntity
    {
        public BaseEntity(){
            this.CreationDate = DateTime.Now;
            this.Deleted = false;
        }
        
        public string CreationUser { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifyUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool Deleted { get; set; }

    }
}
