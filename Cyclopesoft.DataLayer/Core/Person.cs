using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.DataLayer.Core
{
    public abstract class Person :BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
