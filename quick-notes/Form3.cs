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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 446, 730);
            printDocument1.PrinterSettings.DefaultPageSettings.PaperSize = printDocument1.DefaultPageSettings.PaperSize;
            Font asunto = new Font("Arial", 12, FontStyle.Bold);
            Font info = new Font("Arial", 10, FontStyle.Bold);
            String div = "__________________________________";
            DateTime date = DateTime.Now;
            Graphics graphics = e.Graphics;
            printDocument1.DefaultPageSettings.Landscape = true;
            e.Graphics.DrawString("GARANTÍA", asunto, Brushes.Black, 80, 0);
            e.Graphics.DrawString("Folio/Pos: "+textBox1.Text, asunto, Brushes.Black, 0, 20);
            e.Graphics.DrawString("Cliente: " + textBox2.Text, info, Brushes.Black, 0, 40);
            e.Graphics.DrawString("Producto: " + textBox3.Text, info, Brushes.Black, 0, 60);
            e.Graphics.DrawString(div, info, Brushes.Black, 0, 80);
            e.Graphics.DrawString(comboBox1.Text, info, Brushes.Black, 0, 100);
            e.Graphics.DrawString(date.ToString(), info, Brushes.Black, 0, 120);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings.Landscape = false;
                printDocument1.Print();
            }
        }
    }
}
