using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Domain.Models
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public string ItemName { get; set; } = "";

        public decimal Qty { get; set; }
        public decimal Amount { get; set; }
        public decimal Total { get; set; }

        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        /// <summary>
        /// Warranty will show by days 
        /// </summary>
        public int Warranty { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
