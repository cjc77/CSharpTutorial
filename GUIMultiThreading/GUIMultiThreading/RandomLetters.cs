using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace GUIMultiThreading
{
    class RandomLetters
    {
        // used for random characters
        private static Random generator = new Random();
        // true if thread is suspended
        private bool suspended = false;
        // Label to display output
        private Label output;
        // name of ucrrent thread
        private string threadName;

        public RandomLetters(Label label)
        {
            output = label;
        }

        // delegate to be used for Invoke()
        private delegate void DisplayDelegate(char displayChar);

        // set Label's Text property
        private void DisplayCharacter(char displayChar)
        {
            output.Text = threadName + ": " + displayChar;
        }

        public void GenerateRandomCharacters()
        {
            threadName = Thread.CurrentThread.Name;

            // terminated from outside
            while (true)
            {
                Thread.Sleep(generator.Next(1001));

                lock(this)
                {
                    while (suspended)
                    {
                        Monitor.Wait(this);
                    }
                }

                char displayChar = (char)(generator.Next(26) + 65);
                output.Invoke(new DisplayDelegate(DisplayCharacter), new object[] { displayChar });
            }
        }

        public void Toggle()
        {
            suspended = !suspended;
            output.BackColor = suspended ? Color.Red : Color.LightGreen;

            lock(this)
            {
                if (!suspended)
                    Monitor.Pulse(this);
            }
        }
    }
}
