using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ehliyetdurum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int yas;


            yas = Convert.ToInt32(txtYas.Text);

            if (yas < 18)
            {
                lblDurum.Text = "ARABA KULANMAK İÇİN BUYUMEN";
            }

            if (yas >= 18)
            {
                lblDurum.Text = "araba kullanabiıirsin";
            }
        }
    }
}
