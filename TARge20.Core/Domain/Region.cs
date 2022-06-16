using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Region
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<BranchOffice> BranchOfficeId { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public string Comment { get; set; }
    }
}
