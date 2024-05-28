namespace БытСервис
{
    partial class O
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.naz = new System.Windows.Forms.Button();
            this.zag = new System.Windows.Forms.Panel();
            this.zagolovok = new System.Windows.Forms.Label();
            this.osnrab.SuspendLayout();
            this.zag.SuspendLayout();
            this.SuspendLayout();
            // 
            // osnrab
            // 
            this.osnrab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.osnrab.Controls.Add(this.button3);
            this.osnrab.Controls.Add(this.button1);
            this.osnrab.Controls.Add(this.button2);
            this.osnrab.Controls.Add(this.label4);
            this.osnrab.Controls.Add(this.naz);
            this.osnrab.Controls.Add(this.zag);
            this.osnrab.Location = new System.Drawing.Point(-1, -1);
            this.osnrab.Name = "osnrab";
            this.osnrab.Size = new System.Drawing.Size(802, 453);
            this.osnrab.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(263, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(292, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Отчет по среднему времени выполненю";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(263, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Отчет по типам неисправностей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(263, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отчет по количеству выполненных заявок";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Окно оператора";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // naz
            // 
            this.naz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.naz.Location = new System.Drawing.Point(13, 416);
            this.naz.Name = "naz";
            this.naz.Size = new System.Drawing.Size(75, 23);
            this.naz.TabIndex = 7;
            this.naz.Text = "Назад";
            this.naz.UseVisualStyleBackColor = true;
            this.naz.Click += new System.EventHandler(this.naz_Click);
            // 
            // zag
            // 
            this.zag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // O
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.osnrab);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "O";
            this.Text = "O";
            this.osnrab.ResumeLayout(false);
            this.zag.ResumeLayout(false);
            this.zag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel osnrab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button naz;
        private System.Windows.Forms.Panel zag;
        private System.Windows.Forms.Label zagolovok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}