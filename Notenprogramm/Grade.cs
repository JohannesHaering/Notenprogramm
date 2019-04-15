using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Notenprogramm
{

    public class Grade : Rating
    {
        private List<Grade> Grades;
        private List<double> Bias;
        private double CalculatedGrade;

        private StackPanel stackPanel;

        public Grade(GradeType type, double ratio, double average, DateTime time, string name, string description, List<Grade> grades)  : base(type, ratio, average, time, name, description)
        {
            this.Grades = grades;
        }

        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
            CalculatedGrade = CalculateGrade();
            UpdateStackpanel();
        }

        public void SetCalculatedGrade(double grade)
        {
            CalculatedGrade = grade;
        }

        public double GetAverage()
        {
            CalculatedGrade = CalculateGrade();
            return CalculatedGrade;
        }

        public List<Grade> GetGrades()
        {
            return Grades;
        }

        public double CalculateGrade()
        {
            double average = 0;
            double biasSum = 0;

            for (int i = 0; i < Grades.Count; i++)
            {
                average += Grades[i].CalculateGrade() * Bias[i];
                biasSum += Bias[i];
            }

            CalculatedGrade = average / biasSum;

            return CalculatedGrade;
        }

        private void UpdateStackpanel()
        {
            stackPanel = StackpanelBuilder.BuildStackPanelGrades(Grades);
        }
    }
}
