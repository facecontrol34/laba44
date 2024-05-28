namespace БытСервис
{
    partial class ZaiavkiM
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
            this.osnrab = new System.Windows.Forms.Panel();
            this.OK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeTechTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeTechModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemDescryptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairPartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a4DataSet = new БытСервис.a4DataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.naz = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zag = new System.Windows.Forms.Panel();
            this.zagolovok = new System.Windows.Forms.Label();
            this.requestsTableAdapter = new БытСервис.a4DataSetTableAdapters.RequestsTableAdapter();
            this.osnrab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a4DataSet)).BeginInit();
            this.zag.SuspendLayout();
            this.SuspendLayout();
            // 
            // osnrab
            // 
            this.osnrab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.osnrab.Controls.Add(this.OK);
            this.osnrab.Controls.Add(this.dataGridView1);
            this.osnrab.Controls.Add(this.comboBox2);
            this.osnrab.Controls.Add(this.naz);
            this.osnrab.Controls.Add(this.label7);
            this.osnrab.Controls.Add(this.label4);
            this.osnrab.Controls.Add(this.label1);
            this.osnrab.Controls.Add(this.zag);
            this.osnrab.Location = new System.Drawing.Point(-1, -1);
            this.osnrab.Name = "osnrab";
            this.osnrab.Size = new System.Drawing.Size(802, 453);
            this.osnrab.TabIndex = 4;
            this.osnrab.Paint += new System.Windows.Forms.PaintEventHandler(this.osnrab_Paint);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.Location = new System.Drawing.Point(620, 287);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 17;
            this.OK.Text = "Ок";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.homeTechTypeDataGridViewTextBoxColumn,
            this.homeTechModelDataGridViewTextBoxColumn,
            this.problemDescryptionDataGridViewTextBoxColumn,
            this.requestStatusDataGridViewTextBoxColumn,
            this.completionDateDataGridViewTextBoxColumn,
            this.repairPartsDataGridViewTextBoxColumn,
            this.masterIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 310);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "requestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "requestID";
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // homeTechTypeDataGridViewTextBoxColumn
            // 
            this.homeTechTypeDataGridViewTextBoxColumn.DataPropertyName = "homeTechType";
            this.homeTechTypeDataGridViewTextBoxColumn.HeaderText = "homeTechType";
            this.homeTechTypeDataGridViewTextBoxColumn.Name = "homeTechTypeDataGridViewTextBoxColumn";
            // 
            // homeTechModelDataGridViewTextBoxColumn
            // 
            this.homeTechModelDataGridViewTextBoxColumn.DataPropertyName = "homeTechModel";
            this.homeTechModelDataGridViewTextBoxColumn.HeaderText = "homeTechModel";
            this.homeTechModelDataGridViewTextBoxColumn.Name = "homeTechModelDataGridViewTextBoxColumn";
            // 
            // problemDescryptionDataGridViewTextBoxColumn
            // 
            this.problemDescryptionDataGridViewTextBoxColumn.DataPropertyName = "problemDescryption";
            this.problemDescryptionDataGridViewTextBoxColumn.HeaderText = "problemDescryption";
            this.problemDescryptionDataGridViewTextBoxColumn.Name = "problemDescryptionDataGridViewTextBoxColumn";
            // 
            // requestStatusDataGridViewTextBoxColumn
            // 
            this.requestStatusDataGridViewTextBoxColumn.DataPropertyName = "requestStatus";
            this.requestStatusDataGridViewTextBoxColumn.HeaderText = "requestStatus";
            this.requestStatusDataGridViewTextBoxColumn.Name = "requestStatusDataGridViewTextBoxColumn";
            // 
            // completionDateDataGridViewTextBoxColumn
            // 
            this.completionDateDataGridViewTextBoxColumn.DataPropertyName = "completionDate";
            this.completionDateDataGridViewTextBoxColumn.HeaderText = "completionDate";
            this.completionDateDataGridViewTextBoxColumn.Name = "completionDateDataGridViewTextBoxColumn";
            // 
            // repairPartsDataGridViewTextBoxColumn
            // 
            this.repairPartsDataGridViewTextBoxColumn.DataPropertyName = "repairParts";
            this.repairPartsDataGridViewTextBoxColumn.HeaderText = "repairParts";
            this.repairPartsDataGridViewTextBoxColumn.Name = "repairPartsDataGridViewTextBoxColumn";
            // 
            // masterIDDataGridViewTextBoxColumn
            // 
            this.masterIDDataGridViewTextBoxColumn.DataPropertyName = "masterID";
            this.masterIDDataGridViewTextBoxColumn.HeaderText = "masterID";
            this.masterIDDataGridViewTextBoxColumn.Name = "masterIDDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "clientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "clientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.a4DataSet;
            // 
            // a4DataSet
            // 
            this.a4DataSet.DataSetName = "a4DataSet";
            this.a4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "В процессе ремонта",
            "Готова к выдаче",
            "Новая заявка"});
            this.comboBox2.Location = new System.Drawing.Point(597, 244);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // naz
            // 
            this.naz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.naz.Location = new System.Drawing.Point(13, 416);
            this.naz.Name = "naz";
            this.naz.Size = new System.Drawing.Size(75, 23);
            this.naz.TabIndex = 14;
            this.naz.Text = "Назад";
            this.naz.UseVisualStyleBackColor = true;
            this.naz.Click += new System.EventHandler(this.naz_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "1";
            this.label7.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Редактирование заявки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Статус";
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
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // ZaiavkiM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.osnrab);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ZaiavkiM";
            this.Text = "ZaiavkiM";
            this.Load += new System.EventHandler(this.ZaiavkiM_Load);
            this.osnrab.ResumeLayout(false);
            this.osnrab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a4DataSet)).EndInit();
            this.zag.ResumeLayout(false);
            this.zag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel osnrab;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button naz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel zag;
        private System.Windows.Forms.Label zagolovok;
        private a4DataSet a4DataSet;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private a4DataSetTableAdapters.RequestsTableAdapter requestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTechTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTechModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemDescryptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairPartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
    }
}