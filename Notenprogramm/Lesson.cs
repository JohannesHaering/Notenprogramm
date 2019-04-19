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
        public ViewHolderLesson ViewHolderLesson { get; private set; }

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

        public void CreateViewHolder(Handler handler)
        {
            ViewHolderLesson = new ViewHolderLesson(handler);
        }

        public StackPanel ShowOrganisation()
        {
            return ViewHolderLesson.ShowOrganisation();
        }

        public StackPanel ShowDetailed()
        {
            return ViewHolderLesson.ShowDetailed();
        }
    }

    public class ViewHolderLesson
    {
        private Handler Handler;
        public StackPanel StackPanelOrganisation { get; private set; }
        public StackPanel StackPanelDetailed { get; private set; }
        

        public ViewHolderLesson(Handler handler)
        {
            Handler = handler;
        }

        public StackPanel ShowOrganisation()
        {
            if (StackPanelOrganisation == null)
            {
                StackPanelOrganisation = StackpanelBuilder.BuildStackpanelLesson(Handler.Lesson, Handler);
            }

            return StackPanelOrganisation;
        }

        public StackPanel ShowDetailed()
        {
            if (StackPanelDetailed == null)
            {
                // TODO: Missing Implementation of the detailed show builder
            }

            return StackPanelDetailed;
        }
    }
}
