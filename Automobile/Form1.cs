using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
                label2.Text = "0Km/h";
            }
            else
            {
                button1.BackColor = Color.Green;
                label1.Text = "La macchina è accesa";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (auto.motore == false)
            {
                label3.Text = "La macchina è spenta accendere il motore prima di partire";
            }
            else
            {
                auto.accelleratore();
                label2.Text = auto.tacchimetro + "Km/h";
                label3.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(auto.motore == false)
            {
                label3.Text = "La macchina è spenta accendere il motore prima di partire";
            }
            else
            {
                auto.freno();
                label2.Text = auto.tacchimetro + "Km/h";
                label3.Text = "";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(auto.tacchimetro>=30)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}