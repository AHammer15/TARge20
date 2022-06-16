using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class ItemLending
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<Employee> EmployeeId { get; set; }
        public string Employee { get; }
        public string Keyboard {get; set;}
        public string Mouse { get; set; }
        public string Laptop { get; set; }

    }
}
