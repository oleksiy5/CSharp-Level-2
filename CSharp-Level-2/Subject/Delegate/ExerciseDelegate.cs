using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_2.Subject.Delegate
{
    class ExerciseDelegate
    {
        public delegate void DisplayText_Delegate();

        public void Test()
        {
            var displayTextDelegate = new DisplayText_Delegate(Text_1);
            displayTextDelegate += new DisplayText_Delegate(Text_2);
            displayTextDelegate += new DisplayText_Delegate(Text_3);

            displayTextDelegate();
        }

        private void Text_1()
        {
            Console.WriteLine("Text 1");
        }
        private void Text_2()
        {
            Console.WriteLine("Text 2");
        }
        private void Text_3()
        {
            Console.WriteLine("Text 3");
        }

    }
}
