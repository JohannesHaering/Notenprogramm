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
        public List<Lesson> Lessons { get; set; }
        public Lesson Lesson { get; set; }

        public Handler(List<Lesson> lessons, Lesson lesson)
        {
            this.Lessons = lessons;
            this.Lesson = lesson;
        }

        public void ChooseLessonClick(object sender, RoutedEventArgs args)
        {
            Lesson.ShowDetailed();
        }

        public void DeleteLessonClick(object sender, RoutedEventArgs args)
        {
            (Lesson.ViewHolderLesson.StackPanelOrganisation.Parent as StackPanel).Children.Remove(Lesson.ViewHolderLesson.StackPanelOrganisation);
            Lessons.Remove(Lesson);
            Lesson = null;
        }
    }
}
