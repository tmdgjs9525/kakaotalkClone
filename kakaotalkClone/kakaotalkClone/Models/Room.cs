using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakaotalkClone.Models
{
    public class Room
    {
		private string lastText;
        private User user;

		public Room(User user, string lastText)
		{
			this.User = user;
			this.LastText = lastText;
		}
		public Room(User user) : this (user,"")
		{

		}
        public string LastText
		{
			get { return lastText; }
			set { lastText = value; }
		}

		

		public User User
		{
			get { return user; }
			set { user = value; }
		}

	}
}
