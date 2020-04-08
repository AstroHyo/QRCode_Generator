using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessRefinery.Barcode;

namespace QRCode_Generator
{
    public partial class Form1 : Form
    {
        string url;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            url = textBox1.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            QRCode barcode = new QRCode();
            barcode.Code = url;
            barcode.ModuleSize = 6.0f;
            barcode.Resolution = 300;
            barcode.drawBarcode2ImageFile("Temp.png");
            MessageBox.Show("실행 완료!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}