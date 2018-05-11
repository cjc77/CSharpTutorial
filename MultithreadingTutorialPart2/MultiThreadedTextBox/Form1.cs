using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadedTextBox
{
    public partial class Form1 : Form
    {
        static Thread worker;
        bool cont = true;
        ManualResetEvent signalEvent = new ManualResetEvent(false);
        public Form1()
        {
            InitializeComponent();
            worker = new Thread(Work);
            worker.Start();
        }

        void Work()
        {
            Random rand = new Random();
            int curr;
            while (true)
            {
                Thread.Sleep(rand.Next(1000, 2000));
                if (cont)
                {
                    curr = rand.Next(1000, 2000);
                    UpdateMessage(curr.ToString());
                }
                else
                {
                    signalEvent.WaitOne();
                    signalEvent.Reset();
                }
            }
        }

        void UpdateMessage(string message)
        {
            Action action = () => _MessageAction(message);
            this.BeginInvoke(action);
        }

        void _MessageAction(string message)
        {
            textBox1.Text = message;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void threadControl_MouseClick(object sender, MouseEventArgs e)
        {
            cont = !cont;
            if (cont)
            {
                textBox1.Text = "pulsing";
                signalEvent.Set();
            }
        }
    }
}
