using Cyclopesoft.Model;
using System;

namespace Cyclopesoft.Model
{
    public class User: Person
    {
        public string Password { get; set; }
        public string Rol { get; set; }
        public byte[] Img { get; set; }
        public DateTime Creation_Date { get; set; }
        public TimeSpan Last_Connection { get; set; }

    }
}
