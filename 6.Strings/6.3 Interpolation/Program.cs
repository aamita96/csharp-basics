// See https://aka.ms/new-console-template for more information
using System;

namespace StringInterpolation {
    class Interpolation {
        static void Main(string[] args){
        
        string make = "Mercedex-Benz";
        string model = "G Class";
        int year = 2020;
        float miles = 8_450.27f;
        decimal price = 60_275.0m;

        // TODO: Output information using formating
        Console.WriteLine("This car is a {0} {1} {2}, with {3} miles and costs ${4}", year,make, model,miles,price);

        // TODO: Using string interpolation
        Console.WriteLine($"This car is a {year} {make} {model}, with {miles} miles and costs {price:C2}.");

        // TODO: With inline expression
        Console.WriteLine($"This car is a {year} {make} {model}, with {miles * 1.6:F2} km and costs {price:C2}.");
        }
    }
}
