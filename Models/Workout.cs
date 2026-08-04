using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectIRON.Models
{
    internal class Workout
    {
        public string Exercise { get; set; } = string.Empty;

        public int Sets { get; set; }

        public int Reps { get; set; }

        public double Weight { get; set; }

        public string WeightUnit { get; set; } = string.Empty;

        public DateTime Date { get; set; }
    }
}