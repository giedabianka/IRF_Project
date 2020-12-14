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
            this.label1 = new System.Windows.Forms.Label();
            this.Jatekosok_szama_Cbox = new System.Windows.Forms.ComboBox();
            this.Betuk_szama_Cbox = new System.Windows.Forms.ComboBox();
            this.Jatekosok_szama_Lbl = new System.Windows.Forms.Label();
            this.Betuk_szama_Lbl = new System.Windows.Forms.Label();
            this.Jatek_inditasa_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(150, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "AKASZTÓFA JÁTÉK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Jatekosok_szama_Cbox
            // 
            this.Jatekosok_szama_Cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Jatekosok_szama_Cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Jatekosok_szama_Cbox.FormattingEnabled = true;
            this.Jatekosok_szama_Cbox.Location = new System.Drawing.Point(391, 130);
            this.Jatekosok_szama_Cbox.Name = "Jatekosok_szama_Cbox";
            this.Jatekosok_szama_Cbox.Size = new System.Drawing.Size(63, 28);
            this.Jatekosok_szama_Cbox.TabIndex = 1;
            // 
            // Betuk_szama_Cbox
            // 
            this.Betuk_szama_Cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Betuk_szama_Cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Betuk_szama_Cbox.FormattingEnabled = true;
            this.Betuk_szama_Cbox.Location = new System.Drawing.Point(391, 205);
            this.Betuk_szama_Cbox.Name = "Betuk_szama_Cbox";
            this.Betuk_szama_Cbox.Size = new System.Drawing.Size(63, 28);
            this.Betuk_szama_Cbox.TabIndex = 2;
            // 
            // Jatekosok_szama_Lbl
            // 
            this.Jatekosok_szama_Lbl.AutoSize = true;
            this.Jatekosok_szama_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Jatekosok_szama_Lbl.Location = new System.Drawing.Point(195, 133);
            this.Jatekosok_szama_Lbl.Name = "Jatekosok_szama_Lbl";
            this.Jatekosok_szama_Lbl.Size = new System.Drawing.Size(171, 25);
            this.Jatekosok_szama_Lbl.TabIndex = 3;
            this.Jatekosok_szama_Lbl.Text = "Játékosok száma:";
            // 
            // Betuk_szama_Lbl
            // 
            this.Betuk_szama_Lbl.AutoSize = true;
            this.Betuk_szama_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Betuk_szama_Lbl.Location = new System.Drawing.Point(195, 208);
            this.Betuk_szama_Lbl.Name = "Betuk_szama_Lbl";
            this.Betuk_szama_Lbl.Size = new System.Drawing.Size(131, 25);
            this.Betuk_szama_Lbl.TabIndex = 4;
            this.Betuk_szama_Lbl.Text = "Betűk száma:";
            // 
            // Jatek_inditasa_Btn
            // 
            this.Jatek_inditasa_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Jatek_inditasa_Btn.Location = new System.Drawing.Point(200, 311);
            this.Jatek_inditasa_Btn.Name = "Jatek_inditasa_Btn";
            this.Jatek_inditasa_Btn.Size = new System.Drawing.Size(254, 45);
            this.Jatek_inditasa_Btn.TabIndex = 5;
            this.Jatek_inditasa_Btn.Text = "Játék indítása";
            this.Jatek_inditasa_Btn.UseVisualStyleBackColor = true;
            this.Jatek_inditasa_Btn.Click += new System.EventHandler(this.Jatek_inditasa_Btn_Click_1);
            // 
            // Inditas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 411);
            this.Controls.Add(this.Jatek_inditasa_Btn);
            this.Controls.Add(this.Betuk_szama_Lbl);
            this.Controls.Add(this.Jatekosok_szama_Lbl);
            this.Controls.Add(this.Betuk_szama_Cbox);
            this.Controls.Add(this.Jatekosok_szama_Cbox);
            this.Controls.Add(this.label1);
            this.Name = "Inditas";
            this.Text = "Inditas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Jatekosok_szama_Cbox;
        private System.Windows.Forms.ComboBox Betuk_szama_Cbox;
        private System.Windows.Forms.Label Jatekosok_szama_Lbl;
        private System.Windows.Forms.Label Betuk_szama_Lbl;
        private System.Windows.Forms.Button Jatek_inditasa_Btn;
    }
}