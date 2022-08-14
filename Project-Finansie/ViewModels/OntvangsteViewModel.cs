using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Project_Finansie.HulpClassen;
using Project_Finansie_DAL;
using Project_Finansie_DAL.DomainModel;

namespace Project_Finansie.ViewModels
{
    class OntvangsteViewModel : BasisViewModel
    {
        private ObservableCollection<Ontvangste> ontvangste;
        private string _foutmelding;

        public ObservableCollection<Ontvangste> Ontvangste
        {
            get { return ontvangste; }
            set
            {
                ontvangste = value;
                NotifyPropertyChanged("Boeken");
            }
        }
        public string Foutmelding
        {
            get { return _foutmelding; }
            set
            {
                _foutmelding = value;
                NotifyPropertyChanged("Foutmelding");

            }
        }

        public new event PropertyChangedEventHandler PropertyChanged;
        private new void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
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
