using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Domain.Models
{
    public class InvoiceIteDto
    {
        public int Id { get; set; }
        public string ItemName { get; set; } = "";
        public decimal Qty { get; set; }
        public decimal Amount { get; set; }
        public decimal Total { get; set; }

    }
}
