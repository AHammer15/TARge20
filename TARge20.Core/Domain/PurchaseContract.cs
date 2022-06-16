using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class PurchaseContract
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<Employee> EmployeeId { get; set; }
        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public DateTime ContractStart { get; set; }
        public DateTime ContractEnd { get; set; }
        public string PurchaseFrequency { get; set; }
        public DateTime ContractBreak { get; set; }
        public string Comment { get; set; }
    }
}
