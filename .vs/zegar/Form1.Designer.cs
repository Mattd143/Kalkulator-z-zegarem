namespace zegar
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.godzina_minuta = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.dzien = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.przycisk_zamiana = new System.Windows.Forms.Button();
            this.tarcza = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tarcza)).BeginInit();
            this.SuspendLayout();
            // 
            // godzina_minuta
            // 
            this.godzina_minuta.AutoSize = true;
            this.godzina_minuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.godzina_minuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.godzina_minuta.Location = new System.Drawing.Point(31, 39);
            this.godzina_minuta.Name = "godzina_minuta";
            this.godzina_minuta.Size = new System.Drawing.Size(212, 75);
            this.godzina_minuta.TabIndex = 0;
            this.godzina_minuta.Text = "label1";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.data.Location = new System.Drawing.Point(12, 159);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(111, 41);
            this.data.TabIndex = 2;
            this.data.Text = "label3";
            // 
            // dzien
            // 
            this.dzien.AutoSize = true;
            this.dzien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dzien.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzien.Location = new System.Drawing.Point(12, 256);
            this.dzien.Name = "dzien";
            this.dzien.Size = new System.Drawing.Size(111, 41);
            this.dzien.TabIndex = 3;
            this.dzien.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // przycisk_zamiana
            // 
            this.przycisk_zamiana.Location = new System.Drawing.Point(240, 350);
            this.przycisk_zamiana.Name = "przycisk_zamiana";
            this.przycisk_zamiana.Size = new System.Drawing.Size(262, 58);
            this.przycisk_zamiana.TabIndex = 5;
            this.przycisk_zamiana.Text = "zmień sposób wyświetlania zegara";
            this.przycisk_zamiana.UseVisualStyleBackColor = true;
            this.przycisk_zamiana.Click += new System.EventHandler(this.przycisk_zamiana_Click);
            // 
            // tarcza
            // 
            this.tarcza.Location = new System.Drawing.Point(324, 12);
            this.tarcza.Name = "tarcza";
            this.tarcza.Size = new System.Drawing.Size(302, 302);
            this.tarcza.TabIndex = 6;
            this.tarcza.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tarcza);
            this.Controls.Add(this.przycisk_zamiana);
            this.Controls.Add(this.dzien);
            this.Controls.Add(this.data);
            this.Controls.Add(this.godzina_minuta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarcza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label godzina_minuta;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label dzien;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button przycisk_zamiana;
        private System.Windows.Forms.PictureBox tarcza;
    }
}

