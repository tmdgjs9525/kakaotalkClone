using kakaotalkClone.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace kakaotalkClone.ViewModels
{
    internal class LoginViewModel : INotifyPropertyChanged
    {

        private Visibility visible;

        public Visibility Visible
        {
            get { return visible; }
            set { visible = value;
                NotifyPropertyChanged(nameof(visible));
            }
        }


        public ICommand loginCommand { get; set; }

        private Brush loginButtonBackGround;

        public Brush LoginButtonBackGround
        {
            get { return loginButtonBackGround; }
            set { loginButtonBackGround = value;
                NotifyPropertyChanged(nameof(loginButtonBackGround));
            }
        }



        public LoginViewModel()
        {
            loginCommand = new RelayCommand<object>(ExecuteLoginButton, loginCanButton);
        }

        bool loginCanButton(object param)
        {
            if(param == null)
            {
                return true;
            }
            if (param.ToString().Length > 4)
            {
                LoginButtonBackGround = Brushes.Brown;
                return true;
            }
            else
            {
                LoginButtonBackGround = Brushes.Silver;
                return false;
            }
        }

        void ExecuteLoginButton(object param)
        {
            MessageBox.Show("로그인");
            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = new mainWindowViewModel();
            mainWindow.ShowDialog();
            Visible = Visibility.Hidden;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyname="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
