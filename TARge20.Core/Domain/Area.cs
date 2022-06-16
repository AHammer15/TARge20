using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Area
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<Region> RegionId { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public string Comment { get; set; }
    }
}
