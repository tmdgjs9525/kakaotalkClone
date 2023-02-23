using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using wpfStudy.Views;

namespace wpfStudy.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private int progressValue;
        public ICommand TestClick { get; set; }
        public ICommand SecondShow { get; set; }

        public MainViewModel()
        {
            //TestClick = new RelayCommand<object>(ExecuteMyButton,CanMyButton);
            TestClick = new AsyncRelayCommand(ExecuteMyButton2);
            SecondShow = new AsyncRelayCommand(ExecuteMyButton3);

        }
        public int ProgressValue
        {
            get { return progressValue; }
            set {
                progressValue = value;
                NotifyPropertyChanged(nameof(progressValue));
            }
        }


        bool CanMyButton(object param)
        {
            if (param == null) return true;
            return !param.ToString().Equals("");
        }

        void ExecuteMyButton(object param)
        {
            Task task1 = Task.Run(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    ProgressValue = i;
                    Thread.Sleep(100);
                }
            });
          
            MessageBox.Show("a");
        }
        public async Task ExecuteMyButton2()
        {
            Task<int> task1 = Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    ProgressValue = i;
                    Thread.Sleep(100);
                }
                return 5;
            });
            int w = await task1;
            MessageBox.Show("a");
        }

        public async Task ExecuteMyButton3()
        {
            SecondView secondVIew = new SecondView();
            SecondViewModel aa = new SecondViewModel();
            aa.ProgressValue = 70;
            secondVIew.DataContext = aa;
            secondVIew.ShowDialog();
            await Task.Delay(0);
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName ="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
