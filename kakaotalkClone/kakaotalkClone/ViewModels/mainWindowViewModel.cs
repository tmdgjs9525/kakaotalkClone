using kakaotalkClone.Models;
using kakaotalkClone.Properties;
using kakaotalkClone.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace kakaotalkClone.ViewModels
{
    public class mainWindowViewModel :INotifyPropertyChanged
    {
        private List<Room> rooms;
        private Room selectedItem;


        public ICommand roomDoubleClick { get; set; }
        #region property
        public List<Room> Rooms
        {
            get { return rooms; }
            set {
                rooms = value;
                NotifyPropertyChanged(nameof(rooms));
            }
        }
        public Room SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; }
        }
        #endregion

        public mainWindowViewModel()
        {
            roomDoubleClick = new RelayCommand<object>(showRoom, null);
            List<User> testUsers = new List<User>
            {
                new User(new Uri(@"\Resources\defaultProfile.png",UriKind.Relative), "amuga"),
                new User(new Uri(@"\Resources\defaultProfile.png",UriKind.Relative), "bbb"),
                new User(new Uri(@"\Resources\defaultProfile.png", UriKind.Relative), "ccc")
            };

            Rooms = new List<Room>
            {
                new Room(testUsers[0],"뭐해?"),
                new Room(testUsers[1]),
                new Room(testUsers[2], "테스트"),
            };


        }
        private void showRoom(object param)
        {
            RoomWindow room = new RoomWindow();
            room.DataContext = new roomViewModel(SelectedItem.User);
            room.Show();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
