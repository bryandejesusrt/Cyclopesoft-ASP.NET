using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Core
{
    public class ProductDto : BaseDto
    {
        public string Bar_Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Distribution { get; set; }
        public byte[] Image { get; set; }
        public int Cost_Price { get; set; }
        public int Gain { get; set; }
        public int Sale_Price { get; set; }
        public int Wholesale_Price { get; set; }

        //inventory
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public int Stock { get; set; }
    }
}
