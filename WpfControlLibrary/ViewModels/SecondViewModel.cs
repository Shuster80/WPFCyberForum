using ModelLib.DataObjects;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary.ViewModels
{
    internal class SecondViewModel : BindableBase
    {
        private CreateCourse createCourse;

        public SecondViewModel(CreateCourse createCourse)
        {
            this.createCourse = createCourse;
        }
    }
}
