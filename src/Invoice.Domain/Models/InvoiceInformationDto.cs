namespace Invoice.Domain.Models;

public class InvoiceInformationDto
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = "";
    public string Address { get; set; } = "";
    public string InvoiceNo { get; set; } = "";
    public DateTime OperationDate { get; set; }
    public ICollection<InvoiceIteDto> InvoiceList { get; set; } = new List<InvoiceIteDto>();

}