using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_2.Subject.Extension
{
    class ExerciseExtension
    {
        public void Test()
        {
            decimal i = 7;
            Console.WriteLine(i.Multiply(2));

        }
    }

    public static class IntExtension
    {
        public static decimal Multiply(this decimal d, int i)
        {
            return d * i;
        }       
    }
}
