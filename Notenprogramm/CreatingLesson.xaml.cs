using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Notenprogramm
{
    /// <summary>
    /// Interaction logic for CreatingLesson.xaml
    /// </summary>
    public partial class CreatingLesson : Window
    {
        private Lesson Lesson;

        public CreatingLesson(Lesson lesson)
        {
            InitializeComponent();

            Lesson = lesson;
        }

        private void BTN_Save_Click(object sender, RoutedEventArgs e)
        {
            Lesson.LessonName = TB_lessonName.Text;

            try
            {
                Lesson.StudentsNumber = int.Parse(TB_studentsNumber.Text);
            }
            catch
            {
                MessageBox.Show("Geben Sie bitte eine integrale Zahl ein.");
                return;
            }

            try
            {
                Lesson.ExamRatio = double.Parse(TB_exam.Text);
                Lesson.OralRatio = double.Parse(TB_oral.Text);
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie eine rationale Zahl ein.");
                return;
            }

            Close();
        }

        private void BTN_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
