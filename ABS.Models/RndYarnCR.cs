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
    
    public partial class RndYarnCR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RndYarnCR()
        {
            this.RndYarnCRDetails = new HashSet<RndYarnCRDetail>();
            this.CmnItemMasters = new HashSet<CmnItemMaster>();
            this.CmnItemMasters1 = new HashSet<CmnItemMaster>();
        }
    
        public long YarnID { get; set; }
        public string YarnCount { get; set; }
        public string YarnRatioLot { get; set; }
        public string YarnType { get; set; }
        public string YarnRatio { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public string CreatePc { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public string UpdatePc { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> DeleteBy { get; set; }
        public Nullable<System.DateTime> DeleteOn { get; set; }
        public string DeletePc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RndYarnCRDetail> RndYarnCRDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CmnItemMaster> CmnItemMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CmnItemMaster> CmnItemMasters1 { get; set; }
    }
}