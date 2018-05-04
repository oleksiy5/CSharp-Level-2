using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_2.Subject.ClassVsStruct
{
    class ExerciseStruct
    {
        public void Test()
        {
            MinPrice minPrice = new MinPrice();
            MaxPrice maxPrice = new MaxPrice();
            minPrice.Value = 100;
            maxPrice.Value = 200;
            AddPrice(minPrice, maxPrice);

            Console.WriteLine($"min {minPrice.Value} " +
                $"max {maxPrice.Value}");
            Console.ReadKey();
        }

        static void AddPrice(MinPrice min, MaxPrice max)
        {
            min.Value++;
            max.Value++;
        }
    }

    class MinPrice
    {
        public double Value { get; set; }
    }

    struct MaxPrice
    {
        public double Value { get; set; }
    }

}
