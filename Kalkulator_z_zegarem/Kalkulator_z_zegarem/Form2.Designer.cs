namespace Kalkulator_z_zegarem
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.

        public static int loo = 0;           // definicja zmiennej której użyjemy, by zapobiec włączaniu kilku okienek na raz
        public Form1 kalkulator;
        
        
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(Form2.loo > 0)
            {
                Form2.loo--;
            }

            
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
            this.godzina_minuta = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.dzien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tarcza = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tarcza)).BeginInit();
            this.SuspendLayout();
            // 
            // godzina_minuta
            // 
            this.godzina_minuta.AutoSize = true;
            this.godzina_minuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.godzina_minuta.Location = new System.Drawing.Point(162, 34);
            this.godzina_minuta.Name = "godzina_minuta";
            this.godzina_minuta.Size = new System.Drawing.Size(249, 91);
            this.godzina_minuta.TabIndex = 0;
            this.godzina_minuta.Text = "label1";
            this.godzina_minuta.UseWaitCursor = true;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.data.Location = new System.Drawing.Point(209, 179);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(138, 51);
            this.data.TabIndex = 1;
            this.data.Text = "label2";
            // 
            // dzien
            // 
            this.dzien.AutoSize = true;
            this.dzien.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dzien.Location = new System.Drawing.Point(254, 274);
            this.dzien.Name = "dzien";
            this.dzien.Size = new System.Drawing.Size(138, 51);
            this.dzien.TabIndex = 2;
            this.dzien.Text = "label3";
            this.dzien.Click += new System.EventHandler(this.dzien_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Location = new System.Drawing.Point(171, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zmień sposób wyświetlania zegara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tarcza
            // 
            this.tarcza.Location = new System.Drawing.Point(187, 34);
            this.tarcza.Name = "tarcza";
            this.tarcza.Size = new System.Drawing.Size(388, 314);
            this.tarcza.TabIndex = 4;
            this.tarcza.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(679, 467);
            this.Controls.Add(this.tarcza);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dzien);
            this.Controls.Add(this.data);
            this.Controls.Add(this.godzina_minuta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarcza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label godzina_minuta;
        private Label data;
        private Label dzien;
        private Button button1;
        private PictureBox tarcza;
        private System.Windows.Forms.Timer timer1;
    }
}