using System;

namespace Inheritance{
    // Classes have a name, unique wihtin the namespace
    // TODO: Declare "Book" as a subclass of Publication
    class Book: Publication{
        // TODO: classes have instance variables to hold data
        private string _author;

        // TODO: use the base() keyword to initialize the base class
        public Book(string name,string author, int pagecount, decimal price):
        base(name,pagecount,price){
            _author = author;
        }
    
        // TODO: There's a shorthand way of writing these using the => operator
        // to create "expression-bodied" properties

        public string Author {
            get=> _author ;
            set => _author = value;
        }

        // TODO: use the override keyword to override a base class method
        public override string GetDescription(){
            return $"{Name} by {Author}, {PageCount} pages";
        }
    }
}