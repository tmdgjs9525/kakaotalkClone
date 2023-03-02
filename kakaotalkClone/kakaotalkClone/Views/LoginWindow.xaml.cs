using kakaotalkClone.ViewModels;
using System.Windows;

namespace kakaotalkClone.Views
{
		/// <summary>
		/// LoginWindow.xaml에 대한 상호 작용 논리
		/// </summary>
		public partial class LoginWindow : Window
    {
        LoginViewModel loginViewModel;
        public LoginWindow()
        {
            InitializeComponent();
            loginViewModel = new LoginViewModel();
            DataContext = loginViewModel;
        }
    }
}
