using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfStudy.Models
{
    class USERINFO
    {
		private string userName;
        private string userImg;
        private int userage;

        public string USERNAME
		{
			get { return userName; }
			set { userName = value; }
		}

		

		public string USERIMG
		{
			get { return userImg; }
			set { userImg = value; }
		}

		

		public int USERAGE
		{
			get { return userage; }
			set { userage = value; }
		}

	}
}
