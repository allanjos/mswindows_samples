using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace ThermalLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            comboBoxBarcodeType.SelectedIndex = 0;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Debug.WriteLine("printDocument_PrintPage()");

            Graphics graphics = e.Graphics;

            BarcodeFormat barcodeFormat = BarcodeFormat.CODE_128;

            switch (comboBoxBarcodeType.SelectedIndex)
            {
                case 0:
                    barcodeFormat = BarcodeFormat.CODE_128;
                    break;
                case 1:
                    barcodeFormat = BarcodeFormat.QR_CODE;
                    break;
            }

            IBarcodeWriter writer = new BarcodeWriter
            {
                Format = barcodeFormat,
                Options = new QrCodeEncodingOptions
                {
                    Width = 400, //pictureBox.Width,
                    Height = 200, //pictureBox.Height
                }
            };

            //Image image = writer.Write("0600001000900000000MC17509TX0001");
            if (textBoxCode.Text.Length > 0)
            {
                Image image = writer.Write(textBoxCode.Text);

                image.RotateFlip(RotateFlipType.Rotate90FlipXY);

                graphics.DrawImage(image, new Point(0, 0));

                //pictureBox.Image = writer.Write("0600001000900000000MC17509TX0001");
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void buttonGenerateBarcode_Click(object sender, EventArgs e)
        {
            printPreviewControl.InvalidatePreview();
        }
    }
}
