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
                new User(new Uri(@"\Resources\defaultProfile.png", UriKind.Relative), "이승헌"),
                new User(new Uri(@"\Resources\defaultProfile.png",UriKind.Relative), "박효신"),
                new User(new Uri(@"\Resources\defaultProfile.png",UriKind.Relative), "아르노"),
                new User(new Uri(@"\Resources\defaultProfile.png", UriKind.Relative), "케케케"),
                new User(new Uri(@"\Resources\defaultProfile.png", UriKind.Relative), "김가연"),
                new User(new Uri(@"\Resources\defaultProfile.png", UriKind.Relative), "옥주현"),
            };

            Rooms = new List<Room>
            {
                new Room(testUsers[0],"뭐해?"),
                new Room(testUsers[1]),
                new Room(testUsers[2], "테스트"),
                new Room(testUsers[3],"나 노래 부르고 있지"),
                new Room(testUsers[4]),
                new Room(testUsers[5], "가즈아"),
                new Room(testUsers[6], "엥엥엥엥엥엥엥엥엥"),
                new Room(testUsers[7], "레베카~~"),
            };


        }
        private void showRoom(object param)
        {
            RoomWindow room = new RoomWindow(SelectedItem.User);
            room.Show();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
