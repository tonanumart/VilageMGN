using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village.Model
{
    public class Receipt
    {
        [Index(IsUnique = true)]
        public string ReceiptNo { get; set; }
        public int ReceiptId { get; set; }
        public decimal Amount { get; set; }
        public DateTime ReceiptDate { get; set; }
        [Required]
        public virtual Owner Owner { get; set; }
        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; }
    }
}
