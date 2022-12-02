using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Core
{
    public class ClienteDto : BaseDto
    {
        public DateTime EnrollomentDate;
        public string Type { get; set; }
        public int FiscalId { get; set; }
        public string RNC { get; set; }
        public string BusinessName { get; set; }
        public string DirectIn { get; set; }
        public string Note { get; set; }
    }
}
