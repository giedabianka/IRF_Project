namespace IRF_Project_Gieda_Bianka_FYZINS
{
    partial class Inditas
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
            this.Jatekosok_szama_Cbox = new System.Windows.Forms.ComboBox();
            this.Betuk_szama_Cbox = new System.Windows.Forms.ComboBox();
            this.Jatek_inditasa_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Jatekosok_szama_Cbox
            // 
            this.Jatekosok_szama_Cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Jatekosok_szama_Cbox.FormattingEnabled = true;
            this.Jatekosok_szama_Cbox.Location = new System.Drawing.Point(522, 232);
            this.Jatekosok_szama_Cbox.Name = "Jatekosok_szama_Cbox";
            this.Jatekosok_szama_Cbox.Size = new System.Drawing.Size(63, 28);
            this.Jatekosok_szama_Cbox.TabIndex = 1;
            // 
            // Betuk_szama_Cbox
            // 
            this.Betuk_szama_Cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Betuk_szama_Cbox.FormattingEnabled = true;
            this.Betuk_szama_Cbox.Location = new System.Drawing.Point(533, 276);
            this.Betuk_szama_Cbox.Name = "Betuk_szama_Cbox";
            this.Betuk_szama_Cbox.Size = new System.Drawing.Size(63, 28);
            this.Betuk_szama_Cbox.TabIndex = 2;
            // 
            // Jatek_inditasa_Btn
            // 
            this.Jatek_inditasa_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(174)))), ((int)(((byte)(121)))));
            this.Jatek_inditasa_Btn.Font = new System.Drawing.Font("Bradley Hand ITC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jatek_inditasa_Btn.Location = new System.Drawing.Point(342, 366);
            this.Jatek_inditasa_Btn.Name = "Jatek_inditasa_Btn";
            this.Jatek_inditasa_Btn.Size = new System.Drawing.Size(254, 45);
            this.Jatek_inditasa_Btn.TabIndex = 5;
            this.Jatek_inditasa_Btn.Text = "Játék indítása";
            this.Jatek_inditasa_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Jatek_inditasa_Btn.UseVisualStyleBackColor = false;
            this.Jatek_inditasa_Btn.Click += new System.EventHandler(this.Jatek_inditasa_Btn_Click_1);
            // 
            // Inditas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IRF_Project_Gieda_Bianka_FYZINS.Properties.Resources.kezdokep_01;
            this.ClientSize = new System.Drawing.Size(679, 449);
            this.Controls.Add(this.Jatek_inditasa_Btn);
            this.Controls.Add(this.Betuk_szama_Cbox);
            this.Controls.Add(this.Jatekosok_szama_Cbox);
            this.Name = "Inditas";
            this.Text = "Inditas";
            this.Load += new System.EventHandler(this.Inditas_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox Jatekosok_szama_Cbox;
        private System.Windows.Forms.ComboBox Betuk_szama_Cbox;
        private System.Windows.Forms.Button Jatek_inditasa_Btn;
    }
}