using Microsoft.Xaml.Behaviors.Core;
using ModelLib.DataObjects;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfControlLibrary.ViewModels
{
    internal class MenuViewModel : BindableBase
    {

        public MenuViewModel(ClosingCourse closingCourse)
        {
            this.closingCourse = closingCourse;
        }

        private DelegateCommand _ShowUniversity;
        public DelegateCommand ShowUniversity =>
            _ShowUniversity ?? (_ShowUniversity = new DelegateCommand(OnShowUniversity));

        private void OnShowUniversity()
        {
            // TODO: Как здесь подгрузить данные в главное окно?
            // То есть команда отправится из MenuView Которая должна прибиндится в FirstWindow в третий столбец
        }


        // Такой же блок курса
        //
        //
        // Такая же категория


        private DelegateCommand _ShowTag;
        private ClosingCourse closingCourse;

        public DelegateCommand ShowTag =>
            _ShowTag ?? (_ShowTag = new DelegateCommand(OnShowTag));

        private void OnShowTag()
        {
            // TODO: ????
        }

    }
}
