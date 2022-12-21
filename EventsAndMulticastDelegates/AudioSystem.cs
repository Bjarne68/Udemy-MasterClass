using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EventsAndMulticastDelegates
{
    class AudioSystem
    {
        public AudioSystem

        {

            // In the current context += means subscribe. In other words it's like you are telling subscribe my method (the right operand) to this event (the left operand),

            // this way, when the event is raised, your method will be called.

            // Also, it is a good practice to unsubscribe (-= from this event, when you have finished your work ( but before you dispose you object )

            // in order to prevent your method being called and to prevent resource leaks.

            //GameEventManager.OnGameStart += StartGame;

            //GameEventManager.OnGameOver += GameOver;

        }

        private void StartGame()

        {

            MessageBox.Show("Audio system started...");

            MessageBox.Show("Playing Audio...");

        }

        private void GameOver()

        {

            MessageBox.Show("Audio System Stopped...");

        }

    }//AudioSystem


}

