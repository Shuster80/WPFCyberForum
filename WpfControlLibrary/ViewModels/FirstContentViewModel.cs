using ModelLib.DataObjects;
using ModelLib.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary.ViewModels
{
    internal class FirstContentViewModel : BindableBase
    {
        public ClosingCourse ClosingCourse;

        public FirstContentViewModel(ClosingCourse closingCourse)
        {
            this.ClosingCourse = closingCourse;

            University = closingCourse.University;
            Courses = closingCourse.Courses;
            StatusOrderName = closingCourse.OrderName;
        }

        private string _StatusOrderName;
        public string StatusOrderName
        {
            get { return _StatusOrderName; }
            set { SetProperty(ref _StatusOrderName, value); }
        }

        private University _University;
        public University University
        {
            get { return _University; }
            set { SetProperty(ref _University, value); }
        }

        private Course _SelectedUniversity;
        public Course SelectedUniversity
        {
            get => _SelectedUniversity;
            set
            {
                SetProperty(ref _SelectedUniversity, value);
            }
        }

        private List<Course> _Courses;
        public List<Course> Courses
        {
            get { return _Courses; }
            set { SetProperty(ref _Courses, value); }
        }

        private Course _SelectedCourse;
        public Course SelectedCourse
        {
            get => _SelectedCourse;
            set
            {
                SetProperty(ref _SelectedCourse, value);
            }
        }

        private Tag _Tag;
        public Tag Tag
        {
            get { return _Tag; }
            set { SetProperty(ref _Tag, value); }
        }

        private Category _Category;
        public Category Category
        {
            get { return _Category; }
            set { SetProperty(ref _Category, value); }
        }
    }
}
