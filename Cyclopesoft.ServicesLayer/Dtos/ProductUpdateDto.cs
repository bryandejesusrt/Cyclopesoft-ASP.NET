﻿using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.ServicesLayer.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Dtos
{
    public class ProductUpdateDto : ProductDto
    {
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string BusinessName { get; set; }
        public string DirectIn { get; set; }
        public int ModifyUser { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
