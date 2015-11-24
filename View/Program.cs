using System;
using System.Drawing;
using System.Linq.Expressions;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCar = new Car("Лада", 'D')
            {
                Color = Color.BlueViolet
            };
            Console.WriteLine("Приобретена машина {0}, " +
                  "категории: {1}, цвет: {2}",
                  firstCar.Model, firstCar.Category, firstCar.Color);
            try
            {
                Console.WriteLine("Имя владельца: " + firstCar.CarPassport.Owner.Name);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка! У владельца отсутствует имя");
            }
            
            var firstDriver = new Driver(new DateTime(2014, 7, 15), "Вольдемар")
            {
                Category = new [] {'B', 'C'}
            };

            firstCar.ChangeOwner(firstDriver, "oo777o");
            firstDriver.Category = new [] {'B','C','D'};
            firstCar.ChangeOwner(firstDriver, "oo777o");
            Console.WriteLine("Номер машины: " + firstCar.CarNumber);
            Console.WriteLine("Имя водителя Лады: " + firstDriver.Name);
            Console.ReadKey();
        }
    }
}
