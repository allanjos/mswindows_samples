namespace TCPDesktopServer
{
    partial class formMain
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(127, 15);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start server";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(208, 15);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop server";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(47, 17);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(50, 20);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.Text = "5010";
            // 
            // listViewEvents
            // 
            this.listViewEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewEvents.FullRowSelect = true;
            this.listViewEvents.GridLines = true;
            this.listViewEvents.Location = new System.Drawing.Point(12, 57);
            this.listViewEvents.MultiSelect = false;
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewEvents.Size = new System.Drawing.Size(643, 226);
            this.listViewEvents.TabIndex = 4;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Evento";
            this.columnHeader1.Width = 637;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 295);
            this.Controls.Add(this.listViewEvents);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "formMain";
            this.Text = "TCP server";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

