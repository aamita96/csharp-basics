using System;

namespace Defining{
    // Classes have a name, unique wihtin the namespace
     class Program{
        static void Main(string[] args){
            // TODO: Create new object instances using the "new" Operator
            Book b1 = new Book("War and Peace","Leo",825);
            Book b2 = new Book("Harry Potter and Sorcers Stone","J.K. Rowling",500);

            // TODO: Call a method on the object
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());

            // TODO: try to set one of the properties ---
            // This will result in an error

            b1._name = "Aldous Huxely";
        }
    }
}