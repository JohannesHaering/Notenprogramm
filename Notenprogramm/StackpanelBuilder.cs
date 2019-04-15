using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Notenprogramm
{
    public class StackpanelBuilder
    {
        private const int WIDTH = 80;

        public static StackPanel BuildStackPanelGrades(List<Grade> grades)
        {
            StackPanel stackPanel = new StackPanel();

            foreach (Grade grade in grades)
            {
                stackPanel.Children.Add(BuildStackpanelGrade(grade));
            }

            return stackPanel;
        }

        private static StackPanel BuildStackpanelGrade(Grade grade)
        {
            StackPanel builtStackpanel = new StackPanel();

            if (grade.GetGrades().Count == 0)
            {
                TextBox textBox = new TextBox();
                textBox.Text = grade.GetAverage().ToString();
                textBox.Width = WIDTH;
                textBox.TextChanged += new TextChangedEventHandler(new ChangeGradeHandler(grade).HandleGradeChange);
                builtStackpanel.Children.Add(textBox);
            }
            else
            {
                builtStackpanel.Children.Add(BuildStackPanelGrades(grade.GetGrades()));
            }

            return builtStackpanel;
        }
    }
}
