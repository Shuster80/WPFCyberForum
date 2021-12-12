using ModelLib.DataObjects;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary.ViewModels
{
    public class StatusBarViewModel : BindableBase
    {

        private ClosingCourse closingCourse;

        public StatusBarViewModel(ClosingCourse closingCourse)
        {
            this.closingCourse = closingCourse;

            // TODO: Жёсткая привязка к StatusOrderName
            // А как сделать чтобы в Status или не в статус отображалось closingCourse.OrderName
            // с возможностью изменения из любой вьюхи или любого места в том числе и отсюда StatusOrderName => closingCourse.OrderName;

            StatusOrderName = closingCourse.OrderName;
        }

        private string _StatusOrderName;
        public string StatusOrderName
        {
            get { return _StatusOrderName; }
            set { SetProperty(ref _StatusOrderName, value); }
        }

    }
}
