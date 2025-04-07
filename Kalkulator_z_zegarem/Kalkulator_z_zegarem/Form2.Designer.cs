namespace Kalkulator_z_zegarem
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.

        public static int loo = 0;           // definicja zmiennej której użyjemy, by zapobiec włączaniu kilku okienek na raz
        public Form1 kalkulator;
        public Form2 zegar;
        
        
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
            this.godzina_minuta = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.dzien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tarcza = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomarańczoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niebieskieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.białeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzKalkulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tarcza)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // godzina_minuta
            // 
            this.godzina_minuta.AutoSize = true;
            this.godzina_minuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.godzina_minuta.Location = new System.Drawing.Point(162, 35);
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
            this.dzien.Location = new System.Drawing.Point(236, 271);
            this.dzien.Name = "dzien";
            this.dzien.Size = new System.Drawing.Size(138, 51);
            this.dzien.TabIndex = 2;
            this.dzien.Text = "label3";
            this.dzien.Click += new System.EventHandler(this.dzien_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Location = new System.Drawing.Point(187, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zmień sposób wyświetlania zegara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tarcza
            // 
            this.tarcza.BackColor = System.Drawing.Color.Peru;
            this.tarcza.Location = new System.Drawing.Point(187, 57);
            this.tarcza.Name = "tarcza";
            this.tarcza.Size = new System.Drawing.Size(337, 321);
            this.tarcza.TabIndex = 4;
            this.tarcza.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem,
            this.zmiToolStripMenuItem,
            this.otwórzKalkulatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(707, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // zmiToolStripMenuItem
            // 
            this.zmiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomarańczoweToolStripMenuItem,
            this.niebieskieToolStripMenuItem,
            this.białeToolStripMenuItem});
            this.zmiToolStripMenuItem.Name = "zmiToolStripMenuItem";
            this.zmiToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.zmiToolStripMenuItem.Text = "Wybierz tło";
            this.zmiToolStripMenuItem.Click += new System.EventHandler(this.zmiToolStripMenuItem_Click);
            // 
            // pomarańczoweToolStripMenuItem
            // 
            this.pomarańczoweToolStripMenuItem.Name = "pomarańczoweToolStripMenuItem";
            this.pomarańczoweToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.pomarańczoweToolStripMenuItem.Text = "Pomarańczowe";
            this.pomarańczoweToolStripMenuItem.Click += new System.EventHandler(this.pomarańczoweToolStripMenuItem_Click);
            // 
            // niebieskieToolStripMenuItem
            // 
            this.niebieskieToolStripMenuItem.Name = "niebieskieToolStripMenuItem";
            this.niebieskieToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.niebieskieToolStripMenuItem.Text = "Niebieskie";
            this.niebieskieToolStripMenuItem.Click += new System.EventHandler(this.niebieskieToolStripMenuItem_Click);
            // 
            // białeToolStripMenuItem
            // 
            this.białeToolStripMenuItem.Name = "białeToolStripMenuItem";
            this.białeToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.białeToolStripMenuItem.Text = "Białe";
            this.białeToolStripMenuItem.Click += new System.EventHandler(this.białeToolStripMenuItem_Click);
            // 
            // otwórzKalkulatorToolStripMenuItem
            // 
            this.otwórzKalkulatorToolStripMenuItem.Name = "otwórzKalkulatorToolStripMenuItem";
            this.otwórzKalkulatorToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.otwórzKalkulatorToolStripMenuItem.Text = "Otwórz kalkulator";
            this.otwórzKalkulatorToolStripMenuItem.Click += new System.EventHandler(this.otwórzKalkulatorToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(707, 533);
            this.Controls.Add(this.tarcza);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dzien);
            this.Controls.Add(this.data);
            this.Controls.Add(this.godzina_minuta);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarcza)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem zakończToolStripMenuItem;
        private ToolStripMenuItem zmiToolStripMenuItem;
        private ToolStripMenuItem otwórzKalkulatorToolStripMenuItem;
        private ToolStripMenuItem pomarańczoweToolStripMenuItem;
        private ToolStripMenuItem niebieskieToolStripMenuItem;
        private ToolStripMenuItem białeToolStripMenuItem;
    }
}