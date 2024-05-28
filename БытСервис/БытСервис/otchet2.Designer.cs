namespace БытСервис
{
    partial class otchet2
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
            this.osnrab = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.naz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.zag = new System.Windows.Forms.Panel();
            this.zagolovok = new System.Windows.Forms.Label();
            this.osnrab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.zag.SuspendLayout();
            this.SuspendLayout();
            // 
            // osnrab
            // 
            this.osnrab.Controls.Add(this.pictureBox1);
            this.osnrab.Controls.Add(this.naz);
            this.osnrab.Controls.Add(this.label4);
            this.osnrab.Controls.Add(this.zag);
            this.osnrab.Location = new System.Drawing.Point(-1, -1);
            this.osnrab.Name = "osnrab";
            this.osnrab.Size = new System.Drawing.Size(802, 453);
            this.osnrab.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::БытСервис.Properties.Resources.Снимок;
            this.pictureBox1.Location = new System.Drawing.Point(182, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // naz
            // 
            this.naz.Location = new System.Drawing.Point(13, 416);
            this.naz.Name = "naz";
            this.naz.Size = new System.Drawing.Size(75, 23);
            this.naz.TabIndex = 14;
            this.naz.Text = "Назад";
            this.naz.UseVisualStyleBackColor = true;
            this.naz.Click += new System.EventHandler(this.naz_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчет по типам неисправностей";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zag
            // 
            this.zag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zag.Controls.Add(this.zagolovok);
            this.zag.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zag.Location = new System.Drawing.Point(0, 0);
            this.zag.Name = "zag";
            this.zag.Size = new System.Drawing.Size(800, 77);
            this.zag.TabIndex = 0;
            // 
            // zagolovok
            // 
            this.zagolovok.AutoSize = true;
            this.zagolovok.Location = new System.Drawing.Point(253, 10);
            this.zagolovok.Name = "zagolovok";
            this.zagolovok.Size = new System.Drawing.Size(276, 55);
            this.zagolovok.TabIndex = 0;
            this.zagolovok.Text = "БытСервис";
            // 
            // otchet2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.osnrab);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "otchet2";
            this.Text = "otchet2";
            this.osnrab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.zag.ResumeLayout(false);
            this.zag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel osnrab;
        private System.Windows.Forms.Button naz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel zag;
        private System.Windows.Forms.Label zagolovok;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}