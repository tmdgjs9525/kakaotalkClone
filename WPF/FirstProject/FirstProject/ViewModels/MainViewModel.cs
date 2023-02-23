using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FirstProject.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {

        private int progressValue;

        public ICommand TestClick { get; set; }
        public MainViewModel()
        {
            TestClick = new RelayCommand<object>(ExecuteMyButton, CanMyButton);
        }

        public int ProgressValue
        {
            get { return progressValue; }
            set 
            { 
                progressValue = value; 
                NotifyPropertyChanged(nameof(ProgressValue));
            }
        }
        bool CanMyButton(object param)
        {
            if(param == null) return true;
            return param.ToString().Equals("ABC") ? true : false;
        }

        void ExecuteMyButton(object param)
        {
            MessageBox.Show(param.ToString() + "AAA");
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
