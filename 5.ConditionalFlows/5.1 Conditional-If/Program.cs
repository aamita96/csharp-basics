// See https://aka.ms/new-console-template for more information
using System;

namespace Conditionals {
    class Program {
        static void Main(string[] args){
            int theVal = 50;
            if(theVal == 50){
                Console.WriteLine("theVal is 50");
            } else if(theVal >= 51 && theVal <= 60){
                Console.WriteLine("theVal is something else!");
            } else {
                Console.WriteLine("theVal is something else!");
            }

            // TODO: Using the ternary operator ?:
            // If else can be replaced by ternary operator.
            
            Console.WriteLine(theVal < 50 ? "theVal is small":"theVal is large");
        }
    }
}
