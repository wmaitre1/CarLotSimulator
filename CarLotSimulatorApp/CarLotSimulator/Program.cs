using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car (Done)
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable (Done)
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() (Done)
            //The methods should take one string parameter: the respective noise property (Done)


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var myCar = new Car();

            myCar.Make = "Nissan";
            myCar.Model = "Quest";
            myCar.Year = "2022";
            myCar.Price = 30000;
            myCar.EngineNoise = "beep beep";
            myCar.HonkNoise = "honk honk";
            myCar.IsDriveable = true;

            

            Console.WriteLine($"My {myCar.Make} {myCar.Model} runs like a dream.  I am glad it is a {myCar.Year} and it only cost me {myCar.Price}. " +
                $"Is it driveable, my answer is {myCar.IsDriveable}");

            var car = new Car();

            car.Make = "Toyota";
            car.Model = "Camry";
            car.Year = "2021";
            car.Price = 27000;
            car.EngineNoise = "vroom";
            car.HonkNoise = "honk honk";
            car.IsDriveable = true;

           

            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine($" I drive a {car.Make} {car.Model} it runs really well.  " +
                $"For being a {car.Year} and only costing me {car.Price} I got a great deal." + $"the best thing, is it driveable {car.IsDriveable}");

            var hyundai = new Car();

            hyundai.Year = "2022";
            hyundai.Model = "Elantra";
            hyundai.Price = 25000;
            hyundai.EngineNoise = "beep beep";
            hyundai.HonkNoise = "honk";
            hyundai.IsDriveable = true;

           

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine($" My Hyundai {hyundai.Make} cost me {hyundai.Price} and {hyundai.IsDriveable} is it driveable, and it should be since it a {hyundai.Year}");

            //instance 2
            
            var ecoCar = new Car()
            {
                Year = "2023",
                Make = "Honda",
                Model = "Civic",
                Price = 25265,
                EngineNoise = "beep beep",
                HonkNoise = "hink honk",
                IsDriveable = true,
            };

            Console.WriteLine("-------------------------");

            //Instance 3
           
            var kaliCar = new Car("Hyundai", "Accent", 2023, "vroom", "honk honk", true);


            myCar.MakeEngineNoise(myCar.EngineNoise);
            myCar.MakeHonkNoise(myCar.HonkNoise);

            Console.WriteLine("-------------------------");

            car.MakeEngineNoise(car.EngineNoise);
            car.MakeHonkNoise(car.HonkNoise);

            Console.WriteLine("-------------------------");


            hyundai.MakeEngineNoise(hyundai.EngineNoise);
            hyundai.MakeHonkNoise(hyundai.HonkNoise);

            Console.WriteLine($"Number of cars created : {CarLot.numberOfCars}");


            Console.ReadLine();





            

           


            



        }
    }
}
