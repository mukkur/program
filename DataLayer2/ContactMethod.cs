//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer2
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContactMethod
    {
        public int Id { get; set; }
        public int ContactsId { get; set; }
        public int KeywordsId { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual Keyword Type { get; set; }
    }
}
