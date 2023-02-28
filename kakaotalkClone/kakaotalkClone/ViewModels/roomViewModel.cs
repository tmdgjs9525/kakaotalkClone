using kakaotalkClone.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kakaotalkClone.ViewModels
{
    public class roomViewModel : INotifyPropertyChanged
    {
		private string title;

        private User user;

        public User User
        {
            get { return user; }
            set { user = value; }
        }



        public string Title
		{
			get { return title; }
			set { title = value; }
		}

        public roomViewModel(User user)
        {
            User = user;
            title = user.UserName;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
