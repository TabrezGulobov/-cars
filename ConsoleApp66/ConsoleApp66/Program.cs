using System;

namespace ConsoleApp66

{
    class cars
    {
        protected string model;
        protected string color;
        private int speed;
        private int year;
        public double Volume;
        public string country;
        public string CarModel
        {
            get { return model; }
            set { model = value; }
        }
        
        public string CarColor
        {
            get { return color; }
            set { color = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Year
        {
            get { return year;}
            set{ year = value; }
        }
    }

    class Mercedes:cars
    {
        public Mercedes()
        {
            color = "Black";
            Speed = 260;
            Volume = 5.5;
            country = "Germany";
        }

        public Mercedes(int year, string model)
        {
            Year = year;
            CarModel = model;
        }
    }

    class BMW:cars
    {
        public BMW()
        {
            model = "BMW M5 CS";
            color = "Green";
            country = "Germany";
        }

        public BMW(int year,int speed,double volume)
        {
            Year = year;
            Speed = speed;
            Volume = volume;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes m = new Mercedes();
            Mercedes m2 = new Mercedes(2021, "Mercedes-Benz S550");
            BMW bmw = new BMW();
            BMW bmw2 = new BMW(2020, 390, 5.5);
            Console.WriteLine(m2.CarModel);
            Console.WriteLine(m.CarColor);
            Console.WriteLine(m2.Year);
            Console.WriteLine(m.Speed);
            Console.WriteLine(m.Volume);
            Console.WriteLine(bmw.CarModel);
            Console.WriteLine(bmw.CarColor);
            Console.WriteLine(bmw2.Year);
            Console.WriteLine(bmw2.Speed);
            Console.WriteLine(bmw2.Volume);
        }
    }
}