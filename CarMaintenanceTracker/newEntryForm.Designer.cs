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
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbMileageEstimate = new System.Windows.Forms.Label();
            this.tbCarMileage = new System.Windows.Forms.TextBox();
            this.epMileage = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tbCarName, 0, 1);
            this.tlpMain.Controls.Add(this.lbMain, 0, 0);
            this.tlpMain.Controls.Add(this.bOK, 0, 4);
            this.tlpMain.Controls.Add(this.tbCarMileage, 0, 3);
            this.tlpMain.Controls.Add(this.lbMileageEstimate, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.40816F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.18367F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.22449F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.77551F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.Size = new System.Drawing.Size(523, 245);
            this.tlpMain.TabIndex = 0;
            // 
            // tbCarName
            // 
            this.tbCarName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCarName.Location = new System.Drawing.Point(154, 59);
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.Size = new System.Drawing.Size(214, 29);
            this.tbCarName.TabIndex = 0;
            // 
            // lbMain
            // 
            this.lbMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMain.AutoSize = true;
            this.lbMain.Location = new System.Drawing.Point(66, 12);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(390, 25);
            this.lbMain.TabIndex = 1;
            this.lbMain.Text = "Enter the name of your car in the box below.";
            // 
            // bOK
            // 
            this.bOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.Location = new System.Drawing.Point(207, 200);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(108, 40);
            this.bOK.TabIndex = 2;
            this.bOK.Text = "Okay";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // lbMileageEstimate
            // 
            this.lbMileageEstimate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMileageEstimate.AutoSize = true;
            this.lbMileageEstimate.Location = new System.Drawing.Point(5, 98);
            this.lbMileageEstimate.Name = "lbMileageEstimate";
            this.lbMileageEstimate.Size = new System.Drawing.Size(513, 50);
            this.lbMileageEstimate.TabIndex = 3;
            this.lbMileageEstimate.Text = "Enter approximately how many miles you drive this vehicle per month in the box be" +
    "low.";
            // 
            // tbCarMileage
            // 
            this.tbCarMileage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCarMileage.Location = new System.Drawing.Point(154, 157);
            this.tbCarMileage.Name = "tbCarMileage";
            this.tbCarMileage.Size = new System.Drawing.Size(214, 29);
            this.tbCarMileage.TabIndex = 1;
            // 
            // epMileage
            // 
            this.epMileage.ContainerControl = this;
            // 
            // newEntryForm
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 245);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "newEntryForm";
            this.Text = "Enter Your Car";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.newEntryForm_FormClosing);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMileage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TextBox tbCarName;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.ErrorProvider epName;
        private System.Windows.Forms.Label lbMileageEstimate;
        private System.Windows.Forms.TextBox tbCarMileage;
        private System.Windows.Forms.ErrorProvider epMileage;
    }
}