using kakaotalkClone.ViewModels;
using kakaotalkClone.Views;
using System.Windows;

namespace kakaotalkClone
{
		public class App : Application
		{
				protected override void OnStartup(StartupEventArgs e)
				{
						base.OnStartup (e);
						LoginWindow login = new LoginWindow ();
						login.ShowDialog ();
				}
		}
}
