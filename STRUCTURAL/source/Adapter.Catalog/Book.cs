using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter.Catalog
{
    public class Book
    {
        private string title;
        private string author;
        public Book (string title, String Author){
            this.title=title;
            this.author=author;
        }

        public string getTitle()=> title;
        public void setTitle(string title)=>this.title=title;

        public string getAuthor ()=>author;
        public void setAuthor(string author)=>this.author=author;   
    }
}