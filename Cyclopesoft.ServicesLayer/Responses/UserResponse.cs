using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Responses
{
    public class UserResponse : Core.ServiceResult
    {
        public string Password { get; set; }
        public int Rol { get; set; }
        public byte[] Img { get; set; }
        public DateTime Last_Connection { get; set; }
    }
}
