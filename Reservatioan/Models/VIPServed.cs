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
    
    public partial class VIPServed
    {
        public int Id { get; set; }
        public Nullable<int> Res_Cont_ContractItem_Id_Fk { get; set; }
        public Nullable<int> Res_Cont_Contract_Id_Fk { get; set; }
        public string VIPDate { get; set; }
        public Nullable<int> User_Id_FK { get; set; }
        public string RegDate { get; set; }
        public Nullable<int> Meal_Id_Fk { get; set; }
        public Nullable<int> Forecast { get; set; }
        public string Note { get; set; }
    
        public virtual Meal Meal { get; set; }
        public virtual PoonehWebUser PoonehWebUser { get; set; }
        public virtual Res_Cont_Contract Res_Cont_Contract { get; set; }
        public virtual Res_Cont_ContractItem Res_Cont_ContractItem { get; set; }
    }
}
