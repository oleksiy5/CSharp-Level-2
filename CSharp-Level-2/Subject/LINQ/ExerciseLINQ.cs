using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_2.Subject.LINQ
{
    class ExerciseLINQ
    {
        public void Test()
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
