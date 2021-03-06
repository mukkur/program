//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Faculty
    {
        public Faculty()
        {
            this.Students = new HashSet<Student>();
            this.Programs = new HashSet<Program>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public int CampusId { get; set; }
    
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Program> Programs { get; set; }
        public virtual Campus Campu { get; set; }
        public virtual Program Program { get; set; }
        public virtual Account Account { get; set; }
        public virtual Department Department { get; set; }
    }
}
