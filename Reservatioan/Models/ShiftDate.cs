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
    
    public partial class ShiftDate
    {
        public int Id { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public Nullable<int> ShiftMonth { get; set; }
        public Nullable<int> ShiftYear { get; set; }
        public Nullable<int> PorsNo { get; set; }
        public Nullable<int> MidNightUnit_Id_Fk { get; set; }
        public string ShiftTitle { get; set; }
        public string ShiftDateSet { get; set; }
        public string Regdate { get; set; }
        public Nullable<int> User_Id_Fk { get; set; }
        public Nullable<int> Res_Cont_Contract_Id_Fk { get; set; }
    
        public virtual MidNightUnit MidNightUnit { get; set; }
        public virtual PoonehWebUser PoonehWebUser { get; set; }
        public virtual Res_Cont_Contract Res_Cont_Contract { get; set; }
    }
}
