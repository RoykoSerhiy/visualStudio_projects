using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denomination
{
    class Denominations : INotifyPropertyChanged
    {
        string denom_5;
        string denom_10;
        string denom_20;
        string denom_50;
        string denom_100;
       // int totalDenomination;

        public string Denom5
        {
            get { return denom_5; }
            set
            {
                if (value == "" || value == null)
                {
                    value = "0";
                }
                denom_5 = value; this.OnPropertyChanged("Denom5");
                this.OnPropertyChanged("TotalDenomination");
            }
         }
        public string Denom10
        {
            get { return denom_10; }
            set
            {
                if (value == "" || value == null)
                {
                    value = "0";
                }
                denom_10 = value; this.OnPropertyChanged("Denom10");
                this.OnPropertyChanged("TotalDenomination");
            }
        }
        public string Denom20
        {
            get { return denom_20; }
            set
            {
                if (value == "" || value == null)
                {
                    value = "0";
                }
                denom_20 = value; this.OnPropertyChanged("Denom20");
                this.OnPropertyChanged("TotalDenomination");
            }
        }
        public string Denom50
        {
            get { return denom_50; }
            set
            {
                if (value == "" || value == null)
                {
                    value = "0";
                }
                denom_50 = value; this.OnPropertyChanged("Denom50");
                this.OnPropertyChanged("TotalDenomination");
            }
        }
        public string Denom100
        {
            get { return denom_100; }
            set
            {
                if (value == "" || value == null)
                {
                    value = "0";
                }
               
                    denom_100 = value; this.OnPropertyChanged("Denom100");
                    this.OnPropertyChanged("TotalDenomination");
                
            }
        }

        public string TotalDenomination
        {
            get { return Convert.ToString((Convert.ToInt32(this.Denom5) * 5 + Convert.ToInt32(this.Denom10) * 10 + Convert.ToInt32(this.Denom20) * 20 + Convert.ToInt32(this.Denom50) * 50 + Convert.ToInt32(this.Denom100) * 100)); }
        }
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        #endregion
    }
}
