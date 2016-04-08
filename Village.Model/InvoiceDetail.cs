using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village.Model
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public virtual Loan Loan { get; set; }
        public string LoanDescription { get; set; }
        public decimal Amount { get; set; }
    }
}
