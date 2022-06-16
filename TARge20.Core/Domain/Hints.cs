using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Hints
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<BranchOffice> BranchOfficeId { get; set; }
        public string Advice { get; set; }
        public string Evaluation { get; set; }
    }
}
