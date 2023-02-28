using kakaotalkClone.ViewModels;
using kakaotalkClone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kakaotalkClone
{
    public class Appd : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            LoginWindow login = new LoginWindow();
            login.DataContext = new LoginViewModel();
            login.ShowDialog();
        }
    }
}
