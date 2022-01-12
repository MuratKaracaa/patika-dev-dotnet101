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
        private int size;
        private int appointedPerson;
        private string line;
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public int Size { get => size; set => size = value; }

        public string Line { get => line; set => line = value; }
        public int AppointedPerson { get => appointedPerson; set => appointedPerson = value; }

        public Card(string title, string content, int size, int appointedPerson)
        {
            this.Title = title;
            this.Content = content;
            this.Size = size;
            this.AppointedPerson = appointedPerson;
            this.Line = Enums_Constants.Constants.ToDo;
        }      

    }
}
