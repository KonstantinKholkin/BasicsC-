using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exercise2
{
    public partial class Form1 : Form
    {
        private Random rand = new Random(); 
        private int number; 
        private int countTry = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void tBoxMyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!Char.IsDigit(e.KeyChar) && (!Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            else
            {
                
                butTry.Enabled = true;
            }
        }
        private void tBoxMyNumber_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void butTry_Click(object sender, EventArgs e)
        {
            butTry.Enabled = false; 
            int inputNumber = Convert.ToInt32(tBoxMyNumber.Text);
            
            if (inputNumber > 100)
            {
                MessageBox.Show("Вы ввели больше значение чем можно. Введите другое",
                    "Угадай число", MessageBoxButtons.OK);
                tBoxMyNumber.Text = "";
            }
            else
            {
                labelCountTry.Text = "Сделано попыток: " + (++countTry).ToString(); 
                if (inputNumber > number)  
                    labelMoreLess.Text = "Ваше число больше";
                else if (inputNumber < number) 
                    labelMoreLess.Text = "Ваше число меньше"; 
                else 
                {
                    MessageBox.Show("          Поздравляем!   \n" +
                                                 "Вы угадали число за " + countTry.ToString() + " попыток"
                                                 , "Угадай число",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tBoxMyNumber.Text = ""; 
                    labelMoreLess.Text = "";
                    countTry = 0; 
                    labelCountTry.Text = "Сделано попыток: 0"; 
                    labelCountTry.Enabled = false; 
                    tBoxMyNumber.Enabled = false; 
                    butPlayRestart.Text = "Играть"; 

                }
            }
        }

        private void butPlayRestart_Click(object sender, EventArgs e)
        {
            if (butPlayRestart.Text == "Играть")
            {
                number = rand.Next(100); 
                butPlayRestart.Text = "Переиграть";
                labelCountTry.Enabled = true; 
                tBoxMyNumber.Enabled = true; 
                labelMoreLess.Text = ""; 
            }
            else 
            {
                number = rand.Next(100); 
                countTry = 0; 
                labelCountTry.Text = "Сделано попыток: 0"; 
                tBoxMyNumber.Text = ""; 
                butTry.Enabled = false; 
                labelMoreLess.Text = ""; 
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
