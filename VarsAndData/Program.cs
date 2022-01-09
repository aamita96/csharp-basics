// See https://aka.ms/new-console-template for more information
using System;

namespace VarsAndData {
    class Program {
        static void Main(string[] args){
            // Declare some basic value type variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            // Declare a string - Its collection of characters
            string str = "It's a string";

            // Declare a implicit variable
            var x = 10;
            var z = "Hello";

            // Declare an  array of values
            int [] vals = new int[5];
            string[] strs = {"One","Two","Three"};

            // Print Values using a Formatting String
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",i,f,d,b,c,str,x,z);

            // "null" means No Value
            object obj = null;
            Console.WriteLine(obj);

            // Implicit conversion between types
            long bigNum;
            bigNum = i;
            
            // Explicit conversion
            float i_To_f = (float)i;
            Console.WriteLine("{0}",i_To_f);

            int f_To_i = (int)f;
            Console.WriteLine("{0}",f_To_i);
        }
    }
}
