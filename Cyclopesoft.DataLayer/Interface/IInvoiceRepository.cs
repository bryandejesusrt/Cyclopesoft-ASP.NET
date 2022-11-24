﻿using Cyclopesoft.DataLayer.Entities;
using System.Collections.Generic;

namespace Cyclopesoft.DataLayer.Interface
{
    public interface IInvoiceRepository
    {
        void Save(Invoice invoice);
        void Update(Invoice invoice);
        void Remove(Invoice invoice);
        public Invoice GetInvoice(int id);
        public bool ExistInvoice(int id);
        IEnumerable<Invoice> GetInvoices();
    }
}
