using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics10Edi
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
        private void btnAvr_Click(object sender, EventArgs e)
        {
            List<double> list = txtNum.Text.Split(' ').Select(l => double.Parse(l)).ToList();

            var avarage = list.Average();

            lblAvr.Text = ("Avarage: " + avarage);
        }
    }
}
