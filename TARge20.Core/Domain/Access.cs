using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Access
    {
        [Key]
        public Guid Id { get; set; }
        public bool ServerAccess { get; set; }
        public bool ComputerAccess { get; set; }
        public bool SoftwareAccess { get; set; }

    }
}
