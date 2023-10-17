﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class Form1 : Form
    {
        Auto auto;
        public Form1()
        {
            InitializeComponent();
            auto = new Auto();
        }

        #region Form
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region label
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = auto.tacchimetro + "Km/h";
        }
        #endregion

        #region Button
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            auto.accensione();
            if (auto.motore == false)
            {
                button1.BackColor = Color.Red;
                label1.Text = "La macchina è spenta";
            }
            else
            {
                button1.BackColor = Color.Green;
                label1.Text = "La macchina è accesa";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            auto.accelleratore();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            auto.freno();
        }
        #endregion

    }
}