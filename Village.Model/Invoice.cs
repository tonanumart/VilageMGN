using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village.Model
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public string InvoiceNumber { get; set; }
        public int MyProperty { get; set; }

    }
}
