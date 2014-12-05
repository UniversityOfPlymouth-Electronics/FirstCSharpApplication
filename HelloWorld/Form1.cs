using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class MyForm : Form
    {
        ArrayList sayings;
        Random rnd;
        int index;

        public MyForm()
        {
            InitializeComponent();
            index = 0;
            sayings = new ArrayList();
            rnd = new Random();
            sayings.Add("May the Force be with you always");
            sayings.Add("Live Long and Prosper");
            sayings.Add("To Infinity and Beyond");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void revealMessageButton_Click(object sender, EventArgs e)
        {
            String nextMessage = sayings[index] as String;
            messageLabel.Text = nextMessage;
            index = index + 1;
            if (index > 2)
            {
                index = 0;
            }
        }

        private void revealMessageButton_MouseEnter(object sender, EventArgs e)
        {
            int maxWidth  = this.Bounds.Width - revealMessageButton.Bounds.Width;
            int maxHeight = this.Bounds.Height - revealMessageButton.Bounds.Height;
            Point nextPosition = new Point(rnd.Next(maxWidth), rnd.Next(maxHeight));
            revealMessageButton.Location = nextPosition;
        }

    }
}
