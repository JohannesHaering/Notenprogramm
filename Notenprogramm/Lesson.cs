using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenprogramm
{
    public class TLesson
    {
        public string className;
        public int studentsNumber;
        public double oralRatio;
        public double examRatio;
        public List<TStudent> students = new List<TStudent>();

        public TLesson(string _className, int _studentsNumber, int _oralRatio, int _examRatio)
        {
            className = _className;
            studentsNumber = _studentsNumber;
            oralRatio = _oralRatio;
            examRatio = _examRatio;

            for(int i = 0; i < studentsNumber; i++)
            {
            }
        }
    }
}
