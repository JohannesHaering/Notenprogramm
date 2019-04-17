using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Notenprogramm
{
    public class LessonsWrapper
    {
        public StackPanel Stackpanel { get; set; }
        private List<Lesson> Lessons { get; set; }

        public LessonsWrapper(StackPanel stackPanel)
        {
            Stackpanel = stackPanel;
            Lessons = IOWrapper.GetLessons();
            Stackpanel.Children.Add(StackpanelBuilder.BuildStackpanelLessons(Lessons));
        }   
        
        public void AddLesson()
        {
            // TODO: New Window for adding a new lesson
        }
    }
}
