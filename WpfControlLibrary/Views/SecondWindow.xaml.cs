using ModelLib.DataObjects;
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
using WpfControlLibrary.ViewModels;

namespace WpfControlLibrary.Views
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        private CreateCourse createCourse;

        public SecondWindow()
        {
            InitializeComponent();
        }

        public SecondWindow(CreateCourse createCourse) : this()
        {
            this.createCourse = createCourse;
            this.DataContext = new SecondViewModel(createCourse);
        }
    }
}
