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
        public StackPanel StackPanelOrganisation { get; set; }
        public StackPanel StackPanelDetailed { get; set; }

        public Lesson()
        {

        }

        public Lesson(string className, int studentsNumber, int oralRatio, int examRatio)
        {
            Students = new List<TStudent>();

            ClassName = className;
            StudentsNumber = studentsNumber;
            OralRatio = oralRatio;
            ExamRatio = examRatio;
        }

        public StackPanel ShowOrganisation(Handler handler)
        {
            if(StackPanelOrganisation == null)
            {
                StackPanelOrganisation = StackpanelBuilder.BuildStackpanelLesson(this, handler);
            }

            return StackPanelOrganisation;
        }

        public StackPanel ShowDetailed()
        {
            if(StackPanelDetailed == null)
            {
                // TODO: Missing Implementation of the detailed show builder
            }

            return StackPanelDetailed;
        }
    }
}
