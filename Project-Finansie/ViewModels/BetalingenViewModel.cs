using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Project_Finansie.HulpClassen;
using Project_Finansie_DAL;
using Project_Finansie_DAL.Data;
using Project_Finansie_DAL.Data.UnitOfWork;
using Project_Finansie_DAL.DomainModel;

namespace Project_Finansie.ViewModels
{
    class BetalingenViewModel : BasisViewModel
    {
        IUnitOfWork unitOfWork = new UnitOfWork(new Finansie_Enteties());
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
            switch (parameter)
            {
                case "Toevoegen": AanmakenBetaling(); 
                    break;
            }
        }

        private void valideer()
        {
            Foutmelding = "";
            if (string.IsNullOrWhiteSpace(NaamOntvanger))
            {
                Foutmelding += "Naam Ontvanger is een verplicht veld \n";
            }
            if (!double.TryParse(Bedrag, out double result))
            {
                Foutmelding += "Bedrag moet een getal zijn \n";
            }
            if (string.IsNullOrWhiteSpace(Bedrag))
            {
                Foutmelding += "ISBN is een verplicht veld \n";
            }
        }

        public void AanmakenBetaling()
        {
            valideer();
            NotifyPropertyChanged("Foutmelding");
            if (Foutmelding == "")
            {
                Users g = unitOfWork.UsersRepo.Ophalen(x => x.Naam == LoggedInUser.loggedInUser).SingleOrDefault();
                Betalingen betaling = new Betalingen()
                {

                    UserId = g.Id,
                    Datum = DateTime.Now,
                    Hoeveelheid = double.Parse(Bedrag),
                };
                unitOfWork.BetalingenRepo.Toevoegen(betaling);
                unitOfWork.Save();
            }
            else
            {
                MessageBox.Show(Foutmelding);
            }
        }
        private string _foutmelding;

        public string Foutmelding
        {
            get { return _foutmelding; }
            set
            {
                _foutmelding = value;
                NotifyPropertyChanged(nameof(_foutmelding));
            }
        }
        

        private string _Bedrag;
        public string Bedrag
        {
            get { return _Bedrag; }
            set
            {
                _Bedrag = value;
                NotifyPropertyChanged(nameof(_Bedrag));
            }
        }

        private string _NaamOntvanger;
        public string NaamOntvanger
        {
            get { return _NaamOntvanger; }
            set
            {
                _NaamOntvanger = value;
                NotifyPropertyChanged(nameof(_NaamOntvanger));
            }
        }
    }
}
