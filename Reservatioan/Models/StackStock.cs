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
    
    public partial class StackStock
    {
        public int Id { get; set; }
        public Nullable<int> Material_Id_Fk { get; set; }
        public Nullable<long> Amount { get; set; }
        public string Note { get; set; }
        public Nullable<int> Stack_Id_Fk { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Stack Stack { get; set; }
    }
}
