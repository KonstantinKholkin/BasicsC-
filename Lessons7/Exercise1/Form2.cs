using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            switch (Form1.vict)
            {
                case Form1.Victory.Gold:
                   
                    label1.Text += "\nПоздравляю!! Вы выйграли!!!\n" +
                                        "Вы использовали всего " + Form1.myCountCommand.ToString() + " команд!";
                    break;
                case Form1.Victory.Silver:
                    
                    label1.Text += "\nНеплохо, неплохо... \n" +
                                                "Вы использовали  " + Form1.myCountCommand.ToString() + " команд.";
                    break;
                case Form1.Victory.Copper:
                    
                    label1.Text += "\nМммм да... \n" +
                                                "Вы использовали  " + Form1.myCountCommand.ToString() + " команд.";
                    break;
            }
        }

        
    }
}
