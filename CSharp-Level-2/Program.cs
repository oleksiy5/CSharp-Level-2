using CSharp_Level_2.Subject.ClassVsStruct;
using CSharp_Level_2.Subject.Delegate;
using CSharp_Level_2.Subject.Extension;
using CSharp_Level_2.Subject.Indexers;
using CSharp_Level_2.Subject.Interface;
using CSharp_Level_2.Subject.Operators;
using CSharp_Level_2.Subject.Stream;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_2
{
    class Program   
    {

        static void Main(string[] args)
        {
            var random = new Random();
            var numbers = new List<int>();
            for (; ; )
            {
                numbers.Add(random.Next(0, 100));
                if (numbers.Count == 10)
                    break;
            }

            int allSum = numbers.Sum();
            int evenSum = numbers.Where(n => n % 2 == 0).Sum();
            int noEvenSum = numbers.Where(n => n % 2 != 0).Sum();

            Console.WriteLine(allSum);
            Console.WriteLine(evenSum);
            Console.WriteLine(noEvenSum);
        }
    }
}
