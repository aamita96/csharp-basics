// See https://aka.ms/new-console-template for more information
using System;

namespace Conditionals {
    class ConditionalSwitch {
        static void Main(string[] args){
            int theVal = 50;

            // Switch statement to handle number;
            switch (theVal)
            {
                case 50 : 
                    Console.WriteLine("theVal is 50");
                    break;
                case 51:
                    Console.WriteLine("theVal is 51");
                    break;
                case 52:
                case 53:
                case 54:
                    Console.WriteLine("theVal is between 52 to 54!");
                    break;
                default:
                    Console.WriteLine("theVal is something else!");
                    break;
            }
        }
    }
}
