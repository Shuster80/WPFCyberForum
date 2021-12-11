using ModelLib.DataObjects;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary.ViewModels
{
    internal class FirstViewModel : BindableBase
    {
        public ClosingCourse ClosingCourse;

        public FirstViewModel(ClosingCourse closingCourse)
        {
            this.ClosingCourse = closingCourse;

            StatusBarVM = new StatusBarViewModel(closingCourse);
            MenuVM = new MenuViewModel(closingCourse);
            FirstContentVM = new FirstContentViewModel(closingCourse);
        }

        private BindableBase _CurrentView;
        public BindableBase CurrentView
        {
            get { return _CurrentView; }
            set { SetProperty(ref _CurrentView, value); }
        }

        
        private BindableBase _StatusBarVM;
        public BindableBase StatusBarVM
        {
            get { return _StatusBarVM; }
            set { SetProperty(ref _StatusBarVM, value); }
        }

        private BindableBase _MenuVM;
        public BindableBase MenuVM
        {
            get { return _MenuVM; }
            set { SetProperty(ref _MenuVM, value); }
        }

        private BindableBase _FirstContentVM;
        public BindableBase FirstContentVM
        {
            get { return _FirstContentVM; }
            set { SetProperty(ref _FirstContentVM, value); }
        }
    }
}
