﻿using System.Collections.Generic;

namespace _01.Raw_Data
{
    public class Car
    {
        private readonly List<Tire> tires;
        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.tires = tires;


        }

        public string Model { get; }
        public Engine Engine { get; }
        public Cargo Cargo { get; }
        public IReadOnlyCollection<Tire> Tires
        {
            get
            {
                return this.tires;
            }
        }

    }
}
