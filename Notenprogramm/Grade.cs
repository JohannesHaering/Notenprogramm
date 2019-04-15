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
        private List<Grade> grades;
        private List<double> bias;
        private double calculatedGrade;

        private StackPanel stackPanel;

        public Grade(GradeType type, double ratio, double average, DateTime time, string name, string description, List<Grade> grades)  : base(type, ratio, average, time, name, description)
        {
            this.grades = grades;
        }

        public void addGrade(Grade grade)
        {
            grades.Add(grade);
            calculateGrade();
            updateStackpanel();
        }

        public List<Grade> getGrade()
        {
            return grades;
        }

        public double getAverage()
        {
            calculateGrade();
            return calculatedGrade;
        }

        public double calculateGrade()
        {
            double average = 0;
            double biasSum = 0;

            for (int i = 0; i < grades.Count; i++)
            {
                average += grades[i].calculateGrade() * bias[i];
                biasSum += bias[i];
            }

            calculatedGrade = average / biasSum;

            return calculatedGrade;
        }

        private void updateStackpanel()
        {

        }
    }
}
