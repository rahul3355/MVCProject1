using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVCProject1.Models
{
    public partial class Employee4
    {
        public Employee4()
        {
            InverseManager = new HashSet<Employee4>();
            Leave4 = new HashSet<Leave4>();
        }

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int EmpLevel { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? ManagerId { get; set; }

        public virtual Employee4 Manager { get; set; }
        public virtual ICollection<Employee4> InverseManager { get; set; }
        public virtual ICollection<Leave4> Leave4 { get; set; }
    }
}
