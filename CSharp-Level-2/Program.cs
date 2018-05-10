using CSharp_Level_2.Subject.AbstractClass;
using CSharp_Level_2.Subject.ClassVsStruct;
using CSharp_Level_2.Subject.Delegate;
using CSharp_Level_2.Subject.Extension;
using CSharp_Level_2.Subject.GUID;
using CSharp_Level_2.Subject.Indexers;
using CSharp_Level_2.Subject.Interface;
using CSharp_Level_2.Subject.LINQ;
using CSharp_Level_2.Subject.Operators;
using CSharp_Level_2.Subject.StaticClass;
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

            string command = null;
            while (command != "END")
            {
                command = Console.ReadLine().ToUpper();
                switch (command)
                {
                    case "ABSTRACT":
                        new ExampleAbstractClass().Test();
                        break;
                    case "STRUCT":
                        new ExerciseStruct().Test();
                        break;
                    case "DELEGATE":
                        new ExerciseDelegate().Test();
                        break;                   
                    case "EXTENSION":
                        new ExerciseExtension().Test();
                        break;
                    case "GUID":
                        new ExerciseGuid().Test();
                        break;
                    case "INDEXERS":
                        new ExerciseIndexares().Test();
                        break;
                    case "INTERFACE":
                        new ExampeInterface().Test();
                        break;
                    case "LINQ":
                        new ExerciseLINQ().Test();
                        break;
                    case "OPERATORS":
                        new ExampleOperators().Test(Console.ReadLine());
                        break;
                    case "STATIC":
                        new ExampleStaticClass().Test();
                        break;
                    case "STREAM":
                        new ExerciseStream().Test();
                        break;
                }
            }

        }
    }
}
