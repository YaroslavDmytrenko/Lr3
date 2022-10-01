using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    public class Author
    {
        private String name;

        public Author()
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
            set { 
                name = value;
            }
        }
    }
}
