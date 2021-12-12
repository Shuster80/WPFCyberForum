using ModelLib.DataObjects;
using Prism.Mvvm;

namespace WpfControlLibrary.ViewModels
{
    internal class FirstViewModel : BindableBase
    {
        /// <summary>Если это публичный член, то это должно быть свойство.</summary>
        public ClosingCourse ClosingCourse;

        public FirstViewModel(ClosingCourse closingCourse)
        {
            this.ClosingCourse = closingCourse;

            StatusBarVM = new StatusBarViewModel(closingCourse);
            MenuVM = new MenuViewModel(closingCourse);
            FirstContentVM = new FirstContentViewModel(closingCourse);
        }

        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set => SetProperty(ref _currentView, value);
        }


        public StatusBarViewModel StatusBarVM { get; }

        public MenuViewModel MenuVM { get; }

        public FirstContentViewModel FirstContentVM { get; }
    }
}
