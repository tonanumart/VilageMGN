using System;

namespace Village.Model
{
    public class Invoice
    {
        public Invoice()
        {

        }

        public Guid InvoiceId { get; set; }
        public int OwnerId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}