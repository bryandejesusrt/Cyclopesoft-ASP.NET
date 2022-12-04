using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Bar_Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Distribution { get; set; }
        public byte[] Image { get; set; }
        public decimal Cost_Price { get; set; }
        public decimal Gain { get; set; }
        public decimal Sale_Price { get; set; }
        public decimal Wholesale_Price { get; set; }

        //inventory
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public int Stock { get; set; }
    }
}
