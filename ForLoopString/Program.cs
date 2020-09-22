using System;
using System.Runtime.ExceptionServices;

namespace ForLoopString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Harry";
            name.Length
            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{i}.{name[i]}");
            } 
        }
    }
}
