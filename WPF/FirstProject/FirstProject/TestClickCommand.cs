using FirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FirstProject
{
    internal class TestClickCOmmand : ICommand
    {
        private MainViewModel _mainViewModel;
        private bool rtnCan = true;
        public event EventHandler? CanExecuteChanged;

        public TestClickCOmmand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public bool CanExecute(object? parameter)
        {
            return rtnCan;
        }

        public void Execute(object? parameter)
        {
            rtnCan = false;
            MessageBox.Show(_mainViewModel.ProgressValue.ToString());
        }
    }
}
