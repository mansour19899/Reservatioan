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
    
    public partial class PoonehWebPage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PoonehWebPage()
        {
            this.PageContents = new HashSet<PageContent>();
            this.WebUser_Page = new HashSet<WebUser_Page>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public Nullable<int> Weight { get; set; }
        public string PageAddress { get; set; }
        public string NotifyText { get; set; }
        public string NotifyTitle { get; set; }
        public byte[] PageIcon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageContent> PageContents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebUser_Page> WebUser_Page { get; set; }
    }
}
