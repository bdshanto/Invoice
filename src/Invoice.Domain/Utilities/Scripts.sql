use Invoice;
/*
public class Invoice
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = "";
        public string Address { get; set; } = "";
        public string InvoiceNo { get; set; } = "";// UNiQ can not be duplicate
        public DateTime OperationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public ICollection<InvoiceDetail> InvoiceList { get; set; } = new List<InvoiceDetail>();

    }

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
*/

CREATE TABLE Invoice (
	Id INT PRIMARY KEY IDENTITY,
	CustomerName NVARCHAR(100) NOT NULL,
	[Address] NVARCHAR(100) NOT NULL,
	InvoiceNo NVARCHAR(100) NOT NULL,
	OperationDate DATETIME NOT NULL,
	CreatedDate DATETIME NOT NULL,
	LastModifiedDate DATETIME NOT NULL,

    CONSTRAINT UC_InvoiceNo UNIQUE (InvoiceNo),
    CONSTRAINT PK_Id PRIMARY KEY (ID)
);

create table InvoiceDetail (
	Id INT PRIMARY KEY IDENTITY,
	ItemName NVARCHAR(100) NOT NULL,
	Qty DECIMAL(18, 2) NOT NULL,
	Amount DECIMAL(18, 2) NOT NULL,
	Total DECIMAL(18, 2) NOT NULL,
	InvoiceId INT NOT NULL,
	Warranty INT NOT NULL,
	CreatedDate DATETIME NOT NULL,
	LastModifiedDate DATETIME NOT NULL,

	CONSTRAINT FK_InvoiceId FOREIGN KEY (InvoiceId) REFERENCES Invoice(Id),
	CONSTRAINT PK_Id PRIMARY KEY (Id)
);
 