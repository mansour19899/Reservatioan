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
    
    public partial class Kiosk
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public Nullable<int> Location_Id_Fk { get; set; }
        public string KType { get; set; }
        public Nullable<int> KGateway_Id_Fk { get; set; }
        public Nullable<int> KioskMessage_Id_Fk { get; set; }
        public string KioskMessageEndDate { get; set; }
        public string KioskMessageStartDate { get; set; }
    
        public virtual KioskMessage KioskMessage { get; set; }
    }
}
