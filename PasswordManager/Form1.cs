using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //button1 += 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutApp about = new AboutApp();
            about.Show();
        }

        private void sideMenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
