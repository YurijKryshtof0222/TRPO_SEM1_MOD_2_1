using System;
using System.Collections.Generic;
using System.Linq;


namespace TRPO_SEM1_MOD_2_1;

class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>
        {
            new Car("Toyota", "AA1111BB", 2020, 25000),
            new Car("BMW", "BC2222KM", 2021, 35000),
            new Car("Audi", "AX3333PP", 2019, 30000),
            new Car("Mercedes", "KA4444XX", 2022, 40000)
        };

        var numbers = cars.AsParallel()
                         .Select(car => car.Number);

        // Виводимо номери
        Console.WriteLine("Номери автомобiлiв:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}