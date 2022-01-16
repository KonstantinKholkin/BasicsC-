﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private int mNumber = 0;
        private int myNumber = 1;
        public static int myCountCommand = 0;
        private int level = 1;
        private List<bool> listOperation = new List<bool>(30);
        public static Victory vict;

        public enum Victory
        {
            Gold,
            Silver,
            Copper
        }
        public Form1()
        {
            InitializeComponent();
            this.Width = 391;
            mNumber = rand.Next(2, 50);
        }
        private int countCommand(int num)
        {
            int temp = num;
            int countCom = 0;
            for (; temp != 1;)
            {
                if (temp % 2 == 0)
                    temp /= 2;
                else temp -= 1;

                countCom++;
            }
            return countCom;
        }

        private void Finish()
        {
            int countCom = Convert.ToInt32(labelCommand.Text);
            if (myNumber == mNumber)
            {
                if (myCountCommand <= countCom) vict = Victory.Gold;
                if (myCountCommand > countCom) vict = Victory.Silver;
                if (myCountCommand >= (countCom + 4)) vict = Victory.Copper;
                Form2 form = new Form2();
                form.Show();
            }
        }
        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butSum1_Click(object sender, EventArgs e)
        {
            listOperation.Add(true);
            myNumber++;
            myCountCommand++;
            labelMyCommand.Text = myCountCommand.ToString();
            labelMyNum.Text = myNumber.ToString();

            Finish();
        }

        private void butMult2_Click(object sender, EventArgs e)
        {
            listOperation.Add(false);
            myNumber *= 2;
            myCountCommand++;
            labelMyCommand.Text = myCountCommand.ToString();
            labelMyNum.Text = myNumber.ToString();

            Finish();
        }

        private void butPlay_Click(object sender, EventArgs e)
        {
            panelGame.Left = 0;
            labelNum.Text = mNumber.ToString();
            labelCommand.Text = countCommand(mNumber).ToString();
        }

        private void labelNum_Click(object sender, EventArgs e)
        {

            if (listOperation.Count != 0)
            {
                if (listOperation[listOperation.Count - 1])
                    myNumber--;
                else myNumber /= 2;
                listOperation.RemoveAt(listOperation.Count - 1);
                labelMyNum.Text = myNumber.ToString();
                myCountCommand--;
                labelMyCommand.Text = myCountCommand.ToString();
            }
        }

        private void labelCommand_Click(object sender, EventArgs e)
        {

        }

        private void butBack_Click(object sender, EventArgs e)
        {
            if (listOperation.Count != 0)
            {
                if (listOperation[listOperation.Count - 1])
                    myNumber--;
                else myNumber /= 2;
                listOperation.RemoveAt(listOperation.Count - 1);
                labelMyNum.Text = myNumber.ToString();
                myCountCommand--;
                labelMyCommand.Text = myCountCommand.ToString();
            }
        }

        private void butMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверенны что хотите выйти в меню?\n" +
                                            "Все результаты будут сброшены!", "Набери число",
                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                panelGame.Left = 300;
                switch (level)
                {
                    case 1:
                        mNumber = rand.Next(2, 50);
                        break;
                    case 2:
                        mNumber = rand.Next(50, 150);
                        break;
                    case 3:
                        mNumber = rand.Next(150, 500);
                        break;
                }
                myNumber = 1;
                labelMyNum.Text = "1";
                myCountCommand = 0;
                labelMyCommand.Text = "0";
            }
        }

        private void labelMyNum_Click(object sender, EventArgs e)
        {

        }

        private void labelMyCommand_Click(object sender, EventArgs e)
        {

        }
    }
}