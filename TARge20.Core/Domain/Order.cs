using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<Company> CompanyId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Comment { get; set; }
    }
}
