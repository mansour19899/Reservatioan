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
    
    public partial class HelpDesk
    {
        public int Id { get; set; }
        public Nullable<int> WebUser_Id_Fk { get; set; }
        public string HDTitle { get; set; }
        public string HDBody { get; set; }
        public Nullable<int> HelpDeskCategory_Id_Fk { get; set; }
        public string HDDate { get; set; }
        public string HDTime { get; set; }
        public Nullable<bool> IsReaded { get; set; }
    
        public virtual HelpDeskCategory HelpDeskCategory { get; set; }
        public virtual PoonehWebUser PoonehWebUser { get; set; }
    }
}