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
    
    public partial class Schedule13951005
    {
        public int Id { get; set; }
        public string SDate { get; set; }
        public Nullable<int> Restaurant_Id_Fk { get; set; }
        public Nullable<int> Tray_Id_Fk { get; set; }
        public string RegDate { get; set; }
        public Nullable<int> Meal_Id_Fk { get; set; }
        public Nullable<int> PorsNo { get; set; }
        public Nullable<int> Res_Cont_Contract_Id_Fk { get; set; }
        public Nullable<int> AdditionalPorsNo { get; set; }
        public Nullable<int> RemainPorsNo { get; set; }
        public Nullable<System.DateTime> PoonehArchived { get; set; }
    }
}
