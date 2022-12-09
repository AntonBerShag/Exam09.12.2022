using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam09._12._2022
{
    public partial class Form1 : Form
    {
        private string currentTime;
        private string remainderTime;
        private string remainderText;
        public Form1()
        {
            InitializeComponent();
            timerTime.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now.ToString("HH:mm:ss");
            labelForTime.Text = currentTime;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            remainderTime = maskedTextBoxRemainder.Text;
            remainderText = richTextBoxRemainder.Text;
            MessageBox.Show("Напоминание активировано");

            timerRemainder.Start();
        }

        private void timerRemainder_Tick(object sender, EventArgs e)
        {
            if (currentTime == remainderTime)
            {
                timerRemainder.Stop();
                MessageBox.Show(remainderText);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Напоминание удалено!");
            timerRemainder.Stop();
        }
    }
}
