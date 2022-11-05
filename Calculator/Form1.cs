using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
<<<<<<< HEAD
            if (txtA.Text !=String.Empty)
=======
            if (txtA.Text !=string.Empty && txtB.Text!=String.Empty)
>>>>>>> feature-cal
            {
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);
                ketQua = a + b;
<<<<<<< HEAD
                txtKetQua.Text = ketQua.ToString();

=======
                txtKetQua.Text = ketQua.ToString(); 
>>>>>>> feature-cal
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            ketQua = a - b;
            txtKetQua.Text = ketQua.ToString();
        }
    }
}
