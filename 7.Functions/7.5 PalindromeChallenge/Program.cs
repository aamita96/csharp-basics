// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace FunctionsTuts {
    class PalindromeChallenge {
        static void Main(string[] args){
            string inputStr;
            Console.WriteLine("Let's Begin:");
            while (true)
            {
                inputStr = Console.ReadLine();
                if(inputStr == "exit") break;
                (bool,int) result = isPalindrome(inputStr);
                Console.WriteLine($"Palindrome: {result.Item1}, Length: {result.Item2}");
            }
        }
        static (bool,int) isPalindrome(string str){
            string testStr = str.ToUpper();

            StringBuilder sb = new StringBuilder();
            foreach(char ch in testStr){
                if(!char.IsPunctuation(ch) && !char.IsWhiteSpace(ch)){
                    sb.Append(ch);
                }
            }
            
            // Convert the builder to the finished string
            testStr = sb.ToString();

            // Compare characters starting at beignning and end of string
            int i=0, j=testStr.Length -1;
            while (i<j)
            {
                 if(testStr[i] != testStr[j])
                 return (false,0);

                 i++;
                 j--;
            }
            return (true,str.Length);
        }
    }
}
