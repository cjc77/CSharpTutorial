using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace GUIMultiThreading
{
    public partial class GUIThreadsForm : Form
    {
        public GUIThreadsForm()
        {
            InitializeComponent();
        }

        // My Code

        // random letters
        private RandomLetters letter1;
        private RandomLetters letter2;
        private RandomLetters letter3;

        // labels
        Label thread1Label = new Label();

        private void GUIThreadsForm_Load(object sender, EventArgs e)
        {
            // create first thread
            letter1 = new RandomLetters(thread1Label);
            Thread thread1 = new Thread(new ThreadStart(letter1.GenerateRandomCharacters));
            thread1.Name = "Thread 1";
            thread1.Start();
        }

        private void GUIThreadsForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
    }
}
