namespace Projekt_praktikum
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
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.comboKljuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioZvisana = new System.Windows.Forms.RadioButton();
            this.radioNavadna = new System.Windows.Forms.RadioButton();
            this.comboTempo = new System.Windows.Forms.ComboBox();
            this.comboTaktStevec = new System.Windows.Forms.ComboBox();
            this.comboTaktImenovalec = new System.Windows.Forms.ComboBox();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(700, 500);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseClick);
            // 
            // comboKljuc
            // 
            this.comboKljuc.FormattingEnabled = true;
            this.comboKljuc.Items.AddRange(new object[] {
            "Violinski",
            "Basovski"});
            this.comboKljuc.Location = new System.Drawing.Point(718, 98);
            this.comboKljuc.Name = "comboKljuc";
            this.comboKljuc.Size = new System.Drawing.Size(121, 21);
            this.comboKljuc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ključ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tempo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(721, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Takt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(752, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "/";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioZvisana);
            this.groupBox4.Controls.Add(this.radioNavadna);
            this.groupBox4.Location = new System.Drawing.Point(718, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(153, 67);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nota";
            // 
            // radioZvisana
            // 
            this.radioZvisana.AutoSize = true;
            this.radioZvisana.Location = new System.Drawing.Point(6, 42);
            this.radioZvisana.Name = "radioZvisana";
            this.radioZvisana.Size = new System.Drawing.Size(63, 17);
            this.radioZvisana.TabIndex = 7;
            this.radioZvisana.TabStop = true;
            this.radioZvisana.Text = "Zvišana";
            this.radioZvisana.UseVisualStyleBackColor = true;
            // 
            // radioNavadna
            // 
            this.radioNavadna.AutoSize = true;
            this.radioNavadna.Location = new System.Drawing.Point(6, 19);
            this.radioNavadna.Name = "radioNavadna";
            this.radioNavadna.Size = new System.Drawing.Size(69, 17);
            this.radioNavadna.TabIndex = 6;
            this.radioNavadna.TabStop = true;
            this.radioNavadna.Text = "Navadna";
            this.radioNavadna.UseVisualStyleBackColor = true;
            // 
            // comboTempo
            // 
            this.comboTempo.FormattingEnabled = true;
            this.comboTempo.Location = new System.Drawing.Point(718, 150);
            this.comboTempo.Name = "comboTempo";
            this.comboTempo.Size = new System.Drawing.Size(121, 21);
            this.comboTempo.TabIndex = 15;
            this.comboTempo.SelectedIndexChanged += new System.EventHandler(this.comboTempo_SelectedIndexChanged);
            // 
            // comboTaktStevec
            // 
            this.comboTaktStevec.FormattingEnabled = true;
            this.comboTaktStevec.Location = new System.Drawing.Point(718, 203);
            this.comboTaktStevec.Name = "comboTaktStevec";
            this.comboTaktStevec.Size = new System.Drawing.Size(35, 21);
            this.comboTaktStevec.TabIndex = 16;
            this.comboTaktStevec.SelectedIndexChanged += new System.EventHandler(this.comboTaktStevec_SelectedIndexChanged);
            // 
            // comboTaktImenovalec
            // 
            this.comboTaktImenovalec.FormattingEnabled = true;
            this.comboTaktImenovalec.Location = new System.Drawing.Point(761, 203);
            this.comboTaktImenovalec.Name = "comboTaktImenovalec";
            this.comboTaktImenovalec.Size = new System.Drawing.Size(35, 21);
            this.comboTaktImenovalec.TabIndex = 17;
            this.comboTaktImenovalec.SelectedIndexChanged += new System.EventHandler(this.comboTaktImenovalec_SelectedIndexChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(715, 248);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 521);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.comboTaktImenovalec);
            this.Controls.Add(this.comboTaktStevec);
            this.Controls.Add(this.comboTempo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboKljuc);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.ComboBox comboKljuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioZvisana;
        private System.Windows.Forms.RadioButton radioNavadna;
        private System.Windows.Forms.ComboBox comboTempo;
        private System.Windows.Forms.ComboBox comboTaktStevec;
        private System.Windows.Forms.ComboBox comboTaktImenovalec;
        private System.Windows.Forms.Label labelInfo;
    }
}

