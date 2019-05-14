namespace CarMaintenanceTracker
{
    partial class newEntryForm
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
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.lbMain = new System.Windows.Forms.Label();
            this.bOK = new System.Windows.Forms.Button();
            this.epMain = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tbCarName, 0, 1);
            this.tlpMain.Controls.Add(this.lbMain, 0, 0);
            this.tlpMain.Controls.Add(this.bOK, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.Size = new System.Drawing.Size(523, 161);
            this.tlpMain.TabIndex = 0;
            // 
            // tbCarName
            // 
            this.tbCarName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCarName.Location = new System.Drawing.Point(154, 65);
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.Size = new System.Drawing.Size(214, 29);
            this.tbCarName.TabIndex = 0;
            // 
            // lbMain
            // 
            this.lbMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMain.AutoSize = true;
            this.lbMain.Location = new System.Drawing.Point(16, 1);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(490, 50);
            this.lbMain.TabIndex = 1;
            this.lbMain.Text = "Enter the name of your car in the box below. Click okay when finished.";
            // 
            // bOK
            // 
            this.bOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.Location = new System.Drawing.Point(207, 113);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(108, 40);
            this.bOK.TabIndex = 2;
            this.bOK.Text = "Okay";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // epMain
            // 
            this.epMain.ContainerControl = this;
            // 
            // newEntryForm
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 161);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "newEntryForm";
            this.Text = "Enter Your Car";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.newEntryForm_FormClosing);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TextBox tbCarName;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.ErrorProvider epMain;
    }
}