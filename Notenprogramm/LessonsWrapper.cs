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
        public StackPanel StackpanelLessonsOrganisation { get; set; }
        public StackPanel StackpanelLessonShow { get; set; }
        private List<Lesson> Lessons { get; set; }

        public LessonsWrapper(StackPanel stackPanelOrganisation, StackPanel stackPanelShow)
        {
            StackpanelLessonsOrganisation = stackPanelOrganisation;
            StackpanelLessonShow = stackPanelShow;
            Lessons = IOWrapper.GetLessons();
            StackpanelLessonsOrganisation.Children.Add(StackpanelBuilder.BuildStackpanelLessons(Lessons));
        }   
        
        public void AddLesson()
        {
            Lesson newLesson = new Lesson();
            CreateLessonWindow createLessonWindow = new CreateLessonWindow(newLesson);
            createLessonWindow.ShowDialog();

            newLesson.CreateViewHolder(new Handler(Lessons, newLesson));
            Lessons.Add(newLesson);
            StackpanelLessonsOrganisation.Children.Add(newLesson.ShowOrganisation());
        }

        public void Save()
        {
            IOWrapper.Save(Lessons);
        }
    }
}
