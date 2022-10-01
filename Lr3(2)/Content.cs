using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    public class Content
    {
        private string info;

        public Content()
        {
        }

        public void Show()
        {
            Console.WriteLine(info);
        }

        public string Info
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
            }
        }
    }
}
