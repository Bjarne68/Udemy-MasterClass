using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceC
{
    public class VideoPost:Post
    {
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;
        public string VideoURL { get; set; }
        public int Length { get; set; }
        public VideoPost()
        {

        }
        public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic)
        {
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            VideoURL = videoURL;
            Length = length;
            IsPublic = isPublic;
        }

        public void Play()
        {
            if(!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if(currDuration<Length)
            {
                currDuration++;
                Console.WriteLine($"Video at {currDuration}");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(isPlaying) 
            {
                isPlaying= false;
                Console.WriteLine($"Stopped at {currDuration}");
                currDuration = 0;
                timer.Dispose();
            }
        }
        public override string ToString()
        {
            return String.Format($"{ID} - {Title} - {SendByUsername} - {VideoURL} -  {Length} minuter");
        }
    }
}
