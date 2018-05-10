using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSharp_Level_2.Subject.Stream
{
    class ExerciseStream
    {
        public void Test()
        {
            byte[] buff = null;
            using (FileStream fs = new FileStream(
                @"C:\my_file\olo.txt", FileMode.Open, FileAccess.Read))
            {
                int length = (int)fs.Length; 
                buff = new byte[length];     
                int count;                   
                int sum = 0;                 
                while ((count = fs.Read(buff, sum, length - sum)) > 0)
                    sum += count;  
            }

            MemoryStream ms = new MemoryStream();
            ms.Write(buff, 0, buff.Length);
            string result = Encoding.UTF8.GetString(ms.ToArray());
        }
    }
}
