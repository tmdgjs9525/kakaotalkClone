using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using wpfStudy.ViewModels;

namespace wpfStudy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainViewModel;
        public MainWindow()
        {
            InitializeComponent();
            mainViewModel= new MainViewModel();
            mainViewModel.ProgressValue = 30;
            DataContext= mainViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.ProgressValue = 100;
        }
    }
}
