using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    public class Post
    {
        private static int currentPostId;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        public bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "Min första post";
            IsPublic = true;
            SendByUsername = "Bjarne Andersson";
        }
        public Post (string title, bool isPublic, string sendByUsername)
        {
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
        }
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format($"{ID} - {Title} - {SendByUsername}");
        }
    }
}
