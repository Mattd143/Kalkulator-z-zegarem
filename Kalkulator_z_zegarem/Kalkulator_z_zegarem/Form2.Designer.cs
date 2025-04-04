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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form2";
        }

        #endregion
    }
}