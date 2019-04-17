using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenprogramm
{
    public enum GradeType { oral, exam, extra }

    public class Rating
    {
        protected GradeType Type;
        protected double Ratio;
        protected double Average;
        protected DateTime Time;
        protected string Name;
        protected string Description;

        public Rating(GradeType type, double ratio, double average, DateTime time, string name, string description)
        {
            Type = type;
            Ratio = ratio;
            Average = average;
            Time = time;
            Name = name;
            Description = description;
        }

        public GradeType GetType()
        {
            return Type;
        }
    }
}
