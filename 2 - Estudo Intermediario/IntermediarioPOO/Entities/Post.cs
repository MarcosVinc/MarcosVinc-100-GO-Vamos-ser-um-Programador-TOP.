using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO.Entities
{
    class Post
    {
        public DateTime Moment { get; private set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; private set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();


        public Post(DateTime moment, string title, string content, int likes) 
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


    }
}
