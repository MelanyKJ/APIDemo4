namespace APIDemo2.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int PersonID { get; set; }
        public Person? Person { get; set; }
        public List<Detail>? Details { get; set; }
        public bool estado { get; set; }
    }
}
