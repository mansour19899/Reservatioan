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
    
    public partial class UsedService
    {
        public int Id { get; set; }
        public Nullable<int> Tray_Id_Fk { get; set; }
        public Nullable<int> Person_Id_Fk { get; set; }
        public Nullable<int> Company_Id_Fk { get; set; }
        public Nullable<int> Unit_Id_Fk { get; set; }
        public Nullable<int> Contractor_Id_Fk { get; set; }
        public string USDate { get; set; }
        public Nullable<int> Meal_Id_Fk { get; set; }
        public Nullable<bool> IsReserved { get; set; }
        public string USTime { get; set; }
        public Nullable<int> Restaurant_Id_Fk { get; set; }
        public byte[] USImage { get; set; }
        public Nullable<int> EmploymentType_Id_Fk { get; set; }
        public Nullable<int> Person_identifyInfo_Id_Fk { get; set; }
        public Nullable<int> IdentifyScore { get; set; }
        public Nullable<int> GuestGeneral_Id_Fk { get; set; }
        public Nullable<int> ExtraTime_Id_Fk { get; set; }
        public Nullable<System.DateTime> PoonehArchived { get; set; }
    }
}
