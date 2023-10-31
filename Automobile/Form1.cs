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
        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(auto.cambio);
            if (label5.Text == "0")
            {
                label5.Text = "N";
            }
            else if (label5.Text == "7")
            {
                label5.Text = "R";
            }
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
                if (auto.frizione == false)
                {
                    label3.Text = "Togliere la frizioe per accellerare";
                }
                else
                {
                    if (auto.cambio == 0)
                    {
                        label3.Text = "Togliere la folle per partire";
                    }
                    else if (auto.cambio == 1)
                    {
                        if (auto.tacchimetro >= 20)
                        {
                            label3.Text = "cambiare marcia per accellerare ulteriormente";
                        }
                        else if (auto.cambio == 2)
                        {
                            if (auto.tacchimetro >= 40)
                            {
                                label3.Text = "cambiare marcia per accellerare ulteriormente";
                            }
                            else if (auto.cambio == 3)
                            {
                                if (auto.tacchimetro >= 60)
                                {
                                    label3.Text = "cambiare marcia per accellerare ulteriormente";
                                }
                                else if (auto.cambio == 4)
                                {
                                    if (auto.tacchimetro >= 90)
                                    {
                                        label3.Text = "cambiare marcia per accellerare ulteriormente";
                                    }
                                    else if (auto.cambio == 5)
                                    {
                                        if (auto.tacchimetro >= 120)
                                        {
                                            label3.Text = "cambiare marcia per accellerare ulteriormente";
                                        }
                                        else if (auto.cambio == 6)
                                        {
                                            if (auto.tacchimetro >= 150)
                                            {
                                                label3.Text = "velocità massima";
                                            }
                                            else if (auto.cambio == 7)
                                            {
                                                if (auto.cambio != 0)
                                                {
                                                    label3.Text = "Mettere in folle per andare in retro";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }


                    auto.accelleratore();
                    label2.Text = auto.tacchimetro + "Km/h";
                    label3.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (auto.motore == false)
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
            if (auto.frizione == false)
            {
                label3.Text = "Premere la frizione per cambiare marcia";
            }
            else if (auto.tacchimetro == 0)
            {
                auto.cambio = 1;
                label5.Text = Convert.ToString(auto.cambio);
                if (label5.Text == "0")
                {
                    label5.Text = "N";
                }
                else if (label5.Text == "7")
                {
                    label5.Text = "R";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (auto.frizione == false)
            {
                label3.Text = "Premere la frizione per cambiare marcia";
            }
            else if (auto.tacchimetro == 20)
            {
                auto.cambio = 2;
                label5.Text = Convert.ToString(auto.cambio);
                if (label5.Text == "0")
                {
                    label5.Text = "N";
                }
                else if (label5.Text == "7")
                {
                    label5.Text = "R";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (auto.frizione == false)
            {
                label3.Text = "Premere la frizione per cambiare marcia";
            }
            else if (auto.tacchimetro == 40)
            {
                auto.cambio = 3;
                label5.Text = Convert.ToString(auto.cambio);
                if (label5.Text == "0")
                {
                    label5.Text = "N";
                }
                else if (label5.Text == "7")
                {
                    label5.Text = "R";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (auto.frizione == false)
            {
                label3.Text = "Premere la frizione per cambiare marcia";
            }
            else if (auto.tacchimetro == 60)
            {
                auto.cambio = 4;
                label5.Text = Convert.ToString(auto.cambio);
                if (label5.Text == "0")
                {
                    label5.Text = "N";
                }
                else if (label5.Text == "7")
                {
                    label5.Text = "R";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (auto.frizione == false)
            {
                label3.Text = "Premere la frizione per cambiare marcia";
            }
            else if (auto.tacchimetro == 90)
            {
                auto.cambio = 5;
                label5.Text = Convert.ToString(auto.cambio);
                if (label5.Text == "0")
                {
                    label5.Text = "N";
                }
                else if (label5.Text == "7")
                {
                    label5.Text = "R";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (auto.frizione == false)
            {
                label3.Text = "Premere la frizione per cambiare marcia";
            }
            else if (auto.tacchimetro == 120)
            {
                auto.cambio = 6;
                label5.Text = Convert.ToString(auto.cambio);
                if (label5.Text == "0")
                {
                    label5.Text = "N";
                }
                else if (label5.Text == "7")
                {
                    label5.Text = "R";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (auto.frizione == false)
            {
                label3.Text = "Premere la frizione per cambiare marcia";
            }
            else if (auto.tacchimetro == 150)
            {
                auto.cambio = 1;
                label5.Text = Convert.ToString(auto.cambio);
                if (label5.Text == "0")
                {
                    label5.Text = "N";
                }
                else if (label5.Text == "7")
                {
                    label5.Text = "R";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (auto.frizione == false)
            {
                auto.frizione = true;
            }
            else
            {
                auto.frizione = false;
            }
        }
        #endregion

    }
}