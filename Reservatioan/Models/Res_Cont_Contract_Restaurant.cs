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
    
    public partial class Res_Cont_Contract_Restaurant
    {
        public int Id { get; set; }
        public Nullable<int> Restaurant_Id_Fk { get; set; }
        public Nullable<int> Res_Cont_Contract_Id_Fk { get; set; }
    
        public virtual Res_Cont_Contract Res_Cont_Contract { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
