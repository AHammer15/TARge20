using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class SickLeave
    {
        [Key]
        public Guid Id { get; set; }
        public string Symptoms { get; set; }
        public string Illness { get; set; }
    }
}
