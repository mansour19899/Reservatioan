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
    
    public partial class TrayItem
    {
        public int Id { get; set; }
        public Nullable<int> Food_Id_Fk { get; set; }
        public Nullable<int> Tray_Id_Fk { get; set; }
    
        public virtual Food Food { get; set; }
        public virtual Tray Tray { get; set; }
    }
}
