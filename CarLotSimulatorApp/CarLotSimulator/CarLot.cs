using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
        }

        public static int numberOfCars; 
        public List<Car>Cars = new List<Car>();

        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public bool IsOnSale { get; set; }


    }

   
}
