namespace Korona
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nemeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.elerhetosegTextBox = new System.Windows.Forms.TextBox();
            this.tajszamTextBox = new System.Windows.Forms.TextBox();
            this.eletkorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AlapbetegsegCheckBox = new System.Windows.Forms.CheckBox();
            this.halalozasdatumDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.halalozasSaveBtn = new System.Windows.Forms.Button();
            this.betegneveComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.eletkorTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.elerhetosegTextBox);
            this.groupBox1.Controls.Add(this.save_btn);
            this.groupBox1.Controls.Add(this.tajszamTextBox);
            this.groupBox1.Controls.Add(this.nevTextBox);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nemeComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beteg felvétele";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elérhetőség";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Neme";
            // 
            // nemeComboBox
            // 
            this.nemeComboBox.FormattingEnabled = true;
            this.nemeComboBox.Items.AddRange(new object[] {
            "Férfi",
            "Nő"});
            this.nemeComboBox.Location = new System.Drawing.Point(157, 247);
            this.nemeComboBox.Name = "nemeComboBox";
            this.nemeComboBox.Size = new System.Drawing.Size(100, 28);
            this.nemeComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tajszám";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Életkor";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(294, 292);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(127, 49);
            this.save_btn.TabIndex = 12;
            this.save_btn.Text = "Mentés";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(157, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 26);
            this.idTextBox.TabIndex = 13;
            this.idTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nevTextBox
            // 
            this.nevTextBox.Location = new System.Drawing.Point(157, 90);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(100, 26);
            this.nevTextBox.TabIndex = 14;
            // 
            // elerhetosegTextBox
            // 
            this.elerhetosegTextBox.Location = new System.Drawing.Point(157, 195);
            this.elerhetosegTextBox.Name = "elerhetosegTextBox";
            this.elerhetosegTextBox.Size = new System.Drawing.Size(100, 26);
            this.elerhetosegTextBox.TabIndex = 15;
            // 
            // tajszamTextBox
            // 
            this.tajszamTextBox.Location = new System.Drawing.Point(157, 303);
            this.tajszamTextBox.Name = "tajszamTextBox";
            this.tajszamTextBox.Size = new System.Drawing.Size(100, 26);
            this.tajszamTextBox.TabIndex = 16;
            // 
            // eletkorTextBox
            // 
            this.eletkorTextBox.Location = new System.Drawing.Point(157, 146);
            this.eletkorTextBox.Name = "eletkorTextBox";
            this.eletkorTextBox.Size = new System.Drawing.Size(100, 26);
            this.eletkorTextBox.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.betegneveComboBox);
            this.groupBox2.Controls.Add(this.halalozasSaveBtn);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.halalozasdatumDateTimePicker1);
            this.groupBox2.Controls.Add(this.AlapbetegsegCheckBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.hIdTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(485, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 366);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Halálozási adatok felvétele";
            // 
            // hIdTextBox
            // 
            this.hIdTextBox.Location = new System.Drawing.Point(201, 59);
            this.hIdTextBox.Name = "hIdTextBox";
            this.hIdTextBox.Size = new System.Drawing.Size(200, 26);
            this.hIdTextBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Beteg neve";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Alapbetegség";
            // 
            // AlapbetegsegCheckBox
            // 
            this.AlapbetegsegCheckBox.AutoSize = true;
            this.AlapbetegsegCheckBox.Location = new System.Drawing.Point(201, 182);
            this.AlapbetegsegCheckBox.Name = "AlapbetegsegCheckBox";
            this.AlapbetegsegCheckBox.Size = new System.Drawing.Size(33, 24);
            this.AlapbetegsegCheckBox.TabIndex = 5;
            this.AlapbetegsegCheckBox.Text = " ";
            this.AlapbetegsegCheckBox.UseVisualStyleBackColor = true;
            // 
            // halalozasdatumDateTimePicker1
            // 
            this.halalozasdatumDateTimePicker1.Location = new System.Drawing.Point(201, 227);
            this.halalozasdatumDateTimePicker1.Name = "halalozasdatumDateTimePicker1";
            this.halalozasdatumDateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.halalozasdatumDateTimePicker1.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Halálozás dátuma";
            // 
            // halalozasSaveBtn
            // 
            this.halalozasSaveBtn.Location = new System.Drawing.Point(171, 294);
            this.halalozasSaveBtn.Name = "halalozasSaveBtn";
            this.halalozasSaveBtn.Size = new System.Drawing.Size(109, 51);
            this.halalozasSaveBtn.TabIndex = 8;
            this.halalozasSaveBtn.Text = "Mentés";
            this.halalozasSaveBtn.UseVisualStyleBackColor = true;
            this.halalozasSaveBtn.Click += new System.EventHandler(this.halalozasSaveBtn_Click);
            // 
            // betegneveComboBox
            // 
            this.betegneveComboBox.FormattingEnabled = true;
            this.betegneveComboBox.Location = new System.Drawing.Point(201, 120);
            this.betegneveComboBox.Name = "betegneveComboBox";
            this.betegneveComboBox.Size = new System.Drawing.Size(200, 28);
            this.betegneveComboBox.TabIndex = 9;
            this.betegneveComboBox.SelectedIndexChanged += new System.EventHandler(this.betegneveComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox nemeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox eletkorTextBox;
        private System.Windows.Forms.TextBox tajszamTextBox;
        private System.Windows.Forms.TextBox elerhetosegTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button halalozasSaveBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker halalozasdatumDateTimePicker1;
        private System.Windows.Forms.CheckBox AlapbetegsegCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox hIdTextBox;
        private System.Windows.Forms.ComboBox betegneveComboBox;
    }
}

