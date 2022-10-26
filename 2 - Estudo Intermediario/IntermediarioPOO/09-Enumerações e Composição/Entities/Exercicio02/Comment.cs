using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment(string comment) 
        {
            Text = comment;
        }
    }
}
