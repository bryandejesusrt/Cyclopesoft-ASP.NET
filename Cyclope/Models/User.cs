using Cyclopesoft.Model;
using System;

namespace Cyclope.Model
{
    public class User: Person
    {
        public string Password { get; set; }
        public int Rol { get; set; }
        public byte[] Img { get; set; }
        public DateTime Creation_Date { get; set; }
        public DateTime Last_Connection { get; set; }

    }
}
