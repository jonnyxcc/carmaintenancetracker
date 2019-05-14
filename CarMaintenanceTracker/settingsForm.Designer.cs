namespace CarMaintenanceTracker
{
    partial class settingsForm
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
            this.tplOkCancel = new System.Windows.Forms.TableLayoutPanel();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCar = new System.Windows.Forms.Label();
            this.cbCarSelection = new System.Windows.Forms.ComboBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbOilChangeMiles = new System.Windows.Forms.Label();
            this.tbOilChangeMiles = new System.Windows.Forms.TextBox();
            this.tbMilesPerTireRotation = new System.Windows.Forms.TextBox();
            this.lbMilesPerRotation = new System.Windows.Forms.Label();
            this.epMain = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpMain.SuspendLayout();
            this.tplOkCancel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tplOkCancel, 0, 3);
            this.tlpMain.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlpMain.Controls.Add(this.bSave, 0, 1);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.731959F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.216495F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.03093F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.891752F));
            this.tlpMain.Size = new System.Drawing.Size(935, 776);
            this.tlpMain.TabIndex = 0;
            // 
            // tplOkCancel
            // 
            this.tplOkCancel.ColumnCount = 2;
            this.tplOkCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplOkCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplOkCancel.Controls.Add(this.bOk, 0, 0);
            this.tplOkCancel.Controls.Add(this.bCancel, 1, 0);
            this.tplOkCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplOkCancel.Location = new System.Drawing.Point(3, 709);
            this.tplOkCancel.Name = "tplOkCancel";
            this.tplOkCancel.RowCount = 1;
            this.tplOkCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplOkCancel.Size = new System.Drawing.Size(929, 64);
            this.tplOkCancel.TabIndex = 0;
            // 
            // bOk
            // 
            this.bOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Location = new System.Drawing.Point(182, 7);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(99, 49);
            this.bOk.TabIndex = 0;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(641, 7);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(111, 49);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 304F));
            this.tableLayoutPanel2.Controls.Add(this.lbCar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbCarSelection, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bAdd, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bRemove, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(929, 54);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbCar
            // 
            this.lbCar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCar.AutoSize = true;
            this.lbCar.Location = new System.Drawing.Point(215, 14);
            this.lbCar.Name = "lbCar";
            this.lbCar.Size = new System.Drawing.Size(50, 25);
            this.lbCar.TabIndex = 0;
            this.lbCar.Text = "Car:";
            // 
            // cbCarSelection
            // 
            this.cbCarSelection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCarSelection.FormattingEnabled = true;
            this.cbCarSelection.Location = new System.Drawing.Point(271, 11);
            this.cbCarSelection.Name = "cbCarSelection";
            this.cbCarSelection.Size = new System.Drawing.Size(220, 32);
            this.cbCarSelection.TabIndex = 1;
            // 
            // bAdd
            // 
            this.bAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bAdd.Location = new System.Drawing.Point(497, 7);
            this.bAdd.MinimumSize = new System.Drawing.Size(0, 40);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(120, 40);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // bRemove
            // 
            this.bRemove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bRemove.Location = new System.Drawing.Point(628, 7);
            this.bRemove.MinimumSize = new System.Drawing.Size(0, 40);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(120, 40);
            this.bRemove.TabIndex = 3;
            this.bRemove.Text = "Remove";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.BRemove_Click);
            // 
            // bSave
            // 
            this.bSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSave.Location = new System.Drawing.Point(405, 63);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(124, 50);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Save Car";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lbOilChangeMiles, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbOilChangeMiles, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbMilesPerTireRotation, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbMilesPerRotation, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 119);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.219178F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.78082F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(929, 584);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lbOilChangeMiles
            // 
            this.lbOilChangeMiles.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbOilChangeMiles.AutoSize = true;
            this.lbOilChangeMiles.Location = new System.Drawing.Point(26, 11);
            this.lbOilChangeMiles.Name = "lbOilChangeMiles";
            this.lbOilChangeMiles.Size = new System.Drawing.Size(203, 25);
            this.lbOilChangeMiles.TabIndex = 0;
            this.lbOilChangeMiles.Text = "Miles Per Oil Change:";
            // 
            // tbOilChangeMiles
            // 
            this.tbOilChangeMiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbOilChangeMiles.Location = new System.Drawing.Point(235, 9);
            this.tbOilChangeMiles.Name = "tbOilChangeMiles";
            this.tbOilChangeMiles.Size = new System.Drawing.Size(200, 29);
            this.tbOilChangeMiles.TabIndex = 1;
            this.tbOilChangeMiles.Validating += new System.ComponentModel.CancelEventHandler(this.TbOilChangeMiles_Validating);
            // 
            // tbMilesPerTireRotation
            // 
            this.tbMilesPerTireRotation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbMilesPerTireRotation.Location = new System.Drawing.Point(699, 9);
            this.tbMilesPerTireRotation.Name = "tbMilesPerTireRotation";
            this.tbMilesPerTireRotation.Size = new System.Drawing.Size(200, 29);
            this.tbMilesPerTireRotation.TabIndex = 2;
            // 
            // lbMilesPerRotation
            // 
            this.lbMilesPerRotation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbMilesPerRotation.AutoSize = true;
            this.lbMilesPerRotation.Location = new System.Drawing.Point(479, 11);
            this.lbMilesPerRotation.Name = "lbMilesPerRotation";
            this.lbMilesPerRotation.Size = new System.Drawing.Size(214, 25);
            this.lbMilesPerRotation.TabIndex = 3;
            this.lbMilesPerRotation.Text = "Miles Per Tire Rotation:";
            // 
            // epMain
            // 
            this.epMain.ContainerControl = this;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 776);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.tlpMain.ResumeLayout(false);
            this.tplOkCancel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tplOkCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbCar;
        private System.Windows.Forms.ComboBox cbCarSelection;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.ErrorProvider epMain;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbOilChangeMiles;
        private System.Windows.Forms.TextBox tbOilChangeMiles;
        private System.Windows.Forms.TextBox tbMilesPerTireRotation;
        private System.Windows.Forms.Label lbMilesPerRotation;
    }
}