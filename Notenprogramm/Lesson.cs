using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Notenprogramm
{
    public class Lesson
    {
        public string ClassName { get; set; }
        public int StudentsNumber { get; set; }
        public double OralRatio { get; set; }
        public double ExamRatio { get; set; }
        public List<TStudent> Students { get; set; }
        public StackPanel Stackpanel { get; set; }

        public Lesson(string className, int studentsNumber, int oralRatio, int examRatio, StackPanel stackpanel)
        {
            Students = new List<TStudent>();

            ClassName = className;
            StudentsNumber = studentsNumber;
            OralRatio = oralRatio;
            ExamRatio = examRatio;

            for (int i = 0; i < StudentsNumber; i++)
            {
            }
        }

        public void Show()
        {

        }
    }
}
