//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntroEF.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseStudent
    {
        public int Id { get; set; }
        public int CId { get; set; }
        public int StId { get; set; }
        public System.DateTime EnrollTime { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Student Student { get; set; }
    }
}
