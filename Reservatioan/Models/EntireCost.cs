//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reservatioan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EntireCost
    {
        public int Id { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public Nullable<int> Meal_Id_Fk { get; set; }
        public Nullable<long> NormalBIPC { get; set; }
        public Nullable<long> NormalOverhaul { get; set; }
        public Nullable<long> NormalOtherCompany { get; set; }
        public Nullable<long> VIPBIPC { get; set; }
        public Nullable<long> VIPOverhaul { get; set; }
        public Nullable<long> VIPOtherCompany { get; set; }
    
        public virtual Meal Meal { get; set; }
    }
}
