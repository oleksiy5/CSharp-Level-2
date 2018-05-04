using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_2.Subject.Interface
{
    class ExampeInterface
    {
        public void Test()
        {
            var list = new List<IDevice>();
            list.Add(new SmartTV());
            list.Add(new Ipad());
            list.Add(new Tablet());

            foreach (IDevice o in list)
            {
                Console.WriteLine(o.GetName());
            }
        }

    }

    interface IDevice
    {
        string GetName();
    }

    class SmartTV: IDevice
    {
        public string GetName()
        {
            return "TV";
        }
    }
    class Ipad : IDevice
    {
        public string GetName()
        {
            return "Ipad";
        }
    }
    class Tablet : IDevice
    {
        public string GetName()
        {
            return "Tablet";
        }
    }

}
