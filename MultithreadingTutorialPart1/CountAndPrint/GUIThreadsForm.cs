using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CountAndPrint
{
    public partial class GUIThreadsForm : Form
    {
        public GUIThreadsForm()
        {
            InitializeComponent();
        }

        private RandomLetters letter1;
        private RandomLetters letter2;
        private RandomLetters letter3;
        
        private void GUIThreadsForm_Load(object sender, EventArgs e)
        {
            letter1 = new RandomLetters(thread1Label);
            Thread firstThread = new Thread(letter1.GenerateRandomCharacters);
            firstThread.Name = "Thread 1";
            firstThread.Start();

            letter2 = new RandomLetters(thread2Label);
            Thread secondThread = new Thread(letter2.GenerateRandomCharacters);
            secondThread.Name = "Thread 2";
            secondThread.Start();

            letter3 = new RandomLetters(thread3Label);
            Thread thirdThread = new Thread(letter3.GenerateRandomCharacters);
            thirdThread.Name = "Thread 3";
            thirdThread.Start();
        }

        private void GUIThreadsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close all threads
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void threadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == thread1CheckBox)
                letter1.Toggle();
            else if (sender == thread2CheckBox)
                letter2.Toggle();
            else if (sender == thread3CheckBox)
                letter3.Toggle();
        }
    }
}
