using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Village.Model
{
    public class Owner
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("House")]
        public string HouseNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Person")]
        public Guid PersonId { get; set; }

        [Required]
        public virtual House House { get; set; }

        [Required]
        public virtual Person Person { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
