using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace CountAndPrint
{
    public class RandomLetters
    {
        private static Random generator = new Random();
        private bool suspended = false;
        private Label output;
        private string threadName;
        private int sleepTime = 1001;

        public RandomLetters(Label label)
        {
            output = label;
        }

        private delegate void DisplayDelegate(char displayChar);

        private void DisplayCharacter(char displayChar)
        {
            output.Text = threadName + ": " + displayChar;
        }

        public void GenerateRandomCharacters()
        {
            threadName = Thread.CurrentThread.Name;

            while (true)
            {
                Thread.Sleep(generator.Next(sleepTime));

                lock (this)
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

            lock (this)
            {
                if (!suspended)
                    Monitor.Pulse(this);
            }
        }
    }
}
