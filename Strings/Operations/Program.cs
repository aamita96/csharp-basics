// See https://aka.ms/new-console-template for more information
using System;

namespace StringOperations {
    class Operations {
        static void Main(string[] args){
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string[] strs = {"one","two","three","four"};

            // TODO: length of a string
            Console.WriteLine(str1.Length);

            // TODO: Access individual characters
            Console.WriteLine(str1[14]);

            // TODO: Iterate over a string like any other sequence of values
            foreach (char ch in str1)
            {
                Console.Write(ch);
                if(ch == 'b'){
                    Console.WriteLine();
                    break;
                }
            }

            // TODO: String concatenation
            outstr = String.Concat(strs);
            Console.WriteLine(outstr);

            // TODO: Joining strings together with join
            outstr = String.Join("---",strs);
            Console.WriteLine(outstr);

            // TODO: String comparison
            /**
             * Compare will perfom an ordinal comparison and return:
             * < 0 : first string comes before second in sort order
             * 0 : first and second strings are same position in sort order
             * > 0 : first string comes after the second in sort order
            */
            int result = String.Compare(str2,"This is a string");

            // TODO: Equals just returns a regular Boolean
            bool isEqual = str2.Equals(str3);
            Console.WriteLine(isEqual);

            // TODO: String searching
            Console.WriteLine(str1.Contains("fox"));
            Console.WriteLine(str1.IndexOf("fox"));

            Console.WriteLine(str1.LastIndexOf("e"));
            Console.WriteLine(str1.LastIndexOf("fox"));

            outstr = str1.Replace("fox","cat");
            Console.WriteLine(outstr);
        }
    }
}
