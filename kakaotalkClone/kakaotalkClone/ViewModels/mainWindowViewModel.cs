using kakaotalkClone.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kakaotalkClone.ViewModels
{
    public class mainWindowViewModel :INotifyPropertyChanged
    {
        private List<Room> rooms;

        #region property
        public List<Room> Rooms
        {
            get { return rooms; }
            set {
                rooms = value;
                NotifyPropertyChanged(nameof(rooms));
            }
        }
        #endregion

        public mainWindowViewModel()
        {
            List<User> testUsers = new List<User>
            {
                new User(@"C:\Users\tmdgj\Desktop\wpfStudy\kakaotalkClone\kakaotalkClone\Resources\defaultProfile.png", "amuga"),
                new User(@"C:\Users\tmdgj\Desktop\wpfStudy\kakaotalkClone\kakaotalkClone\Resources\defaultProfile.png", "bbb"),
                new User(@"C:\Users\tmdgj\Desktop\wpfStudy\kakaotalkClone\kakaotalkClone\Resources\defaultProfile.png", "ccc")
            };
            Rooms = new List<Room>
            {
                new Room(testUsers[0],"뭐해?"),
                new Room(testUsers[1]),
                new Room(testUsers[2], "테스트"),
            };


        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
