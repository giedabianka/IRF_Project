﻿namespace IRF_Project_Gieda_Bianka_FYZINS
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
            this.panel_betuk = new System.Windows.Forms.Panel();
            this.kitalalando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel_betuk
            // 
            this.panel_betuk.Location = new System.Drawing.Point(46, 181);
            this.panel_betuk.Name = "panel_betuk";
            this.panel_betuk.Size = new System.Drawing.Size(300, 200);
            this.panel_betuk.TabIndex = 0;
            // 
            // kitalalando
            // 
            this.kitalalando.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kitalalando.Location = new System.Drawing.Point(43, 87);
            this.kitalalando.Name = "kitalalando";
            this.kitalalando.Size = new System.Drawing.Size(303, 43);
            this.kitalalando.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 411);
            this.Controls.Add(this.kitalalando);
            this.Controls.Add(this.panel_betuk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_betuk;
        private System.Windows.Forms.Label kitalalando;
    }
}

