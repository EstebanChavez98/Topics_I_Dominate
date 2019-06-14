using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacks_Example
{
    public partial class Form1 : Form
    {
        Stack obj = new Stack();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtMax.Text);
            obj = new Stack(m);
            MessageBox.Show("Stack created");
        }

        private void BtnPush_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtNum.Text);
            obj.push(n);
            txtNum.Clear();
            txtNum.Focus();
        }

        private void BtnPop_Click(object sender, EventArgs e)
        {
            int n;
            n = obj.pop();
            MessageBox.Show("Salio: "+n);
        }
    }
}
