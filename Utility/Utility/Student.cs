using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    class Student
    {
        int id;
        string name;
        int age;
        readonly int sl;
        const string Ins="AIUB";
        
        public float Cgpa { get;  }


        public int Id {
             set { id = value; }
             get { return id; }
        }
        internal Student() { 
            Cgpa = 0;
            sl = 32435;
        }
        

        
        
       
    }
}
