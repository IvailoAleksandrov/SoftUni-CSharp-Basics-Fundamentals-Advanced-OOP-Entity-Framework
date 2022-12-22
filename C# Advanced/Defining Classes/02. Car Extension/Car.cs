using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarManufacturer
{
    internal class Car
    {
        //----------------- FIELDS -----------------
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        //--------------- PROPERTIES ---------------
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public double FuelConsumption 
        {   get {return fuelConsumption; }
            set { fuelConsumption= value; } 
        }
        //---------------- METHODS -----------------
        public void Drive(double distance)
        {
            if (FuelQuantity - (distance/100*FuelConsumption) >=0)
            {
                FuelQuantity -= distance / 100 * FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Make: {Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.Append($"Fuel: {this.FuelQuantity:F2}L");
            return sb.ToString();

        }
    }
}
