//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AppErrorLog
    {
        public long ErrorID { get; set; }
        public int CompanyID { get; set; }
        public string ErrorMethod { get; set; }
        public string ErrorFile { get; set; }
        public string ErrorLine { get; set; }
        public string ErrorPath { get; set; }
        public string ErrorType { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorSource { get; set; }
        public string ErrorStack { get; set; }
        public Nullable<System.DateTime> ErrorDate { get; set; }
        public Nullable<bool> IsSolved { get; set; }
    }
}