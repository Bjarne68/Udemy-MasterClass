using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InheritanceC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           

            Post post1 = new Post("Tack för gratulationen på födelsedagen", true, "Bjarne Andersson");
            Console.WriteLine(post1.ToString());
            ImagePosts imagePosts1 = new ImagePosts("Kolla mina nya skor", "Bjarne Andersson", "https://images.com/shoes", true);
            Console.WriteLine(imagePosts1.ToString());
            VideoPost videoPost = new VideoPost("Sagan om Ringen", "Bjarne Andersson", "https://video.com/ring", 5, true);
            Console.WriteLine(videoPost.ToString());
            videoPost.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videoPost.Stop();
        }
    }
}
