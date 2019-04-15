using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Notenprogramm
{
    public class ChangeGradeHandler
    {
        private Grade Grade;

        public ChangeGradeHandler(Grade grade)
        {
            Grade = grade;
        }

        public void HandleGradeChange(object sender, TextChangedEventArgs args)
        {
            try
            {
                Grade.SetCalculatedGrade(Double.Parse(((TextBox)sender).Text));
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie eine rationale Zahl ein.");
            }

        }
    }
}
