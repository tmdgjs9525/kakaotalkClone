using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakaotalkClone
{
    public class Starter
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Appd app = new Appd();
            app.Run();
        }
        
    }
}
