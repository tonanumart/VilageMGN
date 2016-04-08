using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Village.Model
{
    public class Invoice
    {
        public Invoice()
        {

        }
        public int InvoiceId { get; set; }
        public virtual Owner Owner { get; set; }
        [Index(IsUnique = true)]
        public string InvoiceNo { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DueDate { get; set; }
        public int InvoiceYear { get; set; }
        public int InvoiceMonth { get; set; }
        public InvoiceStatus InvoiceStatus { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}