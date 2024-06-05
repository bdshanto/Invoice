using Invoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Invoice.Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Sample data
            var invoice = new Domain.Models.Invoice
            {
                Id = 1,
                CustomerName = "John Doe",
                Address = "123 Main St",
                ContactNumber = "555-1234",
                InvoiceNo = "INV123456",
                OperationDate = DateTime.Now,
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now,
                InvoiceDetails = new List<InvoiceDetail>
                {
                    new InvoiceDetail { Id = 1, ItemName = "Item 1", Qty = 1, Amount = 10, Total = 10, Warranty = 30, CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                    new InvoiceDetail { Id = 2, ItemName = "Item 2", Qty = 2, Amount = 20, Total = 40, Warranty = 30, CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now }
                }
            };


            // Load data into the report
            ReportDataSource invoiceDataSource = new ReportDataSource("InvoiceDataSet", new List<Domain.Models.Invoice> { invoice });
            ReportDataSource invoiceDetailDataSource = new ReportDataSource("InvoiceDetailDataSet", invoice.InvoiceDetails);

            var path = Path.Combine(Environment.CurrentDirectory, "Reports", "VoucherReport.rdlc");
            reportViewer1.LocalReport.ReportPath = path;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(invoiceDataSource);
            reportViewer1.LocalReport.DataSources.Add(invoiceDetailDataSource);

            reportViewer1.RefreshReport();

        }

        private List<Domain.Models.Invoice> GetInvoiceData()
        {
            // Create a list of invoices with details
            var invoices = new List<Domain.Models.Invoice>
        {
            new Domain.Models.Invoice
            {
                Id = 1,
                CustomerName = "Customer A",
                Address = "Address A",
                ContactNumber = "1234567890",
                InvoiceNo = "INV001",
                OperationDate = DateTime.Now,
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now,
                InvoiceDetails = new List<InvoiceDetail>
                {
                    new InvoiceDetail
                    {
                        Id = 1,
                        ItemName = "Item 1",
                        Qty = 2,
                        Amount = 50,
                        Total = 100,
                        Warranty = 30,
                        CreatedDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now
                    },
                    new InvoiceDetail
                    {
                        Id = 2,
                        ItemName = "Item 2",
                        Qty = 1,
                        Amount = 150,
                        Total = 150,
                        Warranty = 60,
                        CreatedDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now
                    }
                }
            },
            new Domain.Models.Invoice
            {
                Id = 2,
                CustomerName = "Customer B",
                Address = "Address B",
                ContactNumber = "0987654321",
                InvoiceNo = "INV002",
                OperationDate = DateTime.Now,
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now,
                InvoiceDetails = new List<InvoiceDetail>
                {
                    new InvoiceDetail
                    {
                        Id = 3,
                        ItemName = "Item 3",
                        Qty = 3,
                        Amount = 200,
                        Total = 600,
                        Warranty = 90,
                        CreatedDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now
                    }
                }
            }
        };

            return invoices;
        }
    }





}