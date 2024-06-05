using System;
using System.Collections.Generic;

namespace Invoice.Domain.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = "";
        public string ContactNumber { get; set; } = "";
        public string Address { get; set; } = "";
        public string InvoiceNo { get; set; } = "";
        public DateTime OperationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    }
}