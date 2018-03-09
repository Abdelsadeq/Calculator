using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_div
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcDiv_Click(object sender, EventArgs e)
        {
            bool test = true;
            try
            {
                short n1, n2, n3;
                n1 = Convert.ToInt16(txtNum1.Text);
                n2 = Convert.ToInt16(txtNum2.Text);
                n3 = Convert.ToInt16(n1 / n2);
                txtDiv.Text = n3.ToString();
            }
            catch (Exception ex)
            {
                test = false;
                MessageBox.Show(ex.ToString());

            }
            if (test)
            { txtDiv.BackColor = Color.Red; }
            MessageBox.Show("hello ");
        }
    }
}
