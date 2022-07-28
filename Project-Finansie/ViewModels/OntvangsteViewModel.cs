using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Finansie.HulpClassen;

namespace Project_Finansie.ViewModels
{
    class OntvangsteViewModel : BasisViewModel
    {
        public override string this[string columnName]
        {
            get
            {
                return "";
            }
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            ViewModelHelper.ShowVieuw(parameter);
        }
    }
}
