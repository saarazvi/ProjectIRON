using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectIRON
{
    internal class Workout
    {
        public string Exercise { get; set; }

        public int Sets { get; set; }

        public int Reps { get; set; }

        public double Weight { get; set; }

        public DateTime Date { get; set; }
    }
}