using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MVVMDemo
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, e);
            }
        }



        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
                this.OnPropertyChanged("Name");
            }
        }


        private string _greetWords;

        public string GreetWords
        {
            get
            {
                return _greetWords;
            }
            set
            {
                this._greetWords = value;
                this.OnPropertyChanged("GreetWords");
            }
        }
        


        #region SayHelloCmd

        private RelayCommand _sayHelloCmd;

        public RelayCommand SayHelloCmd { get { return _sayHelloCmd ?? (_sayHelloCmd = new RelayCommand(SayHello)); } }

        private void SayHello(object para)
        {
            GreetWords = "Hello! " + Name;
        }
        #endregion


    }
}
