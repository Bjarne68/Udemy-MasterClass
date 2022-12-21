using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EventsAndMulticastDelegates
{
    class GameEventManager
    {
        //new delegate type called GameEvent

        public delegate void GameEvent();

        //create two delegates variables

        public static event GameEvent OnGameStart, OnGameOver;

        public static void TriggerGameStart()

        {

            //check if the OnGameStart event is not empty

            //meaning that other methods are already subscribed to it

            if (OnGameStart != null)

            {

                MessageBox.Show("The game has started...");

                //call the OnGameStart that will trigger all the methods subscribed to this event

                OnGameStart();

            }

            else

            {

                MessageBox.Show("The game is ALREADY STARTED!");

            }

        }//TriggerGameStart()

        public static void TriggerGameOver()

        {

            if (OnGameOver != null)

            {

                MessageBox.Show("The game is ending...");

                //call the OnGameStart that will trigger all the methods subscribed to this event

                OnGameOver();

            }

            else

            {

                // this code never runs because nothing is unsubscribed

                MessageBox.Show("The game HAS ENDED!");

            }

        }

    }//GameEventManager
}

