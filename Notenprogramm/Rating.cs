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
        protected GradeType type;
        protected double ratio;
        protected double average;
        protected DateTime time;
        protected string name;
        protected string description;

        public Rating(GradeType type, double ratio, double average, DateTime time, string name, string description)
        {
            this.type = type;
            this.ratio = ratio;
            this.average = average;
            this.time = time;
            this.name = name;
            this.description = description;
        }

        public GradeType getType()
        {
            return type;
        }
    }
}
