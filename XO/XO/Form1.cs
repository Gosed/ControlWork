using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// Variable of Pressing the button (Was this button pressed or not)
        /// </summary>
        bool B1 = false;
        bool B2 = false;
        bool B3 = false;
        bool B4 = false;
        bool B5 = false;
        bool B6 = false; 
        bool B7 = false;
        bool B8 = false;
        bool B9 = false;
        /// <summary>
        /// True if nobody win
        /// </summary>
        bool NobodyWin = false;
        /// <summary>
        /// Variable which shows who must put now - X or O
        /// </summary>
        bool XorO = false;        

        public Form1()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// Process of ending the game 
        /// </summary>
        /// <returns>true if Game is end</returns>
        public bool EOG()
        {
            if ((this.button1.Text == this.button2.Text) && (this.button2.Text == this.button3.Text) && (this.button3.Text != ""))
                return true;
            if ((this.button4.Text == this.button5.Text) && (this.button5.Text == this.button6.Text) && (this.button6.Text != ""))
                return true;
            if ((this.button7.Text == this.button8.Text) && (this.button8.Text == this.button9.Text) && (this.button9.Text != ""))
                return true;
            if ((this.button1.Text == this.button4.Text) && (this.button4.Text == this.button7.Text) && (this.button7.Text != ""))
                return true;
            if ((this.button2.Text == this.button5.Text) && (this.button5.Text == this.button8.Text) && (this.button8.Text != ""))
                return true;
            if ((this.button3.Text == this.button6.Text) && (this.button6.Text == this.button9.Text) && (this.button9.Text != ""))
                return true;
            if ((this.button1.Text == this.button5.Text) && (this.button5.Text == this.button9.Text) && (this.button9.Text != ""))
                return true;
            if ((this.button3.Text == this.button5.Text) && (this.button5.Text == this.button7.Text) && (this.button7.Text != ""))
                return true;
            if ((B1 == B2) && (B2 == B3) && (B3 == B4) && (B4 == B5) && (B5 == B6) && (B6 == B7) && (B7 == B8) && (B8 == B9) && (B1 == true))
            {
                NobodyWin = true;
                return true;
            }
            NobodyWin = false;
            return false;
        }

        /// <summary>
        /// Print who is winner
        /// </summary>
        /// <param name="i">Name of winner - X or O or nobody</param>

        public void PrintWin(string i)
        {
            B1 = true;
            B2 = true;
            B3 = true;
            B4 = true;
            B5 = true;
            B6 = true;
            B7 = true; 
            B8 = true;
            B9 = true;
            this.button1.Text = "";
            this.button2.Text = i;
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "W";
            this.button8.Text = "I"; 
            this.button9.Text = "N";

        }

        /// <summary>
        /// Button1 click process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!B1)
            {
                if (!XorO)
                {
                    this.button1.Text = "X";
                    XorO = !XorO;
                }
                else
                {
                    this.button1.Text = "O";
                    XorO = !XorO;
                }
                B1 = true;
                if (EOG())
                {
                    if (!XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
                if (EOG())
                {
                    if (XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
            }

        }

        /// <summary>
        /// Button2 click process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (!B2)
            {
                if (!XorO)
                {
                    this.button2.Text = "X";
                    XorO = !XorO;
                }
                else
                {
                    this.button2.Text = "O";
                    XorO = !XorO;
                }
                B2 = true;
                if (EOG())
                {
                    if (!XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
                if (EOG())
                {
                    if (XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
            }

        }

        /// <summary>
        /// Button3 click process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (!B3)
            {
                if (!XorO)
                {
                    this.button3.Text = "X";
                    XorO = !XorO;
                }
                else
                {
                    this.button3.Text = "O";
                    XorO = !XorO;
                }
                B3 = true;
                if (EOG())
                {
                    if (!XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
                if (EOG())
                {
                    if (XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
            }
        }

        /// <summary>
        /// Button4 click process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (!B4)
            {
                if (!XorO)
                {
                    this.button4.Text = "X";
                    XorO = !XorO;
                }
                else
                {
                    this.button4.Text = "O";
                    XorO = !XorO;
                }
                B4 = true;
                if (EOG())
                {
                    if (!XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
                if (EOG())
                {
                    if (XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
            }
        }

        /// <summary>
        /// Button5 click process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (!B5)
            {
                if (!XorO)
                {
                    this.button5.Text = "X";
                    XorO = !XorO;
                }
                else
                {
                    this.button5.Text = "O";
                    XorO = !XorO;
                }
                B5 = true;
                if (EOG())
                {
                    if (!XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
                if (EOG())
                {
                    if (XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
            }
        }
        
        /// <summary>
        /// Button6 click process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button6_Click(object sender, EventArgs e)
        {
            if (!B6)
            {
                if (!XorO)
                {
                    this.button6.Text = "X";
                    XorO = !XorO;
                }
                else
                {
                    this.button6.Text = "O";
                    XorO = !XorO;
                }
                B6 = true;
                if (EOG())
                {
                    if (!XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
                if (EOG())
                {
                    if (XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
            }
        }

        /// <summary>
        /// Button7 click process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button7_Click(object sender, EventArgs e)
        {
            if (!B7)
            {
                if (!XorO)
                {
                    this.button7.Text = "X";
                    XorO = !XorO;
                }
                else
                {
                    this.button7.Text = "O";
                    XorO = !XorO;
                }
                B7 = true;
                if (EOG())
                {
                    if (!XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
                if (EOG())
                {
                    if (XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
            }
        }

        /// <summary>
        /// Button8 click process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button8_Click(object sender, EventArgs e)
        {
            if (!B8)
            {
                if (!XorO)
                {
                    this.button8.Text = "X";
                    XorO = !XorO;
                }
                else
                {
                    this.button8.Text = "O";
                    XorO = !XorO;
                }
                B8 = true;
                if (EOG())
                {
                    if (!XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
                if (EOG())
                {
                    if (XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
            }
        }

        /// <summary>
        /// Button9 click process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button9_Click(object sender, EventArgs e)
        {
            if (!B9)
            {
                if (!XorO)
                {
                    this.button9.Text = "X";
                    XorO = !XorO;
                }
                else
                {
                    this.button9.Text = "O";
                    XorO = !XorO;
                }
                B9 = true;
                if (EOG())
                {
                    if (XorO)
                        PrintWin("X");
                    else
                        PrintWin("O");
                }
            }
        }
    }
}
