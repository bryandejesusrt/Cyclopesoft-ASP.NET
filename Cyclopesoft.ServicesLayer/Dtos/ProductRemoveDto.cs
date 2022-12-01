using Cyclopesoft.ServicesLayer.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Dtos
{
    public class ProductRemoveDto : ProductDto
    {
        public int? DeleteUser { get; set; }
        public DateTime DeleteData { get; set; }
        public bool Deleted { get; set; }
    }
}
