using System;

namespace Inheritance
{
    class program
    {
        static void Main(){
            // TODO: Create new object instances using the "new" Operator
            Book b1 = new Book("War and Peace","Leo",825,39.5m);
            Magazine m1 = new Magazine("Time","Time USA",75,4.95m);

            // Access a couple of properties
            Console.WriteLine($"{b1.Name}, {b1.Author}");
            Console.WriteLine($"{m1.Name}, {m1.Publisher}");

            // Property validation logic will prevent an empty name
            // b1.Name = "";

            // Call the override method
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b1.Price);
            Console.WriteLine(m1.GetDescription());
            Console.WriteLine(m1.Price);
        }
    }
}