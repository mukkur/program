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
    
    public partial class Program
    {
        public Program()
        {
            this.Students = new HashSet<Student>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string DepartmentId { get; set; }
        public int FacultyId { get; set; }
        public int CampusId { get; set; }
    
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual Campus Campu { get; set; }
        public virtual Faculty Faculty1 { get; set; }
    }
}
