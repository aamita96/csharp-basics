// See https://aka.ms/new-console-template for more information
using System;

namespace Conditionals {
    class ConditionalSwitch {
        static void Main(string[] args){
            
            int[] nums = new int[]{3,14,5,6,7,8,10};
            string str = "The quick brown fox jumps over the lazy dog!";
            
            // TODO: basic for loop
            // Console.WriteLine("The basic for loop.");

            // for(int i =0; i< nums.Length;i++){
            //     Console.WriteLine("i is currently {0}",nums[i]);
            // } 

            // TODO: the foreach-in loop can be used to iterate over sequences
            Console.WriteLine("The Foreach loop");
            foreach (char item in str)
            {
                Console.Write(item);
            } 
            Console.WriteLine();
        }
    }
}
