using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    public class Title
    {
        private string name;

       public Title()
        {
        }
        public void Show()
        {
            Console.WriteLine(name);
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
