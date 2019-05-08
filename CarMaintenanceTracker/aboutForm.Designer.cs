namespace CarMaintenanceTracker
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.lbName = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbVersion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.rtbEula = new System.Windows.Forms.RichTextBox();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(140, 14);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(234, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Car Maintenance Tracker";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.lbName, 0, 0);
            this.tlpMain.Controls.Add(this.lbVersion, 0, 1);
            this.tlpMain.Controls.Add(this.lbCopyright, 0, 2);
            this.tlpMain.Controls.Add(this.button1, 0, 4);
            this.tlpMain.Controls.Add(this.rtbEula, 0, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.20144F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.79856F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpMain.Size = new System.Drawing.Size(515, 374);
            this.tlpMain.TabIndex = 1;
            // 
            // lbVersion
            // 
            this.lbVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(231, 71);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(53, 25);
            this.lbVersion.TabIndex = 2;
            this.lbVersion.Text = "label";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(212, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbCopyright
            // 
            this.lbCopyright.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.Location = new System.Drawing.Point(154, 125);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(207, 25);
            this.lbCopyright.TabIndex = 3;
            this.lbCopyright.Text = "Copyright (c) jonnyxcc";
            // 
            // rtbEula
            // 
            this.rtbEula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEula.Location = new System.Drawing.Point(3, 165);
            this.rtbEula.Name = "rtbEula";
            this.rtbEula.Size = new System.Drawing.Size(509, 160);
            this.rtbEula.TabIndex = 4;
            this.rtbEula.Text = resources.GetString("rtbEula.Text");
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 374);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "aboutForm";
            this.Text = "About";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.RichTextBox rtbEula;
    }
}