using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_2.Subject.AbstractClass
{
    class ExampleAbstractClass
    {
        public void Test()
        {
            MobilePhone mobile = new MobilePhone();
        }
    }

    abstract class Device
    {
        public abstract string GetNameDevice();

    }

    class MobilePhone : Device
    {
        public override string GetNameDevice()
        {
            return "Mobile Phone";
        }
    }

    class SmartTV : Device
    {
        public override string GetNameDevice()
        {
            return "Smart TV";
        }
    }
}
