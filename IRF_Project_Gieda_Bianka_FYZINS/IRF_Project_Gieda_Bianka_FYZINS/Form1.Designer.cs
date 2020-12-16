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
            this.kitalalando = new System.Windows.Forms.Label();
            this.hibas_betuk = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_vege = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_betuk
            // 
            this.panel_betuk.BackColor = System.Drawing.Color.Transparent;
            this.panel_betuk.Location = new System.Drawing.Point(45, 221);
            this.panel_betuk.Name = "panel_betuk";
            this.panel_betuk.Size = new System.Drawing.Size(280, 200);
            this.panel_betuk.TabIndex = 0;
            // 
            // kitalalando
            // 
            this.kitalalando.BackColor = System.Drawing.Color.Transparent;
            this.kitalalando.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kitalalando.Location = new System.Drawing.Point(88, 111);
            this.kitalalando.Name = "kitalalando";
            this.kitalalando.Size = new System.Drawing.Size(210, 43);
            this.kitalalando.TabIndex = 1;
            // 
            // hibas_betuk
            // 
            this.hibas_betuk.BackColor = System.Drawing.Color.Transparent;
            this.hibas_betuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hibas_betuk.Location = new System.Drawing.Point(347, 318);
            this.hibas_betuk.Name = "hibas_betuk";
            this.hibas_betuk.Size = new System.Drawing.Size(276, 101);
            this.hibas_betuk.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(396, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 245);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_vege
            // 
            this.btn_vege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(174)))), ((int)(((byte)(121)))));
            this.btn_vege.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vege.Location = new System.Drawing.Point(493, 374);
            this.btn_vege.Name = "btn_vege";
            this.btn_vege.Size = new System.Drawing.Size(130, 45);
            this.btn_vege.TabIndex = 9;
            this.btn_vege.Text = "Játék vége";
            this.btn_vege.UseVisualStyleBackColor = false;
            this.btn_vege.Click += new System.EventHandler(this.btn_vege_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(174)))), ((int)(((byte)(121)))));
            this.button1.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(352, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Eredményeim";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IRF_Project_Gieda_Bianka_FYZINS.Properties.Resources.jatek;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_vege);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hibas_betuk);
            this.Controls.Add(this.kitalalando);
            this.Controls.Add(this.panel_betuk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_betuk;
        public System.Windows.Forms.Label hibas_betuk;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label kitalalando;
        private System.Windows.Forms.Button btn_vege;
        private System.Windows.Forms.Button button1;
    }
}

