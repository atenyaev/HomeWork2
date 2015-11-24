using System;
using System.Linq;

namespace Model
{
    public class Driver
    {
        public Driver(DateTime licenceDate, string name)
        {
            LicenceDate = licenceDate;
            Name = name;
        }

        public DateTime LicenceDate { get; }
        public string Name { get; }
        public char[] Category { get; set; }
        public Car Car { get; private set; }
        public void OwnCar(Car car)
        {
            if(!Category.Contains(car.Category))
                throw(new Exception("Нет категории"));
            Car = car;
        }

        public int Experience => DateTime.Now.Year - LicenceDate.Year;
    }
}