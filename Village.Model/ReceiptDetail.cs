using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village.Model
{
    public class ReceiptDetail
    {
        public int Id { get; set; }
        public virtual Loan Loan { get; set; }
        public string ReceiptDescription { get; set; }
        public decimal Amount { get; set; }
        [Required]
        public virtual InvoiceDetail InvoiceDetail { get; set; }
    }
}
