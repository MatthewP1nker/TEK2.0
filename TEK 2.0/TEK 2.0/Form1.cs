using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEK_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int balance;
        int min;
        int enet;
        int sms;


        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тариф абсолютный - 300р (300 мин 25 гБ 250 смс) \nТариф эко-тариф - 200р (250 мин 10 гБ 100 смс) \nТариф от Кодзимы - 550р (500 мин 30 гБ 300 смс)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelBalance.Text = balance.ToString();

            if (comboBox3.SelectedIndex == 0)
            {
                if (balance > 300)
                {
                    comboBox3.Enabled = false;
                    balance -= 300;
                    min = 300;
                    enet = 25;
                    sms = 250;
                }
                else
                {
                    MessageBox.Show("НЕДОСТАТОЧНО СРEДСТВ!!!");
                }
            }

            if (comboBox3.SelectedIndex == 1)
            {
                if (balance > 200)
                {
                    balance -= 200;
                    min = 250;
                    enet = 10;
                    sms = 100;
                }
                else
                {
                    MessageBox.Show("НЕДОСТАТОЧНО СРEДСТВ!!!");
                }
            }

            if (comboBox3.SelectedIndex == 2)
            {
                if (balance > 550)
                {
                    balance -= 550;
                    min = 500;
                    enet = 30;
                    sms = 300;
                }
                else
                {
                    MessageBox.Show("НЕДОСТАТОЧНО СРEДСТВ!!!");
                }
            }

             labelMin.Text = min.ToString();
             labelEnternet.Text = enet.ToString();
             labelSMS.Text = sms.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();


            if (min != 0 && enet != 0 && sms != 0)
            {
                timer.Enabled = true;
                min -= random.Next(1, 15 + 1);
                enet -= random.Next(1, 4 + 1);
                sms -= random.Next(1, 20 + 1);
                labelMin.Text = min.ToString();
                labelSMS.Text = sms.ToString();
                labelEnternet.Text = enet.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelBalance.Text = balance.ToString();
            balance += int.Parse(maskedTextBox1.Text);
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString();
        }
    }
}
