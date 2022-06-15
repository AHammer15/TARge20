using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Children
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
