using System;
using System.Collections.Generic;
using System.Text;

namespace PandemicSimulator
{
    public class Virus
    {
        // Attributes
        private string name;
        private double transmissionRate; // 0d to 1d
        // 0: no transmission at all - 1: always attempts to transmit
        private int infectionRange; // number of people that the holder can infect at the same spot
        private int lifetime; // in units of time

        // Methods
        // - constructor
        public Virus(string name, double transmissionRate, int infectionRange,
            int maxLifetime)
        {
            this.name = name;
            this.transmissionRate = transmissionRate;
            this.infectionRange = infectionRange;
            lifetime = new Random().Next(maxLifetime + 1); // entre 0 et maxLifetime (inclus) marche seulement si maxLifetime > 0
        }

        // - getters and setters
        public double GetTransmissionRate()
        {
            return transmissionRate;
        }

        public int GetInfectionRange()
        {
            return infectionRange;
        }

        public int GetLifetime()
        {
            return lifetime;
        }

        public void SetLifetime(int value)
        {
            lifetime = value;
        }
    }
}
