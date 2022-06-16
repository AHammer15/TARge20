using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class PriceDynamics
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<PurchaseContract> PurchaseContractId { get; set; }
        public int MinimumAmount { get; set; }
        public int MaximumAmount { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public double Price { get; set; }
        public string Comment { get; set; }
    }
}
