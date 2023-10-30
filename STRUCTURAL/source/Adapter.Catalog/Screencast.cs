using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter.Catalog
{
    public class Screencast
    {
        private string title;
        private string author;
        private long duration;

        public Screencast (string title, string Author, long duration){
            this.title=title;
            this.author=Author;
            this.duration= duration;
        }

        public String getTitle ()=> this.title;
        public void setTitle (string title)=> this.title=title;

        public String getAuthor()=> this.author;
        public void setAuthor (string author) => this.author=author;
        public long getDuration ()=>this.duration;
        public void setDuration (long duration)=> this.duration=duration;
    }
}