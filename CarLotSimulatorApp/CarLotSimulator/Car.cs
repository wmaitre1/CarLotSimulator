using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
 //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }

        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable)
        {
            Make = make;
            Model = model;
            Year = Year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
          
            
        }
            public string Make { get; set; }
            public string Model { get; set; }  
            public string Year { get; set; }
            public string EngineNoise { get; set; }
            public string HonkNoise { get; set; }
            public bool IsDriveable { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }

        
    }
}
