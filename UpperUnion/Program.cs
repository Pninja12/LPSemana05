using System;
using System.Collections.Generic;

namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {

            if(args.Length <= 0)
            {
                Console.WriteLine("NO ARGUMENTS");   
            }
            else
            {

                for (int i = 0; i < args.Length; i++)
                {
                    Console.Write(args[i]);
                    Console.Write("-");
                }
            } 
        }
    }
}
