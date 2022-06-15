using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    class Job
    {
        [Key]
        public Guid Id { get; set; }
        public string ServerManagement { get; set; }
        public string Programming { get; set; }
        public string SecurityManagement { get; set; }
        public string SoftwarePlanning { get; set; }
        public string Secretary { get; set; }
    }
}
