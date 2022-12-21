using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EventsAndMulticastDelegates
{
    class RenderingEngine
    {
        public RenderingEngine

        {
           
             
            //GameEventManager.OnGameStart += StartGame;

            //GameEventManager.OnGameOver += GameOver;

        }

        private void StartGame()

        {

            MessageBox.Show("Rendering engine started...");

            MessageBox.Show("Drawing visuals...");

        }

        private void GameOver()

        {

            MessageBox.Show("Rendering Engine Stopped...");

        }

    }//RenderingEngine
}

