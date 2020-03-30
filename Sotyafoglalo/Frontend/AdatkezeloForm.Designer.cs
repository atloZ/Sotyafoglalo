namespace Sotyafoglalo.Frontend
{
    partial class AdatkezeloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdatkezeloForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.kerdesekTab = new System.Windows.Forms.TabPage();
            this.kerdeskDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kerdesLabel = new System.Windows.Forms.Label();
            this.kerdesTextBox = new System.Windows.Forms.TextBox();
            this.hozzaAddButton = new System.Windows.Forms.Button();
            this.helyesValaszTextBox = new System.Windows.Forms.TextBox();
            this.helytelenValasz3Label = new System.Windows.Forms.Label();
            this.helytelenValasz1TextBox = new System.Windows.Forms.TextBox();
            this.helytelenValasz2Label = new System.Windows.Forms.Label();
            this.helyesValaszLabel = new System.Windows.Forms.Label();
            this.helytelenValasz3TextBox = new System.Windows.Forms.TextBox();
            this.helytelenValasz2TextBox = new System.Windows.Forms.TextBox();
            this.helytelenValasz1Label = new System.Windows.Forms.Label();
            this.torolButton = new System.Windows.Forms.Button();
            this.tippTab = new System.Windows.Forms.TabPage();
            this.tippDataGridView = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TippKerdesTextBox = new System.Windows.Forms.TextBox();
            this.tippHozzadButton = new System.Windows.Forms.Button();
            this.TippValaszTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adatTorlesButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.kerdesekTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kerdeskDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tippTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tippDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.kerdesekTab);
            this.tabControl1.Controls.Add(this.tippTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 602);
            this.tabControl1.TabIndex = 0;
            // 
            // kerdesekTab
            // 
            this.kerdesekTab.Controls.Add(this.kerdeskDataGridView);
            this.kerdesekTab.Controls.Add(this.groupBox1);
            this.kerdesekTab.Controls.Add(this.torolButton);
            this.kerdesekTab.Location = new System.Drawing.Point(4, 25);
            this.kerdesekTab.Name = "kerdesekTab";
            this.kerdesekTab.Padding = new System.Windows.Forms.Padding(3);
            this.kerdesekTab.Size = new System.Drawing.Size(834, 573);
            this.kerdesekTab.TabIndex = 0;
            this.kerdesekTab.Text = "Kérdések és válaszok";
            this.kerdesekTab.UseVisualStyleBackColor = true;
            // 
            // kerdeskDataGridView
            // 
            this.kerdeskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kerdeskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.kerdeskDataGridView.Location = new System.Drawing.Point(8, 6);
            this.kerdeskDataGridView.Name = "kerdeskDataGridView";
            this.kerdeskDataGridView.RowHeadersWidth = 51;
            this.kerdeskDataGridView.RowTemplate.Height = 24;
            this.kerdeskDataGridView.Size = new System.Drawing.Size(818, 228);
            this.kerdeskDataGridView.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "kérdés";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Helyes válasz";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Válasz 1";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Válasz 2";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Válasz 3";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kerdesLabel);
            this.groupBox1.Controls.Add(this.kerdesTextBox);
            this.groupBox1.Controls.Add(this.hozzaAddButton);
            this.groupBox1.Controls.Add(this.helyesValaszTextBox);
            this.groupBox1.Controls.Add(this.helytelenValasz3Label);
            this.groupBox1.Controls.Add(this.helytelenValasz1TextBox);
            this.groupBox1.Controls.Add(this.helytelenValasz2Label);
            this.groupBox1.Controls.Add(this.helyesValaszLabel);
            this.groupBox1.Controls.Add(this.helytelenValasz3TextBox);
            this.groupBox1.Controls.Add(this.helytelenValasz2TextBox);
            this.groupBox1.Controls.Add(this.helytelenValasz1Label);
            this.groupBox1.Location = new System.Drawing.Point(8, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 282);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatfelvétel";
            // 
            // kerdesLabel
            // 
            this.kerdesLabel.AutoSize = true;
            this.kerdesLabel.Location = new System.Drawing.Point(6, 18);
            this.kerdesLabel.Name = "kerdesLabel";
            this.kerdesLabel.Size = new System.Drawing.Size(57, 17);
            this.kerdesLabel.TabIndex = 2;
            this.kerdesLabel.Text = "Kérdés:";
            // 
            // kerdesTextBox
            // 
            this.kerdesTextBox.Location = new System.Drawing.Point(6, 38);
            this.kerdesTextBox.Name = "kerdesTextBox";
            this.kerdesTextBox.Size = new System.Drawing.Size(806, 22);
            this.kerdesTextBox.TabIndex = 1;
            // 
            // hozzaAddButton
            // 
            this.hozzaAddButton.Location = new System.Drawing.Point(6, 246);
            this.hozzaAddButton.Name = "hozzaAddButton";
            this.hozzaAddButton.Size = new System.Drawing.Size(806, 23);
            this.hozzaAddButton.TabIndex = 3;
            this.hozzaAddButton.Text = "HOZZÁAD";
            this.hozzaAddButton.UseVisualStyleBackColor = true;
            this.hozzaAddButton.Click += new System.EventHandler(this.hozzaAddButton_Click);
            // 
            // helyesValaszTextBox
            // 
            this.helyesValaszTextBox.Location = new System.Drawing.Point(6, 83);
            this.helyesValaszTextBox.Name = "helyesValaszTextBox";
            this.helyesValaszTextBox.Size = new System.Drawing.Size(806, 22);
            this.helyesValaszTextBox.TabIndex = 1;
            // 
            // helytelenValasz3Label
            // 
            this.helytelenValasz3Label.AutoSize = true;
            this.helytelenValasz3Label.Location = new System.Drawing.Point(6, 198);
            this.helytelenValasz3Label.Name = "helytelenValasz3Label";
            this.helytelenValasz3Label.Size = new System.Drawing.Size(123, 17);
            this.helytelenValasz3Label.TabIndex = 2;
            this.helytelenValasz3Label.Text = "Helytelen válasz3:";
            // 
            // helytelenValasz1TextBox
            // 
            this.helytelenValasz1TextBox.Location = new System.Drawing.Point(6, 128);
            this.helytelenValasz1TextBox.Name = "helytelenValasz1TextBox";
            this.helytelenValasz1TextBox.Size = new System.Drawing.Size(806, 22);
            this.helytelenValasz1TextBox.TabIndex = 1;
            // 
            // helytelenValasz2Label
            // 
            this.helytelenValasz2Label.AutoSize = true;
            this.helytelenValasz2Label.Location = new System.Drawing.Point(6, 153);
            this.helytelenValasz2Label.Name = "helytelenValasz2Label";
            this.helytelenValasz2Label.Size = new System.Drawing.Size(123, 17);
            this.helytelenValasz2Label.TabIndex = 2;
            this.helytelenValasz2Label.Text = "Helytelen válasz2:";
            // 
            // helyesValaszLabel
            // 
            this.helyesValaszLabel.AutoSize = true;
            this.helyesValaszLabel.Location = new System.Drawing.Point(6, 63);
            this.helyesValaszLabel.Name = "helyesValaszLabel";
            this.helyesValaszLabel.Size = new System.Drawing.Size(99, 17);
            this.helyesValaszLabel.TabIndex = 2;
            this.helyesValaszLabel.Text = "Helyes válasz:";
            // 
            // helytelenValasz3TextBox
            // 
            this.helytelenValasz3TextBox.Location = new System.Drawing.Point(6, 218);
            this.helytelenValasz3TextBox.Name = "helytelenValasz3TextBox";
            this.helytelenValasz3TextBox.Size = new System.Drawing.Size(806, 22);
            this.helytelenValasz3TextBox.TabIndex = 1;
            // 
            // helytelenValasz2TextBox
            // 
            this.helytelenValasz2TextBox.Location = new System.Drawing.Point(6, 173);
            this.helytelenValasz2TextBox.Name = "helytelenValasz2TextBox";
            this.helytelenValasz2TextBox.Size = new System.Drawing.Size(806, 22);
            this.helytelenValasz2TextBox.TabIndex = 1;
            // 
            // helytelenValasz1Label
            // 
            this.helytelenValasz1Label.AutoSize = true;
            this.helytelenValasz1Label.Location = new System.Drawing.Point(6, 108);
            this.helytelenValasz1Label.Name = "helytelenValasz1Label";
            this.helytelenValasz1Label.Size = new System.Drawing.Size(123, 17);
            this.helytelenValasz1Label.TabIndex = 2;
            this.helytelenValasz1Label.Text = "Helytelen válasz1:";
            // 
            // torolButton
            // 
            this.torolButton.Location = new System.Drawing.Point(14, 240);
            this.torolButton.Name = "torolButton";
            this.torolButton.Size = new System.Drawing.Size(806, 23);
            this.torolButton.TabIndex = 3;
            this.torolButton.Text = "Kivalasztott elem törlése";
            this.torolButton.UseVisualStyleBackColor = true;
            this.torolButton.Click += new System.EventHandler(this.kerdesTorolButton_Click);
            // 
            // tippTab
            // 
            this.tippTab.Controls.Add(this.tippDataGridView);
            this.tippTab.Controls.Add(this.groupBox2);
            this.tippTab.Controls.Add(this.adatTorlesButton);
            this.tippTab.Location = new System.Drawing.Point(4, 25);
            this.tippTab.Name = "tippTab";
            this.tippTab.Padding = new System.Windows.Forms.Padding(3);
            this.tippTab.Size = new System.Drawing.Size(834, 573);
            this.tippTab.TabIndex = 1;
            this.tippTab.Text = "TippKérdések";
            this.tippTab.UseVisualStyleBackColor = true;
            // 
            // tippDataGridView
            // 
            this.tippDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tippDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7});
            this.tippDataGridView.Location = new System.Drawing.Point(6, 6);
            this.tippDataGridView.Name = "tippDataGridView";
            this.tippDataGridView.RowHeadersWidth = 51;
            this.tippDataGridView.RowTemplate.Height = 24;
            this.tippDataGridView.Size = new System.Drawing.Size(819, 380);
            this.tippDataGridView.TabIndex = 4;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kérdés";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Válasz";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TippKerdesTextBox);
            this.groupBox2.Controls.Add(this.tippHozzadButton);
            this.groupBox2.Controls.Add(this.TippValaszTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 142);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adatfelvétel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kérdés:";
            // 
            // TippKerdesTextBox
            // 
            this.TippKerdesTextBox.Location = new System.Drawing.Point(6, 38);
            this.TippKerdesTextBox.Name = "TippKerdesTextBox";
            this.TippKerdesTextBox.Size = new System.Drawing.Size(806, 22);
            this.TippKerdesTextBox.TabIndex = 1;
            // 
            // tippHozzadButton
            // 
            this.tippHozzadButton.Location = new System.Drawing.Point(6, 111);
            this.tippHozzadButton.Name = "tippHozzadButton";
            this.tippHozzadButton.Size = new System.Drawing.Size(806, 23);
            this.tippHozzadButton.TabIndex = 3;
            this.tippHozzadButton.Text = "HOZZÁAD";
            this.tippHozzadButton.UseVisualStyleBackColor = true;
            this.tippHozzadButton.Click += new System.EventHandler(this.tippHozzadButton_Click);
            // 
            // TippValaszTextBox
            // 
            this.TippValaszTextBox.Location = new System.Drawing.Point(6, 83);
            this.TippValaszTextBox.Name = "TippValaszTextBox";
            this.TippValaszTextBox.Size = new System.Drawing.Size(806, 22);
            this.TippValaszTextBox.TabIndex = 1;
            this.TippValaszTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TippValaszTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Helyes válasz:";
            // 
            // adatTorlesButton
            // 
            this.adatTorlesButton.Location = new System.Drawing.Point(13, 392);
            this.adatTorlesButton.Name = "adatTorlesButton";
            this.adatTorlesButton.Size = new System.Drawing.Size(806, 23);
            this.adatTorlesButton.TabIndex = 6;
            this.adatTorlesButton.Text = "Kivalasztott elem törlése";
            this.adatTorlesButton.UseVisualStyleBackColor = true;
            this.adatTorlesButton.Click += new System.EventHandler(this.tippTorlolButton_Click);
            // 
            // AdatkezeloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 602);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdatkezeloForm";
            this.Text = "Adatkezelő";
            this.tabControl1.ResumeLayout(false);
            this.kerdesekTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kerdeskDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tippTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tippDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage kerdesekTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label kerdesLabel;
        private System.Windows.Forms.TextBox kerdesTextBox;
        private System.Windows.Forms.Button hozzaAddButton;
        private System.Windows.Forms.TextBox helyesValaszTextBox;
        private System.Windows.Forms.Label helytelenValasz3Label;
        private System.Windows.Forms.TextBox helytelenValasz1TextBox;
        private System.Windows.Forms.Label helytelenValasz2Label;
        private System.Windows.Forms.Label helyesValaszLabel;
        private System.Windows.Forms.TextBox helytelenValasz3TextBox;
        private System.Windows.Forms.TextBox helytelenValasz2TextBox;
        private System.Windows.Forms.Label helytelenValasz1Label;
        private System.Windows.Forms.Button torolButton;
        private System.Windows.Forms.TabPage tippTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TippKerdesTextBox;
        private System.Windows.Forms.Button tippHozzadButton;
        private System.Windows.Forms.TextBox TippValaszTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button adatTorlesButton;
        private System.Windows.Forms.DataGridView kerdeskDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView tippDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}