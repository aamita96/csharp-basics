using System;

namespace Properties{
    // Classes have a name, unique wihtin the namespace
    public class Book{
        // TODO: classes have instance variables to hold data
        private string _name;
        private string _author;
        private int _pagecount;

        // TODO: classes have one or more constructors
        public Book(string name,string author, int pagecount){
            _name = name;
            _author = author;
            _pagecount = pagecount;
        }
        
        // TODO: use Properties to implement access to our internal data
        // This is called a Property with a "backing field"
        public string Name {
            get{
                return _name;
            }
            set{
                _name = value;
            }
        }

        // TODO: There's a shorthand way of writing these using the => operator
        // to create "expression-bodied" properties

        public string Author {
            get=> _author ;
            set => _author = value;
        }

        public int PageCount {
            get => _pagecount;
            set => _pagecount = value;
        } 

        // TODO: You can omit the get or set if you want to prevent
        // modification or reading the value, or if you want to create
        // a "computed property" from other fields
        public string Description {
            get => $"{Name} by {Author}, {PageCount} pages.";
        }

        // TODO: Properties can be auto-generated - if there's no
        // backing field, the property can hold the data
        public string ISBN {
            get;set;
        }

        public decimal Price {
            get;set;
        }
    }
}