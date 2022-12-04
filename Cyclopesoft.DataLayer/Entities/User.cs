using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.DataLayer.Entities
{
    public class User : Core.Person
    {
        public string Password { get; set; }
        public string Rol { get; set; }
        public byte[] Img { get; set; }
        public DateTime Last_Connection { get; set; }
    }
}
