using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class MailBox
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<BranchOffice> BranchOfficeId { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
    }
}
