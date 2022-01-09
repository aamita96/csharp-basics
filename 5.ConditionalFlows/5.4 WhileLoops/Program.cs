// See https://aka.ms/new-console-template for more information
using System;

namespace Conditionals {
    class ConditionalSwitch {
        static void Main(string[] args){
            
            string inputStr = "";
            
            // TODO: basic while loop executes while the gate condition is true
            
            // Console.WriteLine("The basic while loop.");
            // while (inputStr != "exit")
            // {
            //      inputStr = Console.ReadLine();
            //      Console.WriteLine("You entered: {0}",inputStr);
            // }

            // TODO: the do-while loop always executes at least one time
            Console.WriteLine("The do-while() loop!");

            do
            {
                 inputStr = Console.ReadLine();
                 Console.WriteLine("You entered: {0}",inputStr);
            } while (inputStr != "exit");
        }
    }
}
