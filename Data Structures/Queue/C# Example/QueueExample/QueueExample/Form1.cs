using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueExample
{
    public partial class Form1 : Form
    {
        Queue x = new Queue(); //Invoke the class
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtMax.Text);
            x = new Queue(n);
            MessageBox.Show("Queue created");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtNum.Text);
            x.addQueue(n);
            MessageBox.Show("Value added");
            txtNum.Clear();
            txtNum.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int n;
            n = x.deleteQueue();
            if (n == -666)
            {
                MessageBox.Show("No value");
            }
            else
            {
                MessageBox.Show(n + "got out");
            }
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
