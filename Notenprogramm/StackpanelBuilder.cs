using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Notenprogramm
{
    public class StackpanelBuilder
    {
        /// <summary>
        /// Width of a textbox of a grade in px
        /// </summary>
        private const int GradeWidth = 80;
        /// <summary>
        /// Width of a button of a lesson in px
        /// </summary>
        private const int LessonsWidth = 120;
        /// <summary>
        /// Height of a button of a lesson in px
        /// </summary>
        private const int ButtonHeight = 20;
        /// <summary>
        /// Width of the delete button in px
        /// </summary>
        private const int DeleteWidth = 20;
        /// <summary>
        /// Margin right and left in px
        /// </summary>
        private const int MarginHorizontal = 10;
        /// <summary>
        /// Margin up and down in px
        /// </summary>
        private const int MarginVertical = 5;
        /// <summary>
        /// Symbol of deleting
        /// </summary>
        private const string DeleteSymbol = "X";

        public static StackPanel buildStackpanelGrades(Grade grade)
        {
            StackPanel builtStackpanel = new StackPanel();



            return builtStackpanel;
        }

        /// <summary>
        /// Gets a list of lessons and builds a Stackpanel out of them
        /// </summary>
        /// <param name="lessons"> List of all lessons to show</param>
        /// <returns>Teh built stackpanel which then is added to the GUI</returns>
        public static StackPanel BuildStackpanelLessons(List<Lesson> lessons)
        {
            StackPanel builtStackpanel = new StackPanel();
            builtStackpanel.Orientation = Orientation.Vertical;

            foreach (Lesson lesson in lessons)
            {
                builtStackpanel.Children.Add(BuildStackpanelLesson(lesson, new Handler(lessons, lesson)));
            }

            return builtStackpanel;
        }

        /// <summary>
        /// Creates a stackpanel for one lesson
        /// </summary>
        /// <param name="lesson">Lesson for which a stackpanel sould built</param>
        /// <param name="handler">Handler for the button clicks</param>
        /// <returns>Built stackpanel</returns>
        public static StackPanel BuildStackpanelLesson(Lesson lesson, Handler handler)
        {
            StackPanel builtStackpanel = new StackPanel();
            builtStackpanel.Orientation = Orientation.Horizontal;

            Button buttonChooseLesson = new Button();
            buttonChooseLesson.Content = lesson.ClassName;
            buttonChooseLesson.Width = LessonsWidth;
            buttonChooseLesson.Margin = new Thickness(MarginHorizontal, MarginVertical, MarginHorizontal, MarginVertical);
            buttonChooseLesson.Click += new RoutedEventHandler(handler.ChooseLessonClick);

            Button buttonDeleteClass = new Button();
            buttonDeleteClass.Content = DeleteSymbol;
            buttonDeleteClass.Width = DeleteWidth;
            buttonDeleteClass.Height = ButtonHeight;
            buttonDeleteClass.Click += new RoutedEventHandler(handler.DeleteLessonClick);

            builtStackpanel.Children.Add(buttonChooseLesson);
            builtStackpanel.Children.Add(buttonDeleteClass);

            return builtStackpanel;
        }
    }
}
