// See https://aka.ms/new-console-template for more information
using System;

namespace Operators {
    class Program {
        static void Main(string[] args){
            // Declare some basic value type variables
            int x = 10, y = 5;
            string a ="abcd", b ="efgh";

            // Basic Math Operators are +,-,/,*
            Console.WriteLine((x/y) * x);
            Console.WriteLine(a+b);


            // Increment/Decrement operators
            Console.WriteLine("-----Shorthand-----");
            x++;
            y--;
            Console.WriteLine(x);
            Console.WriteLine(y);

            // Shorthand assignment operators a = a+b;

            a+=b;
            Console.WriteLine(a);

            // Logical Operators &&, ||
            Console.WriteLine("----Logical Operators----");
            Console.WriteLine(x > y && y >= 5);
            Console.WriteLine(x > y || y >= 5);

            // null-coalescing operators
            string str = null;
            // TODO: the ?? operator uses left operand if not null, or right one if it is null.
            Console.WriteLine( str ?? "Unknown string!");

            // TODO: the ??= operator assigns the right operand if the left one is null
            /**
             * It replaces the code:
             * if (variable is null){
             *      variable = somevalue;
             * }
            */
            str ??= "New String";
            Console.WriteLine(str);
        }
    }
}
