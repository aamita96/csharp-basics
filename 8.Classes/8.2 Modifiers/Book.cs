using System;

namespace Modifiers{
    // access modifiers controls how properties and methods are accessed
    class Book{
        // TODO: "public" members and methods can be accessed by any other
        // Note: this is *NOT* the right way to expose internal data
        public string _name;

        // TODO: "protected" members can only be accessed by the class or a
        // derived class from this one
        protected string _author;

        // TODO: "private" is the default and can only be accessed by code
        // within the class itself
        private int _pagecount;

        // TODO: classes have one or more constructors
        public Book(string name,string author, int pagecount){
            _name = name;
            _author = author;
            _pagecount = pagecount;
        }
        // TODO: methods are used to operate on the class and data
        public string GetDescription(){
            return $"{_name} by {_author}";
        }

        // TODO: Member variables can be accessed via methods
        public string GetName(){
            return _name;
        }
        public void SetName(string s){
            _name = s;
        }

        public void SetAuthor(string s){
            _author = s;
        }
        public void SetPagecount(int c){
            _pagecount = c;
        }
    }
}