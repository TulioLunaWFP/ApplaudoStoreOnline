using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplaudoStore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string PaymentType { get; set; }
        public DateTime Date { get; set; }

        public string Status { get; set; }
        public decimal Total { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
