namespace HarcosokApplication
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
            this.textBox1HarcosNeve = new System.Windows.Forms.TextBox();
            this.textBox2KepessegNeve = new System.Windows.Forms.TextBox();
            this.textBox3KepessegLeirasa = new System.Windows.Forms.TextBox();
            this.textBox4KepessegModositasa = new System.Windows.Forms.TextBox();
            this.comboBox1Kepesseghasznaloja = new System.Windows.Forms.ComboBox();
            this.listBox1Harcosok = new System.Windows.Forms.ListBox();
            this.listBox2Kepessegek = new System.Windows.Forms.ListBox();
            this.button1Letrehozas = new System.Windows.Forms.Button();
            this.button2Hozzaadas = new System.Windows.Forms.Button();
            this.button3Modositas = new System.Windows.Forms.Button();
            this.button4Torles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1HarcosNeve
            // 
            this.textBox1HarcosNeve.Location = new System.Drawing.Point(64, 29);
            this.textBox1HarcosNeve.Name = "textBox1HarcosNeve";
            this.textBox1HarcosNeve.Size = new System.Drawing.Size(198, 20);
            this.textBox1HarcosNeve.TabIndex = 0;
            // 
            // textBox2KepessegNeve
            // 
            this.textBox2KepessegNeve.Location = new System.Drawing.Point(88, 132);
            this.textBox2KepessegNeve.Name = "textBox2KepessegNeve";
            this.textBox2KepessegNeve.Size = new System.Drawing.Size(263, 20);
            this.textBox2KepessegNeve.TabIndex = 1;
            // 
            // textBox3KepessegLeirasa
            // 
            this.textBox3KepessegLeirasa.Location = new System.Drawing.Point(377, 95);
            this.textBox3KepessegLeirasa.Multiline = true;
            this.textBox3KepessegLeirasa.Name = "textBox3KepessegLeirasa";
            this.textBox3KepessegLeirasa.Size = new System.Drawing.Size(281, 57);
            this.textBox3KepessegLeirasa.TabIndex = 2;
            // 
            // textBox4KepessegModositasa
            // 
            this.textBox4KepessegModositasa.Location = new System.Drawing.Point(377, 232);
            this.textBox4KepessegModositasa.Multiline = true;
            this.textBox4KepessegModositasa.Name = "textBox4KepessegModositasa";
            this.textBox4KepessegModositasa.Size = new System.Drawing.Size(281, 123);
            this.textBox4KepessegModositasa.TabIndex = 3;
            // 
            // comboBox1Kepesseghasznaloja
            // 
            this.comboBox1Kepesseghasznaloja.FormattingEnabled = true;
            this.comboBox1Kepesseghasznaloja.Location = new System.Drawing.Point(88, 95);
            this.comboBox1Kepesseghasznaloja.Name = "comboBox1Kepesseghasznaloja";
            this.comboBox1Kepesseghasznaloja.Size = new System.Drawing.Size(263, 21);
            this.comboBox1Kepesseghasznaloja.TabIndex = 4;
            // 
            // listBox1Harcosok
            // 
            this.listBox1Harcosok.FormattingEnabled = true;
            this.listBox1Harcosok.Location = new System.Drawing.Point(12, 232);
            this.listBox1Harcosok.Name = "listBox1Harcosok";
            this.listBox1Harcosok.Size = new System.Drawing.Size(162, 225);
            this.listBox1Harcosok.TabIndex = 5;
            this.listBox1Harcosok.SelectedIndexChanged += new System.EventHandler(this.listBox1Harcosok_SelectedIndexChanged);
            // 
            // listBox2Kepessegek
            // 
            this.listBox2Kepessegek.FormattingEnabled = true;
            this.listBox2Kepessegek.Location = new System.Drawing.Point(193, 232);
            this.listBox2Kepessegek.Name = "listBox2Kepessegek";
            this.listBox2Kepessegek.Size = new System.Drawing.Size(165, 225);
            this.listBox2Kepessegek.TabIndex = 6;
            this.listBox2Kepessegek.SelectedIndexChanged += new System.EventHandler(this.listBox2Kepessegek_SelectedIndexChanged);
            // 
            // button1Letrehozas
            // 
            this.button1Letrehozas.Location = new System.Drawing.Point(276, 29);
            this.button1Letrehozas.Name = "button1Letrehozas";
            this.button1Letrehozas.Size = new System.Drawing.Size(75, 23);
            this.button1Letrehozas.TabIndex = 7;
            this.button1Letrehozas.Text = "Létrehozás";
            this.button1Letrehozas.UseVisualStyleBackColor = true;
            this.button1Letrehozas.Click += new System.EventHandler(this.button1Letrehozas_Click);
            // 
            // button2Hozzaadas
            // 
            this.button2Hozzaadas.Location = new System.Drawing.Point(88, 158);
            this.button2Hozzaadas.Name = "button2Hozzaadas";
            this.button2Hozzaadas.Size = new System.Drawing.Size(75, 32);
            this.button2Hozzaadas.TabIndex = 8;
            this.button2Hozzaadas.Text = "Hozzáad";
            this.button2Hozzaadas.UseVisualStyleBackColor = true;
            this.button2Hozzaadas.Click += new System.EventHandler(this.button2Hozzaadas_Click);
            // 
            // button3Modositas
            // 
            this.button3Modositas.Location = new System.Drawing.Point(583, 370);
            this.button3Modositas.Name = "button3Modositas";
            this.button3Modositas.Size = new System.Drawing.Size(75, 23);
            this.button3Modositas.TabIndex = 9;
            this.button3Modositas.Text = "Módosítás";
            this.button3Modositas.UseVisualStyleBackColor = true;
            this.button3Modositas.Click += new System.EventHandler(this.button3Modositas_Click);
            // 
            // button4Torles
            // 
            this.button4Torles.Location = new System.Drawing.Point(377, 434);
            this.button4Torles.Name = "button4Torles";
            this.button4Torles.Size = new System.Drawing.Size(75, 23);
            this.button4Torles.TabIndex = 10;
            this.button4Torles.Text = "Törlés";
            this.button4Torles.UseVisualStyleBackColor = true;
            this.button4Torles.Click += new System.EventHandler(this.button4Torles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Harcosok létrehozása";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Képesség hozzáadása";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Leírás:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Használó:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kép. neve:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Harcosok:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Képességek:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Képességek leírása";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 489);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4Torles);
            this.Controls.Add(this.button3Modositas);
            this.Controls.Add(this.button2Hozzaadas);
            this.Controls.Add(this.button1Letrehozas);
            this.Controls.Add(this.listBox2Kepessegek);
            this.Controls.Add(this.listBox1Harcosok);
            this.Controls.Add(this.comboBox1Kepesseghasznaloja);
            this.Controls.Add(this.textBox4KepessegModositasa);
            this.Controls.Add(this.textBox3KepessegLeirasa);
            this.Controls.Add(this.textBox2KepessegNeve);
            this.Controls.Add(this.textBox1HarcosNeve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1HarcosNeve;
        private System.Windows.Forms.TextBox textBox2KepessegNeve;
        private System.Windows.Forms.TextBox textBox3KepessegLeirasa;
        private System.Windows.Forms.TextBox textBox4KepessegModositasa;
        private System.Windows.Forms.ComboBox comboBox1Kepesseghasznaloja;
        private System.Windows.Forms.ListBox listBox1Harcosok;
        private System.Windows.Forms.ListBox listBox2Kepessegek;
        private System.Windows.Forms.Button button1Letrehozas;
        private System.Windows.Forms.Button button2Hozzaadas;
        private System.Windows.Forms.Button button3Modositas;
        private System.Windows.Forms.Button button4Torles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

