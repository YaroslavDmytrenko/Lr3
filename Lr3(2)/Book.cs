using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    public class Book
    {
        string author;
        string content;
        string title;
        public Book(string author, string content, string title) {
            this.author = author;
            this.content = content;
            this.title = title;
        }

        public string Show()
        {
            return $"{author}, {content}, {title}";
        }
       

    }
}
