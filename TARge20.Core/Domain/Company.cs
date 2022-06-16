using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<BranchOffice> BranchOfficeId { get; set; }
        public string Name { get; set; }
        public int RegistryNumber { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public int Phone { get; set; }
        public string EMail { get; set; }
        public string Comment { get; set; }
    }
}
