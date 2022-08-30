using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVCProject1.Models
{
    public partial class Employee2
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public int Did { get; set; }
        public string Dmanager { get; set; }
        public DateTime? LeaveFrom { get; set; }
        public DateTime? LeaveTo { get; set; }
        public string LeaveType { get; set; }
        public string LeaveDesc { get; set; }
        public int? LeavesInHand { get; set; }
        public int? Status { get; set; }
    }
}
