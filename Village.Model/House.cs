using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village.Model
{
    public class House
    {
        [Key]
        public string HouseNo { get; set; }
        public double AreaSquareWa { get; set; }
        public virtual Owner Owner { get; set; }
        public decimal MonthlyFee { get; set; }
    }
}
