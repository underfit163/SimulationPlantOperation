using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grid.Columns.Add("n", "Номер детали");
            grid.Columns.Add("k", "Номер партии");
            grid.Columns.Add("t", "Длительность изготовления");

        }

        private void NormDetails(double t1, double t2, int n, int k)
        {
            Detail detail = new Detail(t1, t2, k, n);
            double T = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double t = detail.RandN();
                    T += t;
                    grid.Rows.Add(j + 1, i + 1, Math.Round(t, 4));
                }
            }
            label6.Text = T.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double t0 = 0.5, t1 = 2;
            int k = 20; int n = 10;

            if (!double.TryParse(textBox1.Text, out t0))
                MessageBox.Show("Задайте другое значение T0");
            else if (!double.TryParse(textBox2.Text, out t1))
                MessageBox.Show("Задайте другое значение T1");
            else
            {
                try
                {
                    NormDetails(t0, t1, n, k);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}
