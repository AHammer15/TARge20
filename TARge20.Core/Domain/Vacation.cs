using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    class Vacation
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<Employee> EmployeeId { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
    }
}
