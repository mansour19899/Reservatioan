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
    
    public partial class GuestGeneral
    {
        public int Id { get; set; }
        public string GuestName { get; set; }
        public Nullable<int> GuestCard_Id_Fk { get; set; }
        public string CardName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public Nullable<int> Unit_Id_Fk { get; set; }
        public Nullable<int> Restaurant_Id_Fk { get; set; }
        public Nullable<bool> Lunch { get; set; }
        public Nullable<bool> Dinner { get; set; }
        public Nullable<bool> AfterNight { get; set; }
        public Nullable<bool> ExtraMeal { get; set; }
        public Nullable<bool> Eftar { get; set; }
        public Nullable<int> RegUser_Id_Fk { get; set; }
        public string RegDate { get; set; }
        public Nullable<int> Company_Id_Fk { get; set; }
        public Nullable<System.DateTime> PoonehArchived { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual GuestCard GuestCard { get; set; }
        public virtual PoonehWebUser PoonehWebUser { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
