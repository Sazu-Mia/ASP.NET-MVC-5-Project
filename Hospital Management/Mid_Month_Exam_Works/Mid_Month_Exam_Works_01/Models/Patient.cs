//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mid_Month_Exam_Works_01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int Phone { get; set; }
        public string BloodGroup { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int DoctorId { get; set; }
    
        public virtual Doctor Doctor { get; set; }
    }
}
