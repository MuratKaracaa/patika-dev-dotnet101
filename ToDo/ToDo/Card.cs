using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class Card
    {
        private string title;
        private string content;
        private string size;
        private string person;
        private string line;
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Size { get => size; set => size = value; }
        public string Person { get => person; set => person = value; }
        public string Line { get => line; set => line = value; }

        public Card(string title, string content, string size, string person)
        {
            this.Title = title;
            this.Content = content;
            this.Size = size;
            this.Person = person;
            this.Line = "";
        }      

    }
}
