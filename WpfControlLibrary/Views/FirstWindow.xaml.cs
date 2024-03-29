﻿using ModelLib.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        private readonly Locator locator = Locator.Instance;
        private ClosingCourse closingCourse;
        public FirstWindow(ClosingCourse closingCourse) //: this()
        {
            InitializeComponent();
            this.closingCourse = closingCourse;


            locator.FirstViewModel = new FirstViewModel(closingCourse);
        }



        public ClosingCourse ClosingCourse => this.closingCourse;
    }
}
