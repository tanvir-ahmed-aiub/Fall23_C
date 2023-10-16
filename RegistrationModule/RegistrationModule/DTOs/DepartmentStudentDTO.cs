using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationModule.DTOs
{
    public class DepartmentStudentDTO : DepartmentDTO
    {
        public List<StudentDTO> Students { get; set; }
    }
}