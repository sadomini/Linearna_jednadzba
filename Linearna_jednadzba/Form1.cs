using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Linearna_jednadzba
{
    public partial class Form1 : Form
    {
        Pravac linearni1;
        Pravac linearni2;
        public Form1()
        {
            InitializeComponent();
            linearni1 = new Pravac();
            linearni2 = new Pravac();
            functionPanel1.Function1 = new DrawingPravac.Function(linearni1.JednadzbaPravca);
            functionPanel1.Function2 = new DrawingPravac.Function(linearni2.JednadzbaPravca);
            functionPanel1.Invalidate();
        }

        public void FillResult()
        {
            linearni1.KoefA = (double)numericUpDown1.Value;
            linearni1.KoefB = (double)numericUpDown2.Value;
            linearni2.KoefA = (double)numericUpDown3.Value;
            linearni2.KoefB = (double)numericUpDown4.Value;
            Pravac.TočkaSjecišta(linearni1, linearni2);
         
            textBox1.Text =linearni1.ToString();
            if (!Pravac.točkaT)
                label6.Text = "Pravci su paralelni ili jednaki!";
            else
                label6.Text = " ";
            functionPanel1.Invalidate();
        }

       

       

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            FillResult();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            FillResult();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            FillResult();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            FillResult();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
