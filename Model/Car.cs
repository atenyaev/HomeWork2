using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car
    {
        public Car(string model, char category)
        {
            Model = model;
            Category = category;
        }
        public string Model { get; }
        public Color Color { get; set; } = Color.Blue;
        public string CarNumber { get; private set; }
        public char Category { get; }
        public CarPassport CarPassport { get; }

        public void ChangeOwner(Driver driver, string carNumber)
        {
            try
            {
                CarPassport.Owner = driver;
            }
            catch(Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            CarNumber = carNumber;
        }
    }
}
