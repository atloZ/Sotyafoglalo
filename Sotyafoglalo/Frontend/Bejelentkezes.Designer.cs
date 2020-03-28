namespace Sotyafoglalo
{
    partial class Bejelentkezes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bejelentkezes));
            this.csapatSzamNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.csapatSzamLabel = new System.Windows.Forms.Label();
            this.csapatSzamButton = new System.Windows.Forms.Button();
            this.csapatNevLabel = new System.Windows.Forms.Label();
            this.csapatNevTextBox = new System.Windows.Forms.TextBox();
            this.csapatNevButton = new System.Windows.Forms.Button();
            this.alapButton = new System.Windows.Forms.Button();
            this.adatKezelesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.csapatSzamNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // csapatSzamNumericUpDown
            // 
            this.csapatSzamNumericUpDown.Location = new System.Drawing.Point(156, 9);
            this.csapatSzamNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.csapatSzamNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.csapatSzamNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.csapatSzamNumericUpDown.Name = "csapatSzamNumericUpDown";
            this.csapatSzamNumericUpDown.ReadOnly = true;
            this.csapatSzamNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.csapatSzamNumericUpDown.TabIndex = 0;
            this.csapatSzamNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.csapatSzamNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.select_KeyDown);
            // 
            // csapatSzamLabel
            // 
            this.csapatSzamLabel.AutoSize = true;
            this.csapatSzamLabel.Location = new System.Drawing.Point(16, 11);
            this.csapatSzamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.csapatSzamLabel.Name = "csapatSzamLabel";
            this.csapatSzamLabel.Size = new System.Drawing.Size(112, 17);
            this.csapatSzamLabel.TabIndex = 1;
            this.csapatSzamLabel.Text = "Csapatok száma";
            // 
            // csapatSzamButton
            // 
            this.csapatSzamButton.Location = new System.Drawing.Point(340, 9);
            this.csapatSzamButton.Margin = new System.Windows.Forms.Padding(4);
            this.csapatSzamButton.Name = "csapatSzamButton";
            this.csapatSzamButton.Size = new System.Drawing.Size(100, 28);
            this.csapatSzamButton.TabIndex = 2;
            this.csapatSzamButton.Text = "OK";
            this.csapatSzamButton.UseVisualStyleBackColor = true;
            this.csapatSzamButton.Click += new System.EventHandler(this.csapatSzamButton_Click);
            // 
            // csapatNevLabel
            // 
            this.csapatNevLabel.AutoSize = true;
            this.csapatNevLabel.Location = new System.Drawing.Point(17, 47);
            this.csapatNevLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.csapatNevLabel.Name = "csapatNevLabel";
            this.csapatNevLabel.Size = new System.Drawing.Size(103, 17);
            this.csapatNevLabel.TabIndex = 3;
            this.csapatNevLabel.Text = "1. Csapat neve";
            // 
            // csapatNevTextBox
            // 
            this.csapatNevTextBox.Location = new System.Drawing.Point(156, 47);
            this.csapatNevTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.csapatNevTextBox.Name = "csapatNevTextBox";
            this.csapatNevTextBox.Size = new System.Drawing.Size(159, 22);
            this.csapatNevTextBox.TabIndex = 4;
            this.csapatNevTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.select_KeyDown);
            // 
            // csapatNevButton
            // 
            this.csapatNevButton.Location = new System.Drawing.Point(340, 47);
            this.csapatNevButton.Margin = new System.Windows.Forms.Padding(4);
            this.csapatNevButton.Name = "csapatNevButton";
            this.csapatNevButton.Size = new System.Drawing.Size(100, 28);
            this.csapatNevButton.TabIndex = 5;
            this.csapatNevButton.Text = "OK";
            this.csapatNevButton.UseVisualStyleBackColor = true;
            this.csapatNevButton.Click += new System.EventHandler(this.csapatNevButton_Click);
            // 
            // alapButton
            // 
            this.alapButton.Location = new System.Drawing.Point(340, 101);
            this.alapButton.Margin = new System.Windows.Forms.Padding(4);
            this.alapButton.Name = "alapButton";
            this.alapButton.Size = new System.Drawing.Size(100, 28);
            this.alapButton.TabIndex = 6;
            this.alapButton.Text = "Alap";
            this.alapButton.UseVisualStyleBackColor = true;
            this.alapButton.Click += new System.EventHandler(this.alapButton_Click);
            // 
            // adatKezelesButton
            // 
            this.adatKezelesButton.Location = new System.Drawing.Point(12, 106);
            this.adatKezelesButton.Name = "adatKezelesButton";
            this.adatKezelesButton.Size = new System.Drawing.Size(303, 23);
            this.adatKezelesButton.TabIndex = 7;
            this.adatKezelesButton.Text = "Kérdések kezelése";
            this.adatKezelesButton.UseVisualStyleBackColor = true;
            this.adatKezelesButton.Click += new System.EventHandler(this.adatKezelesButton_Click);
            // 
            // Bejelentkezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 144);
            this.Controls.Add(this.adatKezelesButton);
            this.Controls.Add(this.alapButton);
            this.Controls.Add(this.csapatNevButton);
            this.Controls.Add(this.csapatNevTextBox);
            this.Controls.Add(this.csapatNevLabel);
            this.Controls.Add(this.csapatSzamButton);
            this.Controls.Add(this.csapatSzamLabel);
            this.Controls.Add(this.csapatSzamNumericUpDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bejelentkezes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bevitel";
            this.Load += new System.EventHandler(this.Bevitel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.csapatSzamNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown csapatSzamNumericUpDown;
        private System.Windows.Forms.Label csapatSzamLabel;
        private System.Windows.Forms.Button csapatSzamButton;
        private System.Windows.Forms.Label csapatNevLabel;
        private System.Windows.Forms.TextBox csapatNevTextBox;
        private System.Windows.Forms.Button csapatNevButton;
        private System.Windows.Forms.Button alapButton;
        private System.Windows.Forms.Button adatKezelesButton;
    }
}