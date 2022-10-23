using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO.Entities
{
    class PostUdemy
    {

        public DateTime Moment { get; private set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; private set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();


        public PostUdemy(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void addComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void removeComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");

            foreach (Comment obj in Comments) 
            {

                sb.AppendLine(obj.Text);
            }
            return sb.ToString();


        }
    }
}
