using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    class SalesContract
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Begins { get; set; }
        public DateTime Ends { get; set; }
        public int Quantity { get; set; }
        public string Frequency { get; set; }
        public bool AutomaticExtension { get; set; }
        public string Comment { get; set; }
    }
}
