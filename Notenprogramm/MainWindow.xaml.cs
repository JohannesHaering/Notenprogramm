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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notenprogramm
{
    public partial class MainWindow : Window
    {
        private LessonsWrapper LessonsWrapper;
        public MainWindow()
        {
            InitializeComponent();

            LessonsWrapper = new LessonsWrapper(SP_lessons, SP_showLesson);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            LessonsWrapper.Save();
        }

        private void BTN_AddLesson_Click(object sender, RoutedEventArgs e)
        {
            LessonsWrapper.AddLesson();
        }
    }
}
