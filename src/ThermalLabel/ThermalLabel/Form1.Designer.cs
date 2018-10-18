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
            this.comboBoxOrientation = new System.Windows.Forms.ComboBox();
            this.labelOrientation = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBarcodeWidth = new System.Windows.Forms.TextBox();
            this.textBoxBarcodeHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewControl
            // 
            this.printPreviewControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl.AutoZoom = false;
            this.printPreviewControl.Document = this.printDocument;
            this.printPreviewControl.Location = new System.Drawing.Point(8, 72);
            this.printPreviewControl.Name = "printPreviewControl";
            this.printPreviewControl.Size = new System.Drawing.Size(797, 464);
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
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.Location = new System.Drawing.Point(630, 39);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(175, 23);
            this.buttonPrint.TabIndex = 10;
            this.buttonPrint.Text = "Print barcode";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCode.Location = new System.Drawing.Point(80, 10);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(544, 20);
            this.textBoxCode.TabIndex = 11;
            // 
            // buttonGenerateBarcode
            // 
            this.buttonGenerateBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateBarcode.Location = new System.Drawing.Point(630, 10);
            this.buttonGenerateBarcode.Name = "buttonGenerateBarcode";
            this.buttonGenerateBarcode.Size = new System.Drawing.Size(175, 23);
            this.buttonGenerateBarcode.TabIndex = 12;
            this.buttonGenerateBarcode.Text = "Generate barcode";
            this.buttonGenerateBarcode.UseVisualStyleBackColor = true;
            this.buttonGenerateBarcode.Click += new System.EventHandler(this.buttonGenerateBarcode_Click);
            // 
            // comboBoxBarcodeType
            // 
            this.comboBoxBarcodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBarcodeType.FormattingEnabled = true;
            this.comboBoxBarcodeType.Items.AddRange(new object[] {
            "CODE128",
            "QRCODE"});
            this.comboBoxBarcodeType.Location = new System.Drawing.Point(291, 38);
            this.comboBoxBarcodeType.Name = "comboBoxBarcodeType";
            this.comboBoxBarcodeType.Size = new System.Drawing.Size(165, 21);
            this.comboBoxBarcodeType.TabIndex = 13;
            // 
            // comboBoxOrientation
            // 
            this.comboBoxOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrientation.FormattingEnabled = true;
            this.comboBoxOrientation.Items.AddRange(new object[] {
            "Landscape",
            "Portrait"});
            this.comboBoxOrientation.Location = new System.Drawing.Point(80, 38);
            this.comboBoxOrientation.Name = "comboBoxOrientation";
            this.comboBoxOrientation.Size = new System.Drawing.Size(165, 21);
            this.comboBoxOrientation.TabIndex = 13;
            // 
            // labelOrientation
            // 
            this.labelOrientation.AutoSize = true;
            this.labelOrientation.Location = new System.Drawing.Point(13, 41);
            this.labelOrientation.Name = "labelOrientation";
            this.labelOrientation.Size = new System.Drawing.Size(61, 13);
            this.labelOrientation.TabIndex = 14;
            this.labelOrientation.Text = "Orientation:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(251, 41);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(34, 13);
            this.labelType.TabIndex = 14;
            this.labelType.Text = "Type:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(817, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Size:";
            // 
            // textBoxBarcodeWidth
            // 
            this.textBoxBarcodeWidth.Location = new System.Drawing.Point(499, 41);
            this.textBoxBarcodeWidth.Name = "textBoxBarcodeWidth";
            this.textBoxBarcodeWidth.Size = new System.Drawing.Size(36, 20);
            this.textBoxBarcodeWidth.TabIndex = 16;
            this.textBoxBarcodeWidth.Text = "400";
            // 
            // textBoxBarcodeHeight
            // 
            this.textBoxBarcodeHeight.Location = new System.Drawing.Point(556, 41);
            this.textBoxBarcodeHeight.Name = "textBoxBarcodeHeight";
            this.textBoxBarcodeHeight.Size = new System.Drawing.Size(36, 20);
            this.textBoxBarcodeHeight.TabIndex = 16;
            this.textBoxBarcodeHeight.Text = "200";
            this.textBoxBarcodeHeight.TextChanged += new System.EventHandler(this.textBoxBarcodeHeight_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 561);
            this.Controls.Add(this.textBoxBarcodeHeight);
            this.Controls.Add(this.textBoxBarcodeWidth);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOrientation);
            this.Controls.Add(this.comboBoxOrientation);
            this.Controls.Add(this.comboBoxBarcodeType);
            this.Controls.Add(this.buttonGenerateBarcode);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.printPreviewControl);
            this.Name = "Form1";
            this.Text = "Barcode printer";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxOrientation;
        private System.Windows.Forms.Label labelOrientation;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBarcodeWidth;
        private System.Windows.Forms.TextBox textBoxBarcodeHeight;
        private System.Windows.Forms.Label label3;
    }
}

