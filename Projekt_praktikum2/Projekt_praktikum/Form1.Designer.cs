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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPavza = new System.Windows.Forms.RadioButton();
            this.radioNota = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioOsminka = new System.Windows.Forms.RadioButton();
            this.radioCelinka = new System.Windows.Forms.RadioButton();
            this.radioCetrtinka = new System.Windows.Forms.RadioButton();
            this.radioPolovinka = new System.Windows.Forms.RadioButton();
            this.comboKljuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.textBoxTaktStevec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTaktImenovalec = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioOdstrani = new System.Windows.Forms.RadioButton();
            this.radioDodaj = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioNavadna = new System.Windows.Forms.RadioButton();
            this.radioZvisana = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPavza);
            this.groupBox1.Controls.Add(this.radioNota);
            this.groupBox1.Location = new System.Drawing.Point(718, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj";
            // 
            // radioPavza
            // 
            this.radioPavza.AutoSize = true;
            this.radioPavza.Location = new System.Drawing.Point(6, 42);
            this.radioPavza.Name = "radioPavza";
            this.radioPavza.Size = new System.Drawing.Size(55, 17);
            this.radioPavza.TabIndex = 4;
            this.radioPavza.TabStop = true;
            this.radioPavza.Text = "Pavzo";
            this.radioPavza.UseVisualStyleBackColor = true;
            // 
            // radioNota
            // 
            this.radioNota.AutoSize = true;
            this.radioNota.Location = new System.Drawing.Point(6, 19);
            this.radioNota.Name = "radioNota";
            this.radioNota.Size = new System.Drawing.Size(48, 17);
            this.radioNota.TabIndex = 0;
            this.radioNota.TabStop = true;
            this.radioNota.Text = "Noto";
            this.radioNota.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioOsminka);
            this.groupBox2.Controls.Add(this.radioCelinka);
            this.groupBox2.Controls.Add(this.radioCetrtinka);
            this.groupBox2.Controls.Add(this.radioPolovinka);
            this.groupBox2.Location = new System.Drawing.Point(718, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 112);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trajanje";
            // 
            // radioOsminka
            // 
            this.radioOsminka.AutoSize = true;
            this.radioOsminka.Location = new System.Drawing.Point(6, 88);
            this.radioOsminka.Name = "radioOsminka";
            this.radioOsminka.Size = new System.Drawing.Size(66, 17);
            this.radioOsminka.TabIndex = 8;
            this.radioOsminka.TabStop = true;
            this.radioOsminka.Text = "Osminka";
            this.radioOsminka.UseVisualStyleBackColor = true;
            // 
            // radioCelinka
            // 
            this.radioCelinka.AutoSize = true;
            this.radioCelinka.Location = new System.Drawing.Point(6, 19);
            this.radioCelinka.Name = "radioCelinka";
            this.radioCelinka.Size = new System.Drawing.Size(60, 17);
            this.radioCelinka.TabIndex = 5;
            this.radioCelinka.TabStop = true;
            this.radioCelinka.Text = "Celinka";
            this.radioCelinka.UseVisualStyleBackColor = true;
            // 
            // radioCetrtinka
            // 
            this.radioCetrtinka.AutoSize = true;
            this.radioCetrtinka.Location = new System.Drawing.Point(6, 65);
            this.radioCetrtinka.Name = "radioCetrtinka";
            this.radioCetrtinka.Size = new System.Drawing.Size(67, 17);
            this.radioCetrtinka.TabIndex = 7;
            this.radioCetrtinka.TabStop = true;
            this.radioCetrtinka.Text = "Četrtinka";
            this.radioCetrtinka.UseVisualStyleBackColor = true;
            // 
            // radioPolovinka
            // 
            this.radioPolovinka.AutoSize = true;
            this.radioPolovinka.Location = new System.Drawing.Point(6, 42);
            this.radioPolovinka.Name = "radioPolovinka";
            this.radioPolovinka.Size = new System.Drawing.Size(72, 17);
            this.radioPolovinka.TabIndex = 6;
            this.radioPolovinka.TabStop = true;
            this.radioPolovinka.Text = "Polovinka";
            this.radioPolovinka.UseVisualStyleBackColor = true;
            // 
            // comboKljuc
            // 
            this.comboKljuc.FormattingEnabled = true;
            this.comboKljuc.Items.AddRange(new object[] {
            "Violinski",
            "Basovski"});
            this.comboKljuc.Location = new System.Drawing.Point(718, 383);
            this.comboKljuc.Name = "comboKljuc";
            this.comboKljuc.Size = new System.Drawing.Size(121, 21);
            this.comboKljuc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ključ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tempo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(721, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Takt:";
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.Location = new System.Drawing.Point(718, 435);
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTempo.TabIndex = 9;
            // 
            // textBoxTaktStevec
            // 
            this.textBoxTaktStevec.Location = new System.Drawing.Point(718, 488);
            this.textBoxTaktStevec.Name = "textBoxTaktStevec";
            this.textBoxTaktStevec.Size = new System.Drawing.Size(35, 20);
            this.textBoxTaktStevec.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(752, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "/";
            // 
            // textBoxTaktImenovalec
            // 
            this.textBoxTaktImenovalec.Location = new System.Drawing.Point(761, 488);
            this.textBoxTaktImenovalec.Name = "textBoxTaktImenovalec";
            this.textBoxTaktImenovalec.Size = new System.Drawing.Size(35, 20);
            this.textBoxTaktImenovalec.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioOdstrani);
            this.groupBox3.Controls.Add(this.radioDodaj);
            this.groupBox3.Location = new System.Drawing.Point(718, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 70);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opravilo";
            // 
            // radioOdstrani
            // 
            this.radioOdstrani.AutoSize = true;
            this.radioOdstrani.Location = new System.Drawing.Point(6, 42);
            this.radioOdstrani.Name = "radioOdstrani";
            this.radioOdstrani.Size = new System.Drawing.Size(64, 17);
            this.radioOdstrani.TabIndex = 1;
            this.radioOdstrani.TabStop = true;
            this.radioOdstrani.Text = "Odstrani";
            this.radioOdstrani.UseVisualStyleBackColor = true;
            // 
            // radioDodaj
            // 
            this.radioDodaj.AutoSize = true;
            this.radioDodaj.Location = new System.Drawing.Point(6, 19);
            this.radioDodaj.Name = "radioDodaj";
            this.radioDodaj.Size = new System.Drawing.Size(53, 17);
            this.radioDodaj.TabIndex = 0;
            this.radioDodaj.TabStop = true;
            this.radioDodaj.Text = "Dodaj";
            this.radioDodaj.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioZvisana);
            this.groupBox4.Controls.Add(this.radioNavadna);
            this.groupBox4.Location = new System.Drawing.Point(718, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(153, 67);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nota";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 521);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBoxTaktImenovalec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTaktStevec);
            this.Controls.Add(this.textBoxTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboKljuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioNota;
        private System.Windows.Forms.RadioButton radioPavza;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioOsminka;
        private System.Windows.Forms.RadioButton radioCelinka;
        private System.Windows.Forms.RadioButton radioCetrtinka;
        private System.Windows.Forms.RadioButton radioPolovinka;
        private System.Windows.Forms.ComboBox comboKljuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTempo;
        private System.Windows.Forms.TextBox textBoxTaktStevec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTaktImenovalec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioOdstrani;
        private System.Windows.Forms.RadioButton radioDodaj;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioZvisana;
        private System.Windows.Forms.RadioButton radioNavadna;
    }
}

