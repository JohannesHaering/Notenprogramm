using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Notenprogramm
{
    public class Handler
    {
        public List<Lesson> lessons { get; set; }
        public Lesson lesson { get; set; }

        public Handler(List<Lesson> lessons, Lesson lesson)
        {
            this.lessons = lessons;
            this.lesson = lesson;
        }

        public void ChooseLessonClick(object sender, RoutedEventArgs args)
        {
            lesson.ShowDetailed();
        }

        public void DeleteLessonClick(object sender, RoutedEventArgs args)
        {
            (lesson.StackPanelOrganisation.Parent as StackPanel).Children.Remove(lesson.StackPanelOrganisation);
            lessons.Remove(lesson);
            lesson = null;
        }
    }
}
