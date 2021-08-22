using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XorO
{

    public partial class Form1 : Form
    {
        public bool push = true;
        public int pushCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btA1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (push)
            {
                bt.Text = "X";
                bt.ForeColor = Color.Red;
            }
            else
            {
                bt.Text = "O";
                bt.ForeColor = Color.DarkBlue;
            }
            push = !push;
            bt.Enabled = false;
            pushCount++;
            CheckWinner();
        }

        private void CheckWinner()
        {
            if (btA1.Text == "X" && btA2.Text == "X" && btA3.Text == "X")
            {
                StartNewGame();
                label6.Text = (int.Parse(label6.Text) + 1).ToString();
            }
            else if(btA1.Text == "X" && btB2.Text == "X" && btC3.Text == "X")
            {
                StartNewGame();
                label6.Text = (int.Parse(label6.Text) + 1).ToString();
            }
            else if(btC1.Text == "X" && btB2.Text == "X" && btA3.Text == "X")
            {
                StartNewGame();
                label6.Text = (int.Parse(label6.Text) + 1).ToString();
            }
            else if(btC1.Text == "X" && btC2.Text == "X" && btC3.Text == "X")
            {
                StartNewGame();
                label6.Text = (int.Parse(label6.Text) + 1).ToString();
            }
            else if(btC1.Text == "X" && btB1.Text == "X" && btA1.Text == "X")
            {
                StartNewGame();
                label6.Text = (int.Parse(label6.Text) + 1).ToString();
            }
            else if(btC3.Text == "X" && btB3.Text == "X" && btA3.Text == "X")
            {
                StartNewGame();
                label6.Text = (int.Parse(label6.Text) + 1).ToString();
            }
            else if(btB1.Text == "X" && btB2.Text == "X" && btB3.Text == "X")
            {
                StartNewGame();
                label6.Text = (int.Parse(label6.Text) + 1).ToString();
            }
            if (btA1.Text == "O" && btA2.Text == "O" && btA3.Text == "O")
            {
                StartNewGame();
                label5.Text = (int.Parse(label5.Text) + 1).ToString();
            }
            else if (btA1.Text == "O" && btB2.Text == "O" && btC3.Text == "O")
            {
                StartNewGame();
                label5.Text = (int.Parse(label5.Text) + 1).ToString();
            }
            else if (btC1.Text == "O" && btB2.Text == "O" && btA3.Text == "O")
            {
                StartNewGame();
                label5.Text = (int.Parse(label5.Text) + 1).ToString();
            }
            else if (btC1.Text == "O" && btC2.Text == "O" && btC3.Text == "O")
            {
                StartNewGame();
                label5.Text = (int.Parse(label5.Text) + 1).ToString();
            }
            else if (btC1.Text == "O" && btB1.Text == "O" && btA1.Text == "O")
            {
                StartNewGame();
                label5.Text = (int.Parse(label5.Text) + 1).ToString();
            }
            else if (btC3.Text == "O" && btB3.Text == "O" && btA3.Text == "O")
            {
                StartNewGame();
                label5.Text = (int.Parse(label5.Text) + 1).ToString();
            }
            else if (btB1.Text == "O" && btB2.Text == "O" && btB3.Text == "O")
            {
                StartNewGame();
                label5.Text = (int.Parse(label5.Text) + 1).ToString();
            }
            if (pushCount == 9)
            {
                MessageBox.Show("We don't have any winner", "XorO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StartNewGame();
                label4.Text = (int.Parse(label4.Text) + 1).ToString();
            }
            if (label6.Text == "3" || label5.Text == "3")
            {
                label6.Text = "0";
                label5.Text = "0";
                label4.Text = "0";
            }
        }

        private void StartNewGame()
        {
            pushCount = 0;
            push = true;

            foreach (Control item in Controls)
            {
                try
                {
                    Button bt = (Button)item;
                    bt.Enabled = true;
                    bt.Text = "";
                }
                catch
                {

                }
            }
        }
        private void btA1_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (bt.Enabled)
            {
                bt.Text = "";
            }
        }
        private void btA1_MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Enabled)
            {
                if (push)
                {
                    bt.Text = "X";
                    bt.ForeColor = Color.Red;
                }
                else
                {
                    bt.Text = "O";
                    bt.ForeColor = Color.DarkBlue;
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program created Albert Hakobyan For Azniv Mheryan with love");
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            string message = "Are you sure to Exit";
            string caption = "Exiit";
            if(MessageBox.Show(message,caption,msb) == DialogResult.Yes)
            this.Close();
        }
    }
}