using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_2.Subject.GUID
{
    class ExerciseGuid
    {
        void Test()
        {
            Guid guid1 = Guid.NewGuid();
            byte[] buff = guid1.ToByteArray();

            Guid guid2 = new Guid(buff);
        }
    }
}
