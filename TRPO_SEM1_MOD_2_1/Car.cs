using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_SEM1_MOD_2_1;

public class Car
{
    public string Brand { get; set; }
    public string Number { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }

    // Конструктор за замовчуванням
    public Car()
    {
    }

    // Конструктор з параметрами
    public Car(string brand, string number, int year, decimal price)
    {
        Brand = brand;
        Number = number;
        Year = year;
        Price = price;
    }
}
