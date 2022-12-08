using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    public class ImagePosts:Post
    {
        public string ImageURL { get; set; }

        public ImagePosts()
        {

        }

        public ImagePosts(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            ID=GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format($"{ID} - {Title} - {SendByUsername} - {ImageURL}");
        }
    }
}
