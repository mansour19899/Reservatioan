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
    
    public partial class TakeAwayDocument
    {
        public int Id { get; set; }
        public byte[] DocumentFile { get; set; }
        public Nullable<int> TakeAwayDetail_Id_Fk { get; set; }
        public string FileType { get; set; }
    
        public virtual TakeAwayDetail TakeAwayDetail { get; set; }
    }
}
