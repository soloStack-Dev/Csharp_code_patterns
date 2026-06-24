namespace DesignPatters
{
    public class SingleRespon
    {
        static void Main(String[] args)
        {
            Invoice invoice = new Invoice()
            {
                //create obj with structural datas
                InvoiceId = 1001,
                IssuedDate = DateOnly.FromDateTime(DateTime.Now),
                Customer = "Alice",
                TotalAmount = 100.00m,
                Description = "Invoice for services provided"
            };
            //save from inmemory database
            InvoiceRepository invoiceRepository = new InvoiceRepository();
            invoiceRepository.Save(invoice);
        }
    }
}

//define Invoice class
class Invoice
{
    //define 5 properties
    public int InvoiceId { get; set; }
    public DateOnly IssuedDate { get; set; }
    public string? Customer { get; set; }
    public decimal TotalAmount { get; set; }
    public string? Description { get; set; }
}

class InvoiceRepository
{
    public void Save(Invoice invoice)
    {
        Console.WriteLine($"Saving invoice {invoice.InvoiceId} to database...");
    }
}

//So this SingleResponsibilityPrinciple is followed better for write scalable code.
//because some classes give a jobs to do multiple actions like save, update, delete, get, etc.
//so one class do only one jobs that give code reliablity