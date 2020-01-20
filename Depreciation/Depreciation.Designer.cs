namespace Depreciation
{
    partial class Depreciation
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPresentValue = new System.Windows.Forms.Label();
            this.lblSalvageValue = new System.Windows.Forms.Label();
            this.lblDepreciationPeriods = new System.Windows.Forms.Label();
            this.lstDepreciationPerYear = new System.Windows.Forms.ListBox();
            this.inputPresentValue = new System.Windows.Forms.TextBox();
            this.inputSalvageValue = new System.Windows.Forms.TextBox();
            this.inputDepreciationPeriod = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuOpenAboutForm = new System.Windows.Forms.ToolStripMenuItem();
            this.lblValueForEachYear = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Straight-Line Depreciation\r\nCalculator";
            // 
            // lblPresentValue
            // 
            this.lblPresentValue.AutoSize = true;
            this.lblPresentValue.Location = new System.Drawing.Point(9, 91);
            this.lblPresentValue.Name = "lblPresentValue";
            this.lblPresentValue.Size = new System.Drawing.Size(72, 13);
            this.lblPresentValue.TabIndex = 1;
            this.lblPresentValue.Text = "Present value";
            // 
            // lblSalvageValue
            // 
            this.lblSalvageValue.AutoSize = true;
            this.lblSalvageValue.Location = new System.Drawing.Point(9, 113);
            this.lblSalvageValue.Name = "lblSalvageValue";
            this.lblSalvageValue.Size = new System.Drawing.Size(75, 13);
            this.lblSalvageValue.TabIndex = 2;
            this.lblSalvageValue.Text = "Salvage value";
            // 
            // lblDepreciationPeriods
            // 
            this.lblDepreciationPeriods.AutoSize = true;
            this.lblDepreciationPeriods.Location = new System.Drawing.Point(9, 139);
            this.lblDepreciationPeriods.Name = "lblDepreciationPeriods";
            this.lblDepreciationPeriods.Size = new System.Drawing.Size(105, 26);
            this.lblDepreciationPeriods.TabIndex = 3;
            this.lblDepreciationPeriods.Text = "Depreciation Periods\r\n(in years)";
            // 
            // lstDepreciationPerYear
            // 
            this.lstDepreciationPerYear.ColumnWidth = 100;
            this.lstDepreciationPerYear.FormattingEnabled = true;
            this.lstDepreciationPerYear.Location = new System.Drawing.Point(72, 196);
            this.lstDepreciationPerYear.Name = "lstDepreciationPerYear";
            this.lstDepreciationPerYear.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstDepreciationPerYear.Size = new System.Drawing.Size(99, 108);
            this.lstDepreciationPerYear.TabIndex = 4;
            // 
            // inputPresentValue
            // 
            this.inputPresentValue.Location = new System.Drawing.Point(154, 84);
            this.inputPresentValue.Name = "inputPresentValue";
            this.inputPresentValue.Size = new System.Drawing.Size(100, 20);
            this.inputPresentValue.TabIndex = 5;
            // 
            // inputSalvageValue
            // 
            this.inputSalvageValue.Location = new System.Drawing.Point(154, 113);
            this.inputSalvageValue.Name = "inputSalvageValue";
            this.inputSalvageValue.Size = new System.Drawing.Size(100, 20);
            this.inputSalvageValue.TabIndex = 6;
            // 
            // inputDepreciationPeriod
            // 
            this.inputDepreciationPeriod.Location = new System.Drawing.Point(154, 139);
            this.inputDepreciationPeriod.Name = "inputDepreciationPeriod";
            this.inputDepreciationPeriod.Size = new System.Drawing.Size(100, 20);
            this.inputDepreciationPeriod.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(192, 196);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(62, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(192, 225);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(192, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenAboutForm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(268, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuOpenAboutForm
            // 
            this.mnuOpenAboutForm.Name = "mnuOpenAboutForm";
            this.mnuOpenAboutForm.Size = new System.Drawing.Size(52, 20);
            this.mnuOpenAboutForm.Text = "About";
            this.mnuOpenAboutForm.Click += new System.EventHandler(this.mnuOpenAboutForm_Click);
            // 
            // lblValueForEachYear
            // 
            this.lblValueForEachYear.AutoSize = true;
            this.lblValueForEachYear.Location = new System.Drawing.Point(85, 180);
            this.lblValueForEachYear.Name = "lblValueForEachYear";
            this.lblValueForEachYear.Size = new System.Drawing.Size(75, 13);
            this.lblValueForEachYear.TabIndex = 12;
            this.lblValueForEachYear.Text = "Value per year";
            // 
            // Depreciation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 325);
            this.Controls.Add(this.lblValueForEachYear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.inputDepreciationPeriod);
            this.Controls.Add(this.inputSalvageValue);
            this.Controls.Add(this.inputPresentValue);
            this.Controls.Add(this.lstDepreciationPerYear);
            this.Controls.Add(this.lblDepreciationPeriods);
            this.Controls.Add(this.lblSalvageValue);
            this.Controls.Add(this.lblPresentValue);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Depreciation";
            this.Text = "Straight-line Asset Depreciation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPresentValue;
        private System.Windows.Forms.Label lblSalvageValue;
        private System.Windows.Forms.Label lblDepreciationPeriods;
        private System.Windows.Forms.ListBox lstDepreciationPerYear;
        private System.Windows.Forms.TextBox inputPresentValue;
        private System.Windows.Forms.TextBox inputSalvageValue;
        private System.Windows.Forms.TextBox inputDepreciationPeriod;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenAboutForm;
        private System.Windows.Forms.Label lblValueForEachYear;
    }
}

