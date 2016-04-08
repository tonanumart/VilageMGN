using System;

namespace Village.Model
{
    public class Invoice
    {
        public Invoice()
        {

        }

        public int OwnerId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}