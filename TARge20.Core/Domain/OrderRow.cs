using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class OrderRow
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<Order> OrderId { get; set; }
        public int RowNumber { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
    }
}
