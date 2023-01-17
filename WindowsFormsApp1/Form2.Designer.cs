namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.salonKrasotiDataSet1 = new WindowsFormsApp1.SalonKrasotiDataSet1();
            this.услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугиTableAdapter = new WindowsFormsApp1.SalonKrasotiDataSet1TableAdapters.УслугиTableAdapter();
            this.salonKrasotiDataSet = new WindowsFormsApp1.SalonKrasotiDataSet();
            this.salonKrasotiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.услугиTableAdapter1 = new WindowsFormsApp1.SalonKrasotiDataSetTableAdapters.УслугиTableAdapter();
            this.услугиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.услугиBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКатегорииУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.категорияуслугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категория_услугиTableAdapter = new WindowsFormsApp1.SalonKrasotiDataSetTableAdapters.Категория_услугиTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияуслугиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // salonKrasotiDataSet1
            // 
            this.salonKrasotiDataSet1.DataSetName = "SalonKrasotiDataSet1";
            this.salonKrasotiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // услугиBindingSource
            // 
            this.услугиBindingSource.DataMember = "Услуги";
            this.услугиBindingSource.DataSource = this.salonKrasotiDataSet1;
            // 
            // услугиTableAdapter
            // 
            this.услугиTableAdapter.ClearBeforeFill = true;
            // 
            // salonKrasotiDataSet
            // 
            this.salonKrasotiDataSet.DataSetName = "SalonKrasotiDataSet";
            this.salonKrasotiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salonKrasotiDataSetBindingSource
            // 
            this.salonKrasotiDataSetBindingSource.DataSource = this.salonKrasotiDataSet;
            this.salonKrasotiDataSetBindingSource.Position = 0;
            // 
            // услугиBindingSource1
            // 
            this.услугиBindingSource1.DataMember = "Услуги";
            this.услугиBindingSource1.DataSource = this.salonKrasotiDataSetBindingSource;
            // 
            // услугиTableAdapter1
            // 
            this.услугиTableAdapter1.ClearBeforeFill = true;
            // 
            // услугиBindingSource2
            // 
            this.услугиBindingSource2.DataMember = "Услуги";
            this.услугиBindingSource2.DataSource = this.salonKrasotiDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.фотоDataGridViewTextBoxColumn,
            this.iDКатегорииУслугиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.услугиBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // услугиBindingSource3
            // 
            this.услугиBindingSource3.DataMember = "Услуги";
            this.услугиBindingSource3.DataSource = this.salonKrasotiDataSetBindingSource;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // фотоDataGridViewTextBoxColumn
            // 
            this.фотоDataGridViewTextBoxColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewTextBoxColumn.HeaderText = "Фото";
            this.фотоDataGridViewTextBoxColumn.Name = "фотоDataGridViewTextBoxColumn";
            // 
            // iDКатегорииУслугиDataGridViewTextBoxColumn
            // 
            this.iDКатегорииУслугиDataGridViewTextBoxColumn.DataPropertyName = "IDКатегорииУслуги";
            this.iDКатегорииУслугиDataGridViewTextBoxColumn.HeaderText = "IDКатегорииУслуги";
            this.iDКатегорииУслугиDataGridViewTextBoxColumn.Name = "iDКатегорииУслугиDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(383, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn1,
            this.фотоDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.категорияуслугиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 178);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(342, 150);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // категорияуслугиBindingSource
            // 
            this.категорияуслугиBindingSource.DataMember = "Категория_услуги";
            this.категорияуслугиBindingSource.DataSource = this.salonKrasotiDataSetBindingSource;
            // 
            // категория_услугиTableAdapter
            // 
            this.категория_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn1
            // 
            this.наименованиеDataGridViewTextBoxColumn1.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.Name = "наименованиеDataGridViewTextBoxColumn1";
            // 
            // фотоDataGridViewTextBoxColumn1
            // 
            this.фотоDataGridViewTextBoxColumn1.DataPropertyName = "Фото";
            this.фотоDataGridViewTextBoxColumn1.HeaderText = "Фото";
            this.фотоDataGridViewTextBoxColumn1.Name = "фотоDataGridViewTextBoxColumn1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(527, 340);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "УСЛУГИ ЗАЙКИ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияуслугиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SalonKrasotiDataSet1 salonKrasotiDataSet1;
        private System.Windows.Forms.BindingSource услугиBindingSource;
        private SalonKrasotiDataSet1TableAdapters.УслугиTableAdapter услугиTableAdapter;
        private System.Windows.Forms.BindingSource salonKrasotiDataSetBindingSource;
        private SalonKrasotiDataSet salonKrasotiDataSet;
        private System.Windows.Forms.BindingSource услугиBindingSource1;
        private SalonKrasotiDataSetTableAdapters.УслугиTableAdapter услугиTableAdapter1;
        private System.Windows.Forms.BindingSource услугиBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фотоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКатегорииУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource услугиBindingSource3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource категорияуслугиBindingSource;
        private SalonKrasotiDataSetTableAdapters.Категория_услугиTableAdapter категория_услугиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фотоDataGridViewTextBoxColumn1;
    }
}