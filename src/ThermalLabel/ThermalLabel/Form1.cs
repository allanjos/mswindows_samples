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

            comboBoxOrientation.SelectedIndex = 0;
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

            int width = Int32.Parse(textBoxBarcodeWidth.Text);
            int height = Int32.Parse(textBoxBarcodeHeight.Text);

            IBarcodeWriter writer = new BarcodeWriter
            {
                Format = barcodeFormat,
                Options = new QrCodeEncodingOptions
                {
                    Width = width,
                    Height = height,
                }
            };

            if (textBoxCode.Text.Length > 0)
            {
                Image image = writer.Write(textBoxCode.Text);

                switch (comboBoxOrientation.SelectedIndex)
                {
                    // Portrait
                    case 1:
                        image.RotateFlip(RotateFlipType.Rotate90FlipXY);
                        break;
                }

                graphics.DrawImage(image, new Point(0, 0));
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void buttonGenerateBarcode_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text.Length == 0)
            {
                toolStripStatusLabel.Text = "Inform a the code of barcode.";
                return;
            }

            if (textBoxBarcodeWidth.Text.Length == 0 || Int32.Parse(textBoxBarcodeWidth.Text) == 0)
            {
                toolStripStatusLabel.Text = "Inform a positive value for barcode width.";
                return;
            }

            if (textBoxBarcodeHeight.Text.Length == 0 || Int32.Parse(textBoxBarcodeHeight.Text) == 0)
            {
                toolStripStatusLabel.Text = "Inform a positive value for barcode height.";
                return;
            }

            toolStripStatusLabel.Text = "";

            printPreviewControl.InvalidatePreview();
        }

        private void textBoxBarcodeHeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
