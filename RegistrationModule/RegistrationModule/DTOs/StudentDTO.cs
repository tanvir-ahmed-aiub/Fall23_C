using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationModule.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<double> Cgpa { get; set; }
        public int DeptId { get; set; }
    }
}