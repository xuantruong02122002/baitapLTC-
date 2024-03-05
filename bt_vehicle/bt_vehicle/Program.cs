using System;
using System.Collections.Generic;
using System.Linq;

namespace bt_vehicle
{
    public class Vehicle
    {
        public String ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Manufacturer { get; set; }
        public int YearOfManufacture { get; set; }
        public string OwnerCompany { get; set; }
    }
    class Car: Vehicle { }
    class Truck : Vehicle
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
                List<Car> car = new List<Car>
            {
                new Car { ID = "Car001", Name = "Honda", Color = " red ",Price=250000,Manufacturer = "Soichiro Honda",YearOfManufacture=1946 ,OwnerCompany="TNHH Takeo Fujisawa"  },
                new Car { ID = "Car002", Name = "Honda", Color = " blue  ",Price=350000,Manufacturer = "Carry Van Toyota",YearOfManufacture=1935 ,OwnerCompany="TNHH General Motors"  },
                new Car { ID = "Car003", Name = "Ford", Color = " green ",Price=290000,Manufacturer = "ES Ford",YearOfManufacture= 2010 ,OwnerCompany=" TNHH Mitsubishi Motor"  },
                new Car { ID = "Car004", Name = "ford", Color = " yellow ",Price=120000,Manufacturer = "MTP BMW",YearOfManufacture=1999 ,OwnerCompany="Daehan Motors."  },
                new Car { ID = "Car005", Name = "Hyundai", Color = " white ",Price=200000,Manufacturer = "KCm Hyundai",YearOfManufacture=1970 ,OwnerCompany="T General Motors Corporation"  },
                new Car { ID = "Car006", Name = "Isuzu", Color = " black ",Price=150000,Manufacturer = "Unichiwa Isuzu",YearOfManufacture=1923 ,OwnerCompany="TNHH oto Isuzu"  },
            };
            //2a Hiển thị các xe có giá trong khoảng 100.000 đến 250.000 
            var filteredCars = car.Where(car => car.Price >= 100000 && car.Price <= 250000);
            Console.WriteLine("2a) Xe co gia trong khoang 100000 den 250000 la:");
            foreach (var Car in filteredCars)
            {
                Console.WriteLine($"Name :{Car.Name},Price :{Car.Price}");
            }
            //2b các xe có năm sản xuất > 1990.
            var filteredCar = car.Where(car=>car.YearOfManufacture > 1990);
            Console.WriteLine("2b) xe co nam san suat > 1990:");
            foreach (var Car in filteredCar)
            {
                Console.WriteLine($"Name :{Car.Name},YearOfManufacture :{Car.YearOfManufacture}");
            }
            //2c Gom các xe theo hãng sản xuất và tính tổng giá trị theo nhóm
            var groupedCars = car.GroupBy(car => car.Name).Select(group =>
                new
                {
                    Name = group.Key,
                    TotalPrice = group.Sum(car => car.Price)
                });
            Console.WriteLine("\n2c) Tong gia tri theo hang:");
            foreach (var group in groupedCars)
            {
                Console.WriteLine($"{group.Name}: {group.TotalPrice}");
            }

            List<Truck> truck = new List<Truck>
            {
                new Truck { ID = "Car001", Name = "Honda", Color = " red ",Price=250000,Manufacturer = "Soichiro Honda",YearOfManufacture=1946 ,OwnerCompany="TNHH Takeo Fujisawa"  },
                new Truck { ID = "Car002", Name = "Honda", Color = " blue  ",Price=350000,Manufacturer = "Carry Van Toyota",YearOfManufacture=1935 ,OwnerCompany="TNHH General Motors"  },
                new Truck { ID = "Car003", Name = "Ford", Color = " green ",Price=290000,Manufacturer = "ES Ford",YearOfManufacture= 2010 ,OwnerCompany=" TNHH Mitsubishi Motor"  },
                new Truck { ID = "Car004", Name = "ford", Color = " yellow ",Price=120000,Manufacturer = "MTP BMW",YearOfManufacture=1999 ,OwnerCompany="Daehan Motors."  },
                new Truck { ID = "Car005", Name = "Hyundai", Color = " white ",Price=200000,Manufacturer = "KCm Hyundai",YearOfManufacture=1970 ,OwnerCompany="T General Motors Corporation"  },
                new Truck { ID = "Car006", Name = "Isuzu", Color = " black ",Price=150000,Manufacturer = "Unichiwa Isuzu",YearOfManufacture=1923 ,OwnerCompany="TNHH oto Isuzu"  },
            };
            //3a  Hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất
            var sortedTrucks = truck.OrderByDescending(truck => truck.YearOfManufacture);
            Console.WriteLine("\n3a) danh sach truck theo thu tu nam moi nhat la :");
            foreach (var Truck in sortedTrucks)
            {
                Console.WriteLine($"Name: {Truck.Name}, Nam: {Truck.YearOfManufacture}, Gia: {Truck.Price}");
            }
            //3b Hiển thị tên công ty chủ quản của Truck
            Console.WriteLine("\n3b) ten cong ty chu quan cua truck la :");
            foreach (var Truck in truck)
            {
                Console.WriteLine($"{Truck.Name}: {Truck.OwnerCompany}");
            }

        }
    }
}
