namespace Kalkulator_z_zegarem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.P_cztery = new System.Windows.Forms.Button();
            this.P_jeden = new System.Windows.Forms.Button();
            this.P_zero = new System.Windows.Forms.Button();
            this.P_siedem = new System.Windows.Forms.Button();
            this.P_osiem = new System.Windows.Forms.Button();
            this.P_kropka = new System.Windows.Forms.Button();
            this.P_dwa = new System.Windows.Forms.Button();
            this.P_piec = new System.Windows.Forms.Button();
            this.P_dziewiec = new System.Windows.Forms.Button();
            this.P_rownosc = new System.Windows.Forms.Button();
            this.P_trzy = new System.Windows.Forms.Button();
            this.P_szesc = new System.Windows.Forms.Button();
            this.P_clear = new System.Windows.Forms.Button();
            this.P_pierwiastek = new System.Windows.Forms.Button();
            this.P_dzielenie = new System.Windows.Forms.Button();
            this.P_minus = new System.Windows.Forms.Button();
            this.P_procent = new System.Windows.Forms.Button();
            this.P_znak = new System.Windows.Forms.Button();
            this.P_razy = new System.Windows.Forms.Button();
            this.P_plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(603, 52);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_cztery
            // 
            this.P_cztery.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_cztery.Location = new System.Drawing.Point(12, 205);
            this.P_cztery.Name = "P_cztery";
            this.P_cztery.Size = new System.Drawing.Size(101, 101);
            this.P_cztery.TabIndex = 1;
            this.P_cztery.Text = "4";
            this.P_cztery.UseVisualStyleBackColor = true;
            this.P_cztery.Click += new System.EventHandler(this.P_cztery_Click);
            this.P_cztery.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_jeden
            // 
            this.P_jeden.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_jeden.Location = new System.Drawing.Point(12, 312);
            this.P_jeden.Name = "P_jeden";
            this.P_jeden.Size = new System.Drawing.Size(101, 101);
            this.P_jeden.TabIndex = 2;
            this.P_jeden.Text = "1";
            this.P_jeden.UseVisualStyleBackColor = true;
            this.P_jeden.Click += new System.EventHandler(this.P_jeden_Click);
            this.P_jeden.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_zero
            // 
            this.P_zero.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_zero.Location = new System.Drawing.Point(12, 417);
            this.P_zero.Name = "P_zero";
            this.P_zero.Size = new System.Drawing.Size(101, 101);
            this.P_zero.TabIndex = 3;
            this.P_zero.Text = "0";
            this.P_zero.UseVisualStyleBackColor = true;
            this.P_zero.Click += new System.EventHandler(this.P_zero_Click);
            this.P_zero.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_siedem
            // 
            this.P_siedem.AutoSize = true;
            this.P_siedem.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_siedem.Location = new System.Drawing.Point(12, 98);
            this.P_siedem.Name = "P_siedem";
            this.P_siedem.Size = new System.Drawing.Size(101, 101);
            this.P_siedem.TabIndex = 4;
            this.P_siedem.Text = "7";
            this.P_siedem.UseVisualStyleBackColor = true;
            this.P_siedem.Click += new System.EventHandler(this.P_siedem_Click);
            this.P_siedem.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_osiem
            // 
            this.P_osiem.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_osiem.Location = new System.Drawing.Point(119, 98);
            this.P_osiem.Name = "P_osiem";
            this.P_osiem.Size = new System.Drawing.Size(101, 101);
            this.P_osiem.TabIndex = 8;
            this.P_osiem.Text = "8";
            this.P_osiem.UseVisualStyleBackColor = true;
            this.P_osiem.Click += new System.EventHandler(this.P_osiem_Click);
            this.P_osiem.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_kropka
            // 
            this.P_kropka.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_kropka.Location = new System.Drawing.Point(119, 417);
            this.P_kropka.Name = "P_kropka";
            this.P_kropka.Size = new System.Drawing.Size(101, 101);
            this.P_kropka.TabIndex = 7;
            this.P_kropka.Text = ".";
            this.P_kropka.UseVisualStyleBackColor = true;
            this.P_kropka.Click += new System.EventHandler(this.P_kropka_Click);
            this.P_kropka.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_dwa
            // 
            this.P_dwa.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_dwa.Location = new System.Drawing.Point(119, 312);
            this.P_dwa.Name = "P_dwa";
            this.P_dwa.Size = new System.Drawing.Size(101, 101);
            this.P_dwa.TabIndex = 6;
            this.P_dwa.Text = "2";
            this.P_dwa.UseVisualStyleBackColor = true;
            this.P_dwa.Click += new System.EventHandler(this.P_dwa_Click);
            this.P_dwa.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_piec
            // 
            this.P_piec.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_piec.Location = new System.Drawing.Point(119, 205);
            this.P_piec.Name = "P_piec";
            this.P_piec.Size = new System.Drawing.Size(101, 101);
            this.P_piec.TabIndex = 5;
            this.P_piec.Text = "5";
            this.P_piec.UseVisualStyleBackColor = true;
            this.P_piec.Click += new System.EventHandler(this.P_piec_Click);
            this.P_piec.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_dziewiec
            // 
            this.P_dziewiec.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_dziewiec.Location = new System.Drawing.Point(226, 98);
            this.P_dziewiec.Name = "P_dziewiec";
            this.P_dziewiec.Size = new System.Drawing.Size(101, 101);
            this.P_dziewiec.TabIndex = 12;
            this.P_dziewiec.Text = "9";
            this.P_dziewiec.UseVisualStyleBackColor = true;
            this.P_dziewiec.Click += new System.EventHandler(this.P_dziewiec_Click);
            this.P_dziewiec.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_rownosc
            // 
            this.P_rownosc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_rownosc.Location = new System.Drawing.Point(226, 417);
            this.P_rownosc.Name = "P_rownosc";
            this.P_rownosc.Size = new System.Drawing.Size(101, 101);
            this.P_rownosc.TabIndex = 11;
            this.P_rownosc.Text = "=";
            this.P_rownosc.UseVisualStyleBackColor = true;
            this.P_rownosc.Click += new System.EventHandler(this.P_rownosc_Click);
            this.P_rownosc.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_trzy
            // 
            this.P_trzy.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_trzy.Location = new System.Drawing.Point(226, 312);
            this.P_trzy.Name = "P_trzy";
            this.P_trzy.Size = new System.Drawing.Size(101, 101);
            this.P_trzy.TabIndex = 10;
            this.P_trzy.Text = "3";
            this.P_trzy.UseVisualStyleBackColor = true;
            this.P_trzy.Click += new System.EventHandler(this.P_trzy_Click);
            this.P_trzy.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_szesc
            // 
            this.P_szesc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_szesc.Location = new System.Drawing.Point(226, 205);
            this.P_szesc.Name = "P_szesc";
            this.P_szesc.Size = new System.Drawing.Size(101, 101);
            this.P_szesc.TabIndex = 9;
            this.P_szesc.Text = "6";
            this.P_szesc.UseVisualStyleBackColor = true;
            this.P_szesc.Click += new System.EventHandler(this.P_szesc_Click);
            this.P_szesc.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_clear
            // 
            this.P_clear.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_clear.Location = new System.Drawing.Point(514, 98);
            this.P_clear.Name = "P_clear";
            this.P_clear.Size = new System.Drawing.Size(101, 101);
            this.P_clear.TabIndex = 16;
            this.P_clear.Text = "C";
            this.P_clear.UseVisualStyleBackColor = true;
            this.P_clear.Click += new System.EventHandler(this.P_clear_Click);
            this.P_clear.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_pierwiastek
            // 
            this.P_pierwiastek.AutoSize = true;
            this.P_pierwiastek.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_pierwiastek.Location = new System.Drawing.Point(514, 205);
            this.P_pierwiastek.Name = "P_pierwiastek";
            this.P_pierwiastek.Size = new System.Drawing.Size(101, 101);
            this.P_pierwiastek.TabIndex = 15;
            this.P_pierwiastek.Text = "√";
            this.P_pierwiastek.UseVisualStyleBackColor = true;
            this.P_pierwiastek.Click += new System.EventHandler(this.P_pierwiastek_Click);
            this.P_pierwiastek.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_dzielenie
            // 
            this.P_dzielenie.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_dzielenie.Location = new System.Drawing.Point(514, 419);
            this.P_dzielenie.Name = "P_dzielenie";
            this.P_dzielenie.Size = new System.Drawing.Size(101, 101);
            this.P_dzielenie.TabIndex = 14;
            this.P_dzielenie.Text = "/";
            this.P_dzielenie.UseVisualStyleBackColor = true;
            this.P_dzielenie.Click += new System.EventHandler(this.P_dzielenie_Click);
            this.P_dzielenie.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_minus
            // 
            this.P_minus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_minus.Location = new System.Drawing.Point(514, 312);
            this.P_minus.Name = "P_minus";
            this.P_minus.Size = new System.Drawing.Size(101, 101);
            this.P_minus.TabIndex = 13;
            this.P_minus.Text = "-";
            this.P_minus.UseVisualStyleBackColor = true;
            this.P_minus.Click += new System.EventHandler(this.P_minus_Click);
            this.P_minus.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_procent
            // 
            this.P_procent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_procent.Location = new System.Drawing.Point(407, 419);
            this.P_procent.Name = "P_procent";
            this.P_procent.Size = new System.Drawing.Size(101, 101);
            this.P_procent.TabIndex = 20;
            this.P_procent.Text = "%";
            this.P_procent.UseVisualStyleBackColor = true;
            this.P_procent.Click += new System.EventHandler(this.P_procent_Click);
            this.P_procent.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_znak
            // 
            this.P_znak.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_znak.Location = new System.Drawing.Point(407, 98);
            this.P_znak.Name = "P_znak";
            this.P_znak.Size = new System.Drawing.Size(101, 101);
            this.P_znak.TabIndex = 19;
            this.P_znak.Text = "+/-";
            this.P_znak.UseVisualStyleBackColor = true;
            this.P_znak.Click += new System.EventHandler(this.P_znak_Click);
            this.P_znak.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_razy
            // 
            this.P_razy.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_razy.Location = new System.Drawing.Point(407, 205);
            this.P_razy.Name = "P_razy";
            this.P_razy.Size = new System.Drawing.Size(101, 101);
            this.P_razy.TabIndex = 18;
            this.P_razy.Text = "x";
            this.P_razy.UseVisualStyleBackColor = true;
            this.P_razy.Click += new System.EventHandler(this.P_razy_Click);
            this.P_razy.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // P_plus
            // 
            this.P_plus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_plus.Location = new System.Drawing.Point(407, 312);
            this.P_plus.Name = "P_plus";
            this.P_plus.Size = new System.Drawing.Size(101, 101);
            this.P_plus.TabIndex = 17;
            this.P_plus.Text = "+";
            this.P_plus.UseVisualStyleBackColor = true;
            this.P_plus.Click += new System.EventHandler(this.P_plus_Click);
            this.P_plus.Resize += new System.EventHandler(this.P_procent_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(626, 530);
            this.Controls.Add(this.P_procent);
            this.Controls.Add(this.P_znak);
            this.Controls.Add(this.P_razy);
            this.Controls.Add(this.P_plus);
            this.Controls.Add(this.P_clear);
            this.Controls.Add(this.P_pierwiastek);
            this.Controls.Add(this.P_dzielenie);
            this.Controls.Add(this.P_minus);
            this.Controls.Add(this.P_dziewiec);
            this.Controls.Add(this.P_rownosc);
            this.Controls.Add(this.P_trzy);
            this.Controls.Add(this.P_szesc);
            this.Controls.Add(this.P_osiem);
            this.Controls.Add(this.P_kropka);
            this.Controls.Add(this.P_dwa);
            this.Controls.Add(this.P_piec);
            this.Controls.Add(this.P_siedem);
            this.Controls.Add(this.P_zero);
            this.Controls.Add(this.P_jeden);
            this.Controls.Add(this.P_cztery);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button P_cztery;
        private Button P_jeden;
        private Button P_zero;
        private Button P_siedem;
        private Button P_osiem;
        private Button P_kropka;
        private Button P_dwa;
        private Button P_piec;
        private Button P_dziewiec;
        private Button P_rownosc;
        private Button P_trzy;
        private Button P_szesc;
        private Button P_clear;
        private Button P_pierwiastek;
        private Button P_dzielenie;
        private Button P_minus;
        private Button P_procent;
        private Button P_znak;
        private Button P_razy;
        private Button P_plus;
    }
}