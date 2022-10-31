﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsKiwiApp.Picture;
namespace WindowsFormsKiwiApp
{
    public partial class KiwiForm : Form
    {
       Picture[] pictures = new Picture[5];
       public int kiwiCount = 0;
        public KiwiForm()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Random drawPic = new Random();

            //lbl_result.Text = pictures[0].IsKiwi.ToString() + pictures[1].IsKiwi.ToString();
            lbl_result.Text = "";

            // display the labels
            for (int i = 0; i < pictures.Length; i++)
            {
                lbl_result.Text += pictures[i].IsKiwi + ", ";
                pictures[i].checkKiwi(drawPic);
                if (pictures[i].IsKiwi == true)
                {

                    // Ternary operator -->
                    // CONDITION ? DO IF TRUE : DO IF FALSE
                    // isCloudy ==? bringUmbrella() : bringSunglass()

                    pictureBox1.Image = pictures[0].IsKiwi ? Properties.Resources.kiwi_bird : Properties.Resources.pukeko;
                    pictureBox2.Image = pictures[1].IsKiwi ? Properties.Resources.kiwi_bird : Properties.Resources.pukeko;
                    pictureBox3.Image = pictures[2].IsKiwi ? Properties.Resources.kiwi_bird : Properties.Resources.pukeko;
                    pictureBox4.Image = pictures[3].IsKiwi ? Properties.Resources.kiwi_bird : Properties.Resources.pukeko;
                    pictureBox5.Image = pictures[4].IsKiwi ? Properties.Resources.kiwi_bird : Properties.Resources.pukeko;

                    int kiwiTotal = kiwiCount + 1;
                    lbl_total.Text = kiwiTotal.ToString();
                }
            }


        }

        private void KiwiForm_Load(object sender, EventArgs e)
        {

            //pictures[0] = new Picture(true);
            //pictures[1] = new Picture(false);
            //pictures[2] = new Picture(true);
            //pictures[3] = new Picture(true);
            //pictures[4] = new Picture(true);
            for (int i = 0; i < pictures.Length; i++)
            {
                pictures[i] = new Picture(false);
            }
        }
    }
}
