using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class HealthCheckup
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<Employee> EmployeeId { get; set; }
        public DateTime DoctorsAppointment { get; set; }
        public string AppointmentTimeArrangement { get; set; }
    }
}
