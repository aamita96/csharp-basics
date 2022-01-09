using System;

namespace StringRep
{
    class program
    {
        static void Main(){
            // TODO: Every class in C# inherits from Object, which means
            // that every class inherits the ToString() method
            // int x = 1000;
            // Console.WriteLine(x.ToString());

            // TODO: if you don't override the method, the default behavior
            // the name of the class and the namespace
            // object a = new object();
            // Console.WriteLine(a.ToString());
        
            // TODO: use the ToString method on the Book class
            Book b1 = new Book("The jungle book","Rudyard Kipling",450);

            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1);

            Console.WriteLine(b1.ToString('B'));
            Console.WriteLine(b1.ToString('F'));
        }
    }
}