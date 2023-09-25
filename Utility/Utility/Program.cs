using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    internal class Program
    {
        static void Sum(out int result,params int[] nums) { 
            int sum = 0;
            foreach (var x in nums) {
                sum += x;
            }
            result = sum;
            
        }
        
        static void Main(string[] args)
        {

            int result;
            //Console.WriteLine(result);
            Sum(out result, 12, 23);
            Console.WriteLine(result);
            
            

            Student student = new Student();
            student.Id = 1;
            
            Console.WriteLine(student.Cgpa);
        }
    }
}
