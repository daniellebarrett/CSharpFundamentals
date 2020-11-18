using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookie
    {       //properties generic to all cookies
        //all properties are pascal cased
        public string Name { get; set; }
        public bool HasNuts { get; set; }
        public double GramsOfFlour { get; set; }

        public Cookie()
        {
            //overloaded constructors lets you create new objects
            //with new properties IF YOU NEED to
        }

        public Cookie(string name, bool hasNuts, double gramsOfFlour)
        {
            Name = name;
            HasNuts = hasNuts;
            GramsOfFlour = gramsOfFlour;
        }
    }

    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat }
    //enums you get to create a brand new type and give it all of its values
    //see line 24
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle()
        {

        }

        public class Order
        {
            public string CustomerName { get; set; }
            public Cookie OrderedProduct { get; set; }
            public decimal TotalCost { get; set; }
        }

    }
}

    
