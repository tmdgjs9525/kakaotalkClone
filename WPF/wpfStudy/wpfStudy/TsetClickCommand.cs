using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using wpfStudy.ViewModels;

namespace wpfStudy
{
    class TsetClickCommand : ICommand
    {
        private MainViewModel _mainViewModel;
        public event EventHandler? CanExecuteChanged;


        public TsetClickCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            MessageBox.Show(_mainViewModel.ProgressValue.ToString());
        }
    }
}
