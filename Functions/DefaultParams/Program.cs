// See https://aka.ms/new-console-template for more information


// TODO: Functions can provide default values for their parameters

void PrintWithPrefix(string theStr, string prefix=""){
    Console.WriteLine($"{prefix} {theStr}");
}


// Test the default Parameters
PrintWithPrefix("Hello World!");
PrintWithPrefix("Hello World!", "**");

// TODO: Call with named params
PrintWithPrefix(prefix:"%",theStr:"Hello World!");