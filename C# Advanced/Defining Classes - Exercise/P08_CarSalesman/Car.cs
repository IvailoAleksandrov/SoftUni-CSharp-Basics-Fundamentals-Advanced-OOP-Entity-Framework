using System;
using System.Collections.Generic;
using System.Text;

namespace P08_CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = 0;
            Color = "n/a";
        }
        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            Weight = weight;
        }
        public Car(string model, Engine engine, int weight, string color) : this(model, engine, weight)
        {
            Color = color;
        }
        public Car(string model, Engine engine,string color) : this(model, engine)
        {
            Color= color;
        }
        public Car(string model, Engine engine, string color, int weight) : this(model, engine, color)
        {
            Weight = weight;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Model}:").AppendLine();
            sb.Append($"  {Engine.Model}:").AppendLine();
            sb.Append($"    Power: {Engine.Power}").AppendLine();
            sb.Append(Engine.Displacement == 0 ? $"    Displacement: n/a" : $"    Displacement: {Engine.Displacement}").AppendLine();
            sb.Append($"    Efficiency: {Engine.Efficiency}").AppendLine();
            sb.Append(Weight == 0 ? $"  Weight: n/a" : $"  Weight: {Weight}").AppendLine();
            sb.Append($"  Color: {Color}");

            return $"{sb}";
        }
    }
}
