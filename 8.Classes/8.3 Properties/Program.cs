using System;

namespace Properties{
    // Classes have a name, unique wihtin the namespace
     class Program{
        static void Main(string[] args){
            // TODO: Create new object instances using the "new" Operator
            Book b1 = new Book("War and Peace","Leo",825);
            Book b2 = new Book("Harry Potter and Sorcers Stone","J.K. Rowling",500);

            // Access a couple of properties
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Description);

            // Set the ISBN and Price properties
            b1.ISBN = "1001567890031";
            b1.Price = 24.95m;
            Console.WriteLine(b1.ISBN);
            Console.WriteLine(b1.Price);

            // Change the Name and PageCount
            b1.Name = "Crime and Punishment";
            b1.PageCount = 652;
            Console.WriteLine(b1.Description);
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.PageCount);
        }
    }
}