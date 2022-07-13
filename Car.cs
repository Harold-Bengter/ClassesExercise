using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise;

internal class Car
{
    public string Make{ get; set; } 
    public string Model { get; set; }
    public int Year { get; set; }





    public void PrintCarInfo()
    {
        Console.WriteLine("Car Info: ");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine("This car is sweet!");


    }
}
