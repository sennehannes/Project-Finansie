﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace Project_Finansie.ViewModels
{
    public abstract class BasisViewModel : IDataErrorInfo, INotifyPropertyChanged, ICommand
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        // Deze methode wordt opgeroepen in de setter van elke property.  
        // [CallerMemberName Attribute]  is nieuw in NET Framework 4.5.   
        // Dit attribuut zorgt automatisch voor bepalen van de calling propertyName! 
        // Laat toe om bij de properties NotifyPropertyChanged() op te roepen ipv
        // OnPropertyChanged("naam property")
        // PropertyChanged?.Invoke(…)
        // => if (PropertyChanged != null) {PropertyChanged.Invoke(); }
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region IDataErrorInfo
        public abstract string this[string columnName] { get; }

        public string Error
        {
            get
            {
                string foutmeldingen = "";

                foreach (var item in this.GetType().GetProperties()) //reflection 
                {

                    string fout = this[item.Name];
                    if (!string.IsNullOrWhiteSpace(fout))
                    {
                        foutmeldingen += fout + Environment.NewLine;
                    }

                }
                return foutmeldingen;
            }
        }
        #endregion


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public abstract bool CanExecute(object parameter);



        public abstract void Execute(object parameter);


        #region hulpmethodes
        public bool IsGeldig()
        {
            return string.IsNullOrWhiteSpace(Error);

        }


        #endregion
    }
}
