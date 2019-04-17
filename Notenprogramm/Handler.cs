using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            lesson.Show();
        }

        public void DeleteLessonClick(object sender, RoutedEventArgs args)
        {
            lesson.Stackpanel = null;
            lesson = null;
            lessons.Remove(lesson);
        }
    }
}
