//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Roster
    {
        public string EmpDate { get; set; }
        public int EmpID { get; set; }
        public System.DateTime RosterDate { get; set; }
        public string DutyCode { get; set; }
        public System.TimeSpan DutyTime { get; set; }
        public short WorkMin { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<bool> OpenShift { get; set; }
        public Nullable<int> RosterSubAppID { get; set; }
    }
}
