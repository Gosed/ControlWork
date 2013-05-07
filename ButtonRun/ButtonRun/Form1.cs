using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ButtonRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Works if cursor moves on button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (((MousePosition.X - Left) <= 100) && ((Control.MousePosition.Y - Top) <= 100))
            /// if button in the left top corner, it will be moved to the random place on the  form(also it can't be moved to the place, which both coordinats fewer than 100)
            {
                Random rnd = new Random();
                int x = rnd.Next(100, 230);
                int y = rnd.Next(100, 230); ;
                button1.Left = x;
                button1.Top = y;
                button1.Text = "NOOB!!!";
            }
            else
            ///in the other case button will be moved to the left top corner
            {
                button1.Left = 0;
                button1.Top = 0;
                button1.Text = "LOL!!!";
            }
        }

        /// <summary>
        /// Works on button Click - in that case programm will be closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
