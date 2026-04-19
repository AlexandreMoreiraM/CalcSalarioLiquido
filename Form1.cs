using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandre_SalarioLiquido
{
    public partial class SalarioLiquido : Form
    {
        public SalarioLiquido()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Ht, Vh, Sb, Pd, Td, Sl;
            Ht = Convert.ToDouble(textBox1.Text);
            Vh = Convert.ToDouble(textBox4.Text);
            Pd = Convert.ToDouble(textBox2.Text);

            Sb = Ht * Vh;
            Td = (Pd / 100) * Sb;
            Sl = Sb - Td;
            label4.Text = Sb.ToString();
            label11.Text = Sl.ToString();
            label7.Text = Td.ToString();
            label4.Text = Sb.ToString("F2");
            label11.Text = Sl.ToString("F2");
            label7.Text = Td.ToString("F2");

            //  Comandos para colocar em duas casas decimais

            //      label1.Text = Math.Round(SL, 2).ToString();
            //      label1.Text = Sl.ToString("C");
            //      label1.Text - Sl.ToString("0.00");
        }

        private void SalarioLiquido_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            label4.Text = " ";
            label11.Text = " ";
            label7.Text = " ";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
