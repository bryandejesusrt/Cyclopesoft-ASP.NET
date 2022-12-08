using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Core
{
    public class UserDto : BaseDto
    {
        public string Password { get; set; }
        public string Rol { get; set; }
        public byte[] Img { get; set; }
        public TimeSpan Last_Connection { get; set; }
    }
}
