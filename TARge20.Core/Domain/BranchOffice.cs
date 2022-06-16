using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class BranchOffice
    {
        [Key]
        public Guid Id { get; set; }
        public string Employees { get; set; }
        public string Office { get; set; }
        public string Computers { get; set; }
    }
}
