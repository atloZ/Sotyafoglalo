namespace Sotyafoglalo
{
    partial class Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.t_valaszDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.v_valaszDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.t_kerdesOKButton = new System.Windows.Forms.Button();
            this.v_kerdesOKButton = new System.Windows.Forms.Button();
            this.t_CsapatGroupBox = new System.Windows.Forms.GroupBox();
            this.t_tippOKButton = new System.Windows.Forms.Button();
            this.t_tippTextBox = new System.Windows.Forms.TextBox();
            this.t_gyorsabbCheckBox = new System.Windows.Forms.CheckBox();
            this.v_CsapatGroupBox = new System.Windows.Forms.GroupBox();
            this.v_tippOKButton = new System.Windows.Forms.Button();
            this.v_tippTextBox = new System.Windows.Forms.TextBox();
            this.v_gyorsabbCheckBox = new System.Windows.Forms.CheckBox();
            this.korNyerteseLabel = new System.Windows.Forms.Label();
            this.stopperLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.jatekInditasButton = new System.Windows.Forms.Button();
            this.korInditasButton = new System.Windows.Forms.Button();
            this.kerdesInditasButton = new System.Windows.Forms.Button();
            this.kerdesekSzamaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eredmenyHirdetesButton = new System.Windows.Forms.Button();
            this.t_CsapatGroupBox.SuspendLayout();
            this.v_CsapatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_valaszDomainUpDown
            // 
            this.t_valaszDomainUpDown.Items.Add("A");
            this.t_valaszDomainUpDown.Items.Add("B");
            this.t_valaszDomainUpDown.Items.Add("C");
            this.t_valaszDomainUpDown.Items.Add("D");
            this.t_valaszDomainUpDown.Location = new System.Drawing.Point(5, 126);
            this.t_valaszDomainUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.t_valaszDomainUpDown.Name = "t_valaszDomainUpDown";
            this.t_valaszDomainUpDown.ReadOnly = true;
            this.t_valaszDomainUpDown.Size = new System.Drawing.Size(125, 22);
            this.t_valaszDomainUpDown.TabIndex = 1;
            // 
            // v_valaszDomainUpDown
            // 
            this.v_valaszDomainUpDown.Items.Add("A");
            this.v_valaszDomainUpDown.Items.Add("B");
            this.v_valaszDomainUpDown.Items.Add("C");
            this.v_valaszDomainUpDown.Items.Add("D");
            this.v_valaszDomainUpDown.Location = new System.Drawing.Point(8, 126);
            this.v_valaszDomainUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.v_valaszDomainUpDown.Name = "v_valaszDomainUpDown";
            this.v_valaszDomainUpDown.ReadOnly = true;
            this.v_valaszDomainUpDown.Size = new System.Drawing.Size(125, 22);
            this.v_valaszDomainUpDown.TabIndex = 1;
            // 
            // t_kerdesOKButton
            // 
            this.t_kerdesOKButton.Location = new System.Drawing.Point(5, 156);
            this.t_kerdesOKButton.Margin = new System.Windows.Forms.Padding(4);
            this.t_kerdesOKButton.Name = "t_kerdesOKButton";
            this.t_kerdesOKButton.Size = new System.Drawing.Size(125, 28);
            this.t_kerdesOKButton.TabIndex = 2;
            this.t_kerdesOKButton.Text = "OK";
            this.t_kerdesOKButton.UseVisualStyleBackColor = true;
            this.t_kerdesOKButton.Click += new System.EventHandler(this.OkButton1_Click);
            // 
            // v_kerdesOKButton
            // 
            this.v_kerdesOKButton.Location = new System.Drawing.Point(8, 156);
            this.v_kerdesOKButton.Margin = new System.Windows.Forms.Padding(4);
            this.v_kerdesOKButton.Name = "v_kerdesOKButton";
            this.v_kerdesOKButton.Size = new System.Drawing.Size(125, 28);
            this.v_kerdesOKButton.TabIndex = 2;
            this.v_kerdesOKButton.Text = "OK";
            this.v_kerdesOKButton.UseVisualStyleBackColor = true;
            this.v_kerdesOKButton.Click += new System.EventHandler(this.okButton2_Click);
            // 
            // t_CsapatGroupBox
            // 
            this.t_CsapatGroupBox.Controls.Add(this.t_tippOKButton);
            this.t_CsapatGroupBox.Controls.Add(this.t_tippTextBox);
            this.t_CsapatGroupBox.Controls.Add(this.t_gyorsabbCheckBox);
            this.t_CsapatGroupBox.Controls.Add(this.t_valaszDomainUpDown);
            this.t_CsapatGroupBox.Controls.Add(this.t_kerdesOKButton);
            this.t_CsapatGroupBox.Location = new System.Drawing.Point(15, 90);
            this.t_CsapatGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.t_CsapatGroupBox.Name = "t_CsapatGroupBox";
            this.t_CsapatGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.t_CsapatGroupBox.Size = new System.Drawing.Size(160, 192);
            this.t_CsapatGroupBox.TabIndex = 3;
            this.t_CsapatGroupBox.TabStop = false;
            this.t_CsapatGroupBox.Text = "TámadóCsapat";
            // 
            // t_tippOKButton
            // 
            this.t_tippOKButton.Location = new System.Drawing.Point(8, 81);
            this.t_tippOKButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t_tippOKButton.Name = "t_tippOKButton";
            this.t_tippOKButton.Size = new System.Drawing.Size(125, 23);
            this.t_tippOKButton.TabIndex = 5;
            this.t_tippOKButton.Text = "OK";
            this.t_tippOKButton.UseVisualStyleBackColor = true;
            this.t_tippOKButton.Visible = false;
            this.t_tippOKButton.Click += new System.EventHandler(this.OKButton3_Click);
            // 
            // t_tippTextBox
            // 
            this.t_tippTextBox.Location = new System.Drawing.Point(8, 53);
            this.t_tippTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t_tippTextBox.Name = "t_tippTextBox";
            this.t_tippTextBox.Size = new System.Drawing.Size(125, 22);
            this.t_tippTextBox.TabIndex = 4;
            this.t_tippTextBox.Visible = false;
            // 
            // t_gyorsabbCheckBox
            // 
            this.t_gyorsabbCheckBox.AutoSize = true;
            this.t_gyorsabbCheckBox.Location = new System.Drawing.Point(39, 16);
            this.t_gyorsabbCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.t_gyorsabbCheckBox.Name = "t_gyorsabbCheckBox";
            this.t_gyorsabbCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.t_gyorsabbCheckBox.Size = new System.Drawing.Size(92, 21);
            this.t_gyorsabbCheckBox.TabIndex = 3;
            this.t_gyorsabbCheckBox.Text = "Gyorsabb";
            this.t_gyorsabbCheckBox.UseVisualStyleBackColor = true;
            this.t_gyorsabbCheckBox.Visible = false;
            this.t_gyorsabbCheckBox.CheckedChanged += new System.EventHandler(this.gyorsabb1CheckBox_CheckedChanged);
            // 
            // v_CsapatGroupBox
            // 
            this.v_CsapatGroupBox.Controls.Add(this.v_tippOKButton);
            this.v_CsapatGroupBox.Controls.Add(this.v_tippTextBox);
            this.v_CsapatGroupBox.Controls.Add(this.v_gyorsabbCheckBox);
            this.v_CsapatGroupBox.Controls.Add(this.v_valaszDomainUpDown);
            this.v_CsapatGroupBox.Controls.Add(this.v_kerdesOKButton);
            this.v_CsapatGroupBox.Location = new System.Drawing.Point(232, 90);
            this.v_CsapatGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.v_CsapatGroupBox.Name = "v_CsapatGroupBox";
            this.v_CsapatGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.v_CsapatGroupBox.Size = new System.Drawing.Size(161, 192);
            this.v_CsapatGroupBox.TabIndex = 4;
            this.v_CsapatGroupBox.TabStop = false;
            this.v_CsapatGroupBox.Text = "VédőCsapat";
            // 
            // v_tippOKButton
            // 
            this.v_tippOKButton.Location = new System.Drawing.Point(8, 81);
            this.v_tippOKButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.v_tippOKButton.Name = "v_tippOKButton";
            this.v_tippOKButton.Size = new System.Drawing.Size(125, 23);
            this.v_tippOKButton.TabIndex = 6;
            this.v_tippOKButton.Text = "OK";
            this.v_tippOKButton.UseVisualStyleBackColor = true;
            this.v_tippOKButton.Visible = false;
            this.v_tippOKButton.Click += new System.EventHandler(this.OKButton4_Click);
            // 
            // v_tippTextBox
            // 
            this.v_tippTextBox.Location = new System.Drawing.Point(8, 53);
            this.v_tippTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.v_tippTextBox.Name = "v_tippTextBox";
            this.v_tippTextBox.Size = new System.Drawing.Size(125, 22);
            this.v_tippTextBox.TabIndex = 4;
            this.v_tippTextBox.Visible = false;
            // 
            // v_gyorsabbCheckBox
            // 
            this.v_gyorsabbCheckBox.AutoSize = true;
            this.v_gyorsabbCheckBox.Location = new System.Drawing.Point(39, 16);
            this.v_gyorsabbCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.v_gyorsabbCheckBox.Name = "v_gyorsabbCheckBox";
            this.v_gyorsabbCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.v_gyorsabbCheckBox.Size = new System.Drawing.Size(92, 21);
            this.v_gyorsabbCheckBox.TabIndex = 3;
            this.v_gyorsabbCheckBox.Text = "Gyorsabb";
            this.v_gyorsabbCheckBox.UseVisualStyleBackColor = true;
            this.v_gyorsabbCheckBox.Visible = false;
            this.v_gyorsabbCheckBox.CheckedChanged += new System.EventHandler(this.gyorsabb1CheckBox_CheckedChanged);
            // 
            // korNyerteseLabel
            // 
            this.korNyerteseLabel.AutoSize = true;
            this.korNyerteseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korNyerteseLabel.ForeColor = System.Drawing.Color.Red;
            this.korNyerteseLabel.Location = new System.Drawing.Point(17, 287);
            this.korNyerteseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.korNyerteseLabel.Name = "korNyerteseLabel";
            this.korNyerteseLabel.Size = new System.Drawing.Size(169, 25);
            this.korNyerteseLabel.TabIndex = 5;
            this.korNyerteseLabel.Text = "Nyertes csapat: ";
            // 
            // stopperLabel
            // 
            this.stopperLabel.AutoSize = true;
            this.stopperLabel.Location = new System.Drawing.Point(16, 49);
            this.stopperLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stopperLabel.Name = "stopperLabel";
            this.stopperLabel.Size = new System.Drawing.Size(94, 17);
            this.stopperLabel.TabIndex = 6;
            this.stopperLabel.Text = "stopper_label";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // jatekInditasButton
            // 
            this.jatekInditasButton.Location = new System.Drawing.Point(23, 357);
            this.jatekInditasButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jatekInditasButton.Name = "jatekInditasButton";
            this.jatekInditasButton.Size = new System.Drawing.Size(371, 54);
            this.jatekInditasButton.TabIndex = 7;
            this.jatekInditasButton.Text = "Játék kezdése";
            this.jatekInditasButton.UseVisualStyleBackColor = true;
            this.jatekInditasButton.Click += new System.EventHandler(this.jatekInditasButton_Click);
            // 
            // korInditasButton
            // 
            this.korInditasButton.Enabled = false;
            this.korInditasButton.Location = new System.Drawing.Point(23, 438);
            this.korInditasButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.korInditasButton.Name = "korInditasButton";
            this.korInditasButton.Size = new System.Drawing.Size(371, 47);
            this.korInditasButton.TabIndex = 8;
            this.korInditasButton.Text = "Kör kezdése";
            this.korInditasButton.UseVisualStyleBackColor = true;
            this.korInditasButton.Click += new System.EventHandler(this.startTurnBtn_Click);
            // 
            // kerdesInditasButton
            // 
            this.kerdesInditasButton.Enabled = false;
            this.kerdesInditasButton.Location = new System.Drawing.Point(23, 514);
            this.kerdesInditasButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kerdesInditasButton.Name = "kerdesInditasButton";
            this.kerdesInditasButton.Size = new System.Drawing.Size(371, 55);
            this.kerdesInditasButton.TabIndex = 9;
            this.kerdesInditasButton.Text = "Kérdés inditó!";
            this.kerdesInditasButton.UseVisualStyleBackColor = true;
            this.kerdesInditasButton.Click += new System.EventHandler(this.stopperBtn_Click);
            // 
            // kerdesekSzamaLabel
            // 
            this.kerdesekSzamaLabel.AutoSize = true;
            this.kerdesekSzamaLabel.Location = new System.Drawing.Point(228, 49);
            this.kerdesekSzamaLabel.Name = "kerdesekSzamaLabel";
            this.kerdesekSzamaLabel.Size = new System.Drawing.Size(90, 17);
            this.kerdesekSzamaLabel.TabIndex = 10;
            this.kerdesekSzamaLabel.Text = "Kérdés szám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MaximumSize = new System.Drawing.Size(235, 38);
            this.label2.MinimumSize = new System.Drawing.Size(235, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "ControlForm";
            // 
            // eredmenyHirdetesButton
            // 
            this.eredmenyHirdetesButton.Enabled = false;
            this.eredmenyHirdetesButton.Location = new System.Drawing.Point(23, 593);
            this.eredmenyHirdetesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eredmenyHirdetesButton.Name = "eredmenyHirdetesButton";
            this.eredmenyHirdetesButton.Size = new System.Drawing.Size(371, 55);
            this.eredmenyHirdetesButton.TabIndex = 9;
            this.eredmenyHirdetesButton.Text = "Eredmény hirdetés most!";
            this.eredmenyHirdetesButton.UseVisualStyleBackColor = true;
            this.eredmenyHirdetesButton.Click += new System.EventHandler(this.eredmenyHirdetesButton_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 676);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kerdesekSzamaLabel);
            this.Controls.Add(this.eredmenyHirdetesButton);
            this.Controls.Add(this.kerdesInditasButton);
            this.Controls.Add(this.korInditasButton);
            this.Controls.Add(this.jatekInditasButton);
            this.Controls.Add(this.stopperLabel);
            this.Controls.Add(this.korNyerteseLabel);
            this.Controls.Add(this.v_CsapatGroupBox);
            this.Controls.Add(this.t_CsapatGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlForm_FormClosing);
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.t_CsapatGroupBox.ResumeLayout(false);
            this.t_CsapatGroupBox.PerformLayout();
            this.v_CsapatGroupBox.ResumeLayout(false);
            this.v_CsapatGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown t_valaszDomainUpDown;
        private System.Windows.Forms.DomainUpDown v_valaszDomainUpDown;
        private System.Windows.Forms.Button t_kerdesOKButton;
        private System.Windows.Forms.Button v_kerdesOKButton;
        private System.Windows.Forms.GroupBox t_CsapatGroupBox;
        private System.Windows.Forms.CheckBox t_gyorsabbCheckBox;
        private System.Windows.Forms.GroupBox v_CsapatGroupBox;
        private System.Windows.Forms.CheckBox v_gyorsabbCheckBox;
        private System.Windows.Forms.Label korNyerteseLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button jatekInditasButton;
        private System.Windows.Forms.Button korInditasButton;
        private System.Windows.Forms.Button kerdesInditasButton;
        private System.Windows.Forms.Label kerdesekSzamaLabel;
        private System.Windows.Forms.TextBox t_tippTextBox;
        private System.Windows.Forms.TextBox v_tippTextBox;
        private System.Windows.Forms.Button t_tippOKButton;
        private System.Windows.Forms.Button v_tippOKButton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label stopperLabel;
        private System.Windows.Forms.Button eredmenyHirdetesButton;
    }
}