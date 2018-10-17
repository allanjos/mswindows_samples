namespace ThermalLabel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.printPreviewControl = new System.Windows.Forms.PrintPreviewControl();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonGenerateBarcode = new System.Windows.Forms.Button();
            this.comboBoxBarcodeType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // printPreviewControl
            // 
            this.printPreviewControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl.AutoZoom = false;
            this.printPreviewControl.Document = this.printDocument;
            this.printPreviewControl.Location = new System.Drawing.Point(8, 51);
            this.printPreviewControl.Name = "printPreviewControl";
            this.printPreviewControl.Size = new System.Drawing.Size(797, 498);
            this.printPreviewControl.TabIndex = 9;
            this.printPreviewControl.Zoom = 0.7D;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(607, 13);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(197, 23);
            this.buttonPrint.TabIndex = 10;
            this.buttonPrint.Text = "Imprimir código de barras";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(12, 13);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(252, 20);
            this.textBoxCode.TabIndex = 11;
            // 
            // buttonGenerateBarcode
            // 
            this.buttonGenerateBarcode.Location = new System.Drawing.Point(442, 13);
            this.buttonGenerateBarcode.Name = "buttonGenerateBarcode";
            this.buttonGenerateBarcode.Size = new System.Drawing.Size(159, 23);
            this.buttonGenerateBarcode.TabIndex = 12;
            this.buttonGenerateBarcode.Text = "Gerar código de barras";
            this.buttonGenerateBarcode.UseVisualStyleBackColor = true;
            this.buttonGenerateBarcode.Click += new System.EventHandler(this.buttonGenerateBarcode_Click);
            // 
            // comboBoxBarcodeType
            // 
            this.comboBoxBarcodeType.FormattingEnabled = true;
            this.comboBoxBarcodeType.Items.AddRange(new object[] {
            "CODE128",
            "QRCODE"});
            this.comboBoxBarcodeType.Location = new System.Drawing.Point(271, 13);
            this.comboBoxBarcodeType.Name = "comboBoxBarcodeType";
            this.comboBoxBarcodeType.Size = new System.Drawing.Size(165, 21);
            this.comboBoxBarcodeType.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 561);
            this.Controls.Add(this.comboBoxBarcodeType);
            this.Controls.Add(this.buttonGenerateBarcode);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.printPreviewControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewControl printPreviewControl;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonGenerateBarcode;
        private System.Windows.Forms.ComboBox comboBoxBarcodeType;
    }
}

