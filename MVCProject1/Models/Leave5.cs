using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVCProject1.Models
{
    public partial class Leave5
    {
        public int Lid { get; set; }
        public int EmployeeId { get; set; }
        public int EmplLevel { get; set; }
        public int ManagerId { get; set; }
        public int LeavesInHand { get; set; }

        [DataType(DataType.Date)]
        public DateTime LeaveStart { get; set; }

        [DataType(DataType.Date)]
        public DateTime LeaveEnd { get; set; }
        public string LeaveType { get; set; }
        public string Reason { get; set; }
        public int? LeaveStatus { get; set; }
    }
}
