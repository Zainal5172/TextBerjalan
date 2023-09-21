namespace TulisanBerjalan
{
    partial class frmTulisanBerjalan
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
            this.components = new System.ComponentModel.Container();
            this.lblAnimasi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnimasi
            // 
            this.lblAnimasi.AutoSize = true;
            this.lblAnimasi.Location = new System.Drawing.Point(205, 102);
            this.lblAnimasi.Name = "lblAnimasi";
            this.lblAnimasi.Size = new System.Drawing.Size(98, 13);
            this.lblAnimasi.TabIndex = 0;
            this.lblAnimasi.Text = "Tulisan Berjalan";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(367, 225);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(87, 23);
            this.btnKeluar.TabIndex = 1;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // frmTulisanBerjalan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 260);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.lblAnimasi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTulisanBerjalan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TulisanBerjalan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimasi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnKeluar;
    }
}

