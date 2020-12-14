namespace IRF_Project_Gieda_Bianka_FYZINS
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
            kitalalando = new System.Windows.Forms.Label();
            hibas_betuk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel_betuk
            // 
            this.panel_betuk.Location = new System.Drawing.Point(27, 190);
            this.panel_betuk.Name = "panel_betuk";
            this.panel_betuk.Size = new System.Drawing.Size(300, 200);
            this.panel_betuk.TabIndex = 0;
            // 
            // kitalalando
            // 
            kitalalando.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            kitalalando.Location = new System.Drawing.Point(24, 86);
            kitalalando.Name = "kitalalando";
            kitalalando.Size = new System.Drawing.Size(303, 43);
            kitalalando.TabIndex = 1;
            // 
            // hibas_betuk
            // 
            hibas_betuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            hibas_betuk.Location = new System.Drawing.Point(351, 296);
            hibas_betuk.Name = "hibas_betuk";
            hibas_betuk.Size = new System.Drawing.Size(287, 94);
            hibas_betuk.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 411);
            this.Controls.Add(hibas_betuk);
            this.Controls.Add(kitalalando);
            this.Controls.Add(this.panel_betuk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_betuk;
        public static System.Windows.Forms.Label hibas_betuk;
        public static System.Windows.Forms.Label kitalalando;
    }
}

