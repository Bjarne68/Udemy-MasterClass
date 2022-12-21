using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace EventsAndMulticastDelegates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AudioSystem audioSystem = new AudioSystem();

            RenderingEngine renderingEngine = new RenderingEngine();
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");
            Player player3 = new Player("DragonDog");

            GameEventManager.TriggerGameStart();



            /*

             * * used in the first part before we code an event handler         

            audioSystem.StartGame();

            renderingEngine.StartGame();

            player1.StartGame();

            player2.StartGame();

            MessageBox.Show("Game is running. Press any key to end the game");

             Console.ReadKey();

            renderingEngine.GameOver();

            audioSystem.GameOver();

            player1.GameOver();

            player2.GameOver();

            */

            MessageBox.Show("Game is running. Press any key to end the game");

             

            GameEventManager.TriggerGameOver();

            MessageBox.Show ("Game is shutdown. Thank you for playing!");
        }
    }
}
