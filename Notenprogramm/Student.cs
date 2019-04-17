using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Notenprogramm
{
    public class TStudent
    {
        private string name = "";
        private Grade tempGrade;
        private Grade examGrade;
        private Grade oralGrade;
        private Grade extraGrade;
        private Grade endGrade;
        private Grade halfYearGrade;
        private List<Grade> grades;
        private List<TInformation> information = new List<TInformation>();

        private StackPanel stackPanelComplete;
        private StackPanel stackPanelExams;
        private StackPanel stackPanelOrals;
        private StackPanel stackPanelConclusion;

        public TStudent()
        {
            grades = new List<Grade>();  
        }

        public void addInformation(string informationString)
        {
            information.Add(new TInformation(informationString));
        }

        public StackPanel print()
        {
            return stackPanelComplete;
        }

        public void addGrade(Grade grade)
        {
            grades.Add(grade);

            if (grade.GetType().Equals(GradeType.exam))
            {
                examGrade.addGrade(grade);
            }
            if (grade.GetType().Equals(GradeType.oral))
            {
                oralGrade.addGrade(grade);
            }
            if (grade.GetType().Equals(GradeType.extra))
            {
                extraGrade.addGrade(grade);
            }


        }

    }
}
