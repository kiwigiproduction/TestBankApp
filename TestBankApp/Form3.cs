﻿namespace TestBankApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newform = new Form4();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 newform = new Form5();
            newform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
