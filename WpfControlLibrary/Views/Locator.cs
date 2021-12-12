using ModelLib.DataObjects;
using Prism.Mvvm;
using WpfControlLibrary.ViewModels;

namespace WpfControlLibrary.Views
{
    // Локатор - это вспомогательный класс View, а не ViewModel.
    internal class Locator : BindableBase
    {
        private ClosingCourse _data;
        private FirstViewModel _firstViewModel;

        public ClosingCourse Data { get => _data; set => SetProperty(ref _data, value); }

        public FirstViewModel FirstViewModel { get => _firstViewModel; set =>SetProperty(ref _firstViewModel, value); }

        private Locator() { }

        public static Locator Instance { get; } = new Locator();
    }
}
