using System;

namespace HW
{
    class Program
    {

        class Transport
        {
            public string Name { get; set; }
            public int Year { get; set; } 
            public string Color { get; set; }
            public string Manufacturer { get; set; }
            public int  Speed { get; set; }

        }
        class Auto : Transport
        {
            public string TransmissionType { get; set; }
            public int Horsepower { get; set; }
        }
        class Car : Auto
        {
            public string Model { get; set; }
           // create constructor
            //public Car()
            //{

            //}
            //public Car(string model )
            //{
            //    Model = model;
            // }
            public void ShowinfoCar()
            {
                Console.WriteLine($"Имя Машины:{Name},Год выпуска:{Year}, Цвет:{Color}, Производитель:{Manufacturer}, Скорость:{Speed}, Коробка передач:{TransmissionType} , Лошадинная сила:{Horsepower}, Модель:{Model}\n");
            }
        }
        class Truck : Auto
        {
            public string Model { get; set; }

            public int Tonnage { get; set; }

            public void ShowinfoTruck()
            {               
                Console.WriteLine($" Имя Машины:{Name}\n Год выпуска:{Year}\n Цвет:{Color}\n Производитель:{Manufacturer}\n Скорость:{Speed}\n Коробка передач:{TransmissionType}\n Лошадинная сила:{Horsepower}\n Модель:{Model}\n Тонаж:{Tonnage}\n");
            }
        }
        class Airplane : Transport
        {
            public int RangeOfFlight { get; set; }
            public int Tonnage { get; set; }

        }

        class CargoPlane : Airplane                     //грузовой самолет
        {
            public string Model { get; set; }

            public CargoPlane()
            { }
            public CargoPlane(string model)
            {
                Model = model;
            }

            public void ShowinfoAirplane()
            {
                Console.WriteLine($" Имя Машины:{Name}\n Год выпуска:{Year}\n Цвет:{Color}\n Производитель:{Manufacturer}\n Скорость:{Speed}\n Дальность полета:{RangeOfFlight}\n Тонаж:{Tonnage}\n Модель:{Model}\n");
            }

        }
        class PassengerAirplane : Airplane              //Пассажирский Самолет 
        {
            public string Model { get; set; }

            public int Seats { get; set; }            //посадочные места

            public PassengerAirplane()
            { }
            public PassengerAirplane(string model, int seats)
            {
                Model = model;
                Seats = seats;
            }
            public void ShowinfoPassengerAirplane()
            {
                Console.WriteLine($" Имя Машины:{Name}\n Год выпуска:{Year}\n Цвет:{Color}\n Производитель:{Manufacturer}\n Скорость:{Speed}\n Дальность полета:{RangeOfFlight}\n Тонаж:{Tonnage}\n Модель:{Model}\n посадочные места:{Seats}\n");
            }

        }          
        class Train : Transport
            {
            public int Seats { get; set; }            //посадочные места

            public int Tonnage { get; set; }
            public Train()
            { }
            public Train(int seats, int tonnage)
            {
                Seats = seats;
                Tonnage = tonnage;
            }

            public void ShowInfoTrain()
            {
                Console.WriteLine($" Имя Машины:{Name}\n Год выпуска:{Year}\n Цвет:{Color}\n Производитель:{Manufacturer}\n Скорость:{Speed}\n Тонаж:{Tonnage}\n посадочные места:{Seats}\n");
            }
        }
        static void Main(string[] args)
        {
            // --------------------------------car-------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info about car");
            Console.ResetColor();
            Car car = new Car();
            car.Name = "Sport Car";
            car.Year = 2020;
            car.Color = "Green";
            car.Manufacturer = "Mers corporation";
            car.Speed = 380;
            car.TransmissionType = "mehanic";
            car.Horsepower = 560;
            car.Model = "Gl550";
            car.ShowinfoCar();

            // --------------------------------truck-----------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info about truck");
            Console.ResetColor();
            Truck truck = new Truck();
            truck.Name = "Sport Car";
            truck.Year = 2020;
            truck.Color = "Green";
            truck.Manufacturer = "Mers corporation";
            truck.Speed = 380;
            truck.TransmissionType = "mehanic";
            truck.Horsepower = 560;
            truck.Model = "Gl550";
            truck.Tonnage = 35000;
            truck.ShowinfoTruck();

            // --------------------------------Cargoplane------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info about Cargoplane");
            Console.ResetColor();
            CargoPlane air = new CargoPlane("ModelCargoPlane") { Name="Cargoplane",Year=2018,Color="Yellow",Manufacturer="Airobus",Speed=4500,RangeOfFlight=15000,Tonnage=60000};
            air.ShowinfoAirplane();

            //------------------------------ PassAirplane-------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("info About PassengerAirplane");
            Console.ResetColor();
            PassengerAirplane passenger = new PassengerAirplane("model is X25", 650) { Name = "PassAirplane", Year = 2015, Color = "blue", Manufacturer = "Airobus", Speed = 5500, RangeOfFlight = 30000, Tonnage = 30000};
            passenger.ShowinfoPassengerAirplane();

            //------------------------Train-----------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info about train");
            Console.ResetColor();
            Train train = new (2500, 60000) { Name = "Train", Year = 2013, Color = "red", Manufacturer = "TrainCorp", Speed = 450 };
            train.ShowInfoTrain();


        }



    }
}

