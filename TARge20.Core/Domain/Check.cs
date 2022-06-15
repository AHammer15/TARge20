using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    class Check
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<Employee> EmployeeId { get; set; }
        public int CheckNumber { get; set; }
        public DateTime CheckDate { get; set; }
        public DateTime CheckDeadline { get; set; }
    }
}
