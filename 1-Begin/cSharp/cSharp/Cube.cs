﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }

        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetHashCode();
            Console.WriteLine($"The cube has a length {Length}");

        }
    }
}
