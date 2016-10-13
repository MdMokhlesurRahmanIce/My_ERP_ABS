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
    
    public partial class PrdDyingMachineSetup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrdDyingMachineSetup()
        {
            this.PrdDyingMachineSetupDetails = new HashSet<PrdDyingMachineSetupDetail>();
        }
    
        public long SetupID { get; set; }
        public Nullable<long> SetID { get; set; }
        public Nullable<long> ItemID { get; set; }
        public long MechineID { get; set; }
        public decimal Speed { get; set; }
        public decimal Moiture { get; set; }
        public decimal KGPreMin { get; set; }
        public int CompanyID { get; set; }
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
    
        public virtual CmnItemMaster CmnItemMaster { get; set; }
        public virtual CmnItemMaster CmnItemMaster1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdDyingMachineSetupDetail> PrdDyingMachineSetupDetails { get; set; }
    }
}