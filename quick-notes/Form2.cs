using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quick_notes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font tipotexto = new Font("Arial", 10, FontStyle.Bold);
            String div = "__________________________________";
            DateTime date = DateTime.Now;
            Graphics graphics = e.Graphics;
            printDocument1.DefaultPageSettings.Landscape = true;
            e.Graphics.DrawString(comboBox1.Text, tipotexto, Brushes.Black, 15, 0);
            e.Graphics.DrawString(div, tipotexto, Brushes.Black, 15, 20);
            e.Graphics.DrawString(comboBox2.Text, tipotexto, Brushes.Black, 15, 40);
            e.Graphics.DrawString(date.ToString(), tipotexto, Brushes.Black, 15, 60);



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            printDialog1.ShowDialog();
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
    
}
