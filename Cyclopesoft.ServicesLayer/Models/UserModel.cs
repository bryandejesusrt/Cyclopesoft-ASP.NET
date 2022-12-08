using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Models
{
    public class UserModel
    {
        public string Password { get; set; }
        public string Rol { get; set; }
        public byte[] Img { get; set; }
        public TimeSpan Last_Connection { get; set; }
    }
}
