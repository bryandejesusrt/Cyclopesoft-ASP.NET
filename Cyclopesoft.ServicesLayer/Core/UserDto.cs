using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Core
{
    public class UserDto : BaseDto
    {
        public string Password { get; set; }
        public int Rol { get; set; }
        public byte[] Img { get; set; }
        public DateTime Last_Connection { get; set; }
    }
}
