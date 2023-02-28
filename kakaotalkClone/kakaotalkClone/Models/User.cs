using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakaotalkClone.Models
{
    public class User
    {
		private Uri userImg;
		private string userName;


		public User(Uri userImg, string userName)
		{
			this.UserName= userName;
			this.UserImg= userImg;
		}

		#region property
		public Uri UserImg
		{
			get { return userImg; }
			set { userImg = value; }
		}
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        #endregion

    }
}
