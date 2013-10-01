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
    
    public partial class Campus
    {
        public Campus()
        {
            this.Students = new HashSet<Student>();
            this.Faculties = new HashSet<Faculty>();
            this.Programs = new HashSet<Program>();
            this.Departments = new HashSet<Department>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string CampusType { get; set; }
    
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Faculty> Faculties { get; set; }
        public virtual ICollection<Program> Programs { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}