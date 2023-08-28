using System;
using System.IO;
using System.Windows.Forms;
using ZXing;

namespace KoftePrinter
{
    public partial class BarcodeForm : MetroFramework.Forms.MetroForm
    {

        BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.QR_CODE };

        public BarcodeForm()
        {
            InitializeComponent();
        }

        private void Encode_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void BarcodeForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            barcode.Image = writer.Write(textBoxCode.Text);
            
        }

        private void barcode_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            writer.Options.Width = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            writer.Options.Height = (int)numericUpDown2.Value;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (barcode.Image == null)
            {
                return;
            }
            using(SaveFileDialog savefile = new SaveFileDialog()
            {
                Filter = "PNG|*.png"
            })
            {
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    barcode.Image.Save(savefile.FileName);
                }
            }
            //printDoc = writer.Write(textBoxCode.Text);
        }
    }
}
