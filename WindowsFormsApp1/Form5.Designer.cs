namespace WindowsFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salonKrasotiDataSet = new WindowsFormsApp1.SalonKrasotiDataSet();
            this.категорияуслугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категория_услугиTableAdapter = new WindowsFormsApp1.SalonKrasotiDataSetTableAdapters.Категория_услугиTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.предстоящиезаписиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предстоящие_записиTableAdapter = new WindowsFormsApp1.SalonKrasotiDataSetTableAdapters.Предстоящие_записиTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияуслугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предстоящиезаписиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.фотоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.категорияуслугиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // salonKrasotiDataSet
            // 
            this.salonKrasotiDataSet.DataSetName = "SalonKrasotiDataSet";
            this.salonKrasotiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // категорияуслугиBindingSource
            // 
            this.категорияуслугиBindingSource.DataMember = "Категория_услуги";
            this.категорияуслугиBindingSource.DataSource = this.salonKrasotiDataSet;
            // 
            // категория_услугиTableAdapter
            // 
            this.категория_услугиTableAdapter.ClearBeforeFill = true;
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
            // фотоDataGridViewTextBoxColumn
            // 
            this.фотоDataGridViewTextBoxColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewTextBoxColumn.HeaderText = "Фото";
            this.фотоDataGridViewTextBoxColumn.Name = "фотоDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.датаDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.iDКлиентаDataGridViewTextBoxColumn,
            this.iDСотрудникаDataGridViewTextBoxColumn,
            this.iDУслугиDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.предстоящиезаписиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(641, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // предстоящиезаписиBindingSource
            // 
            this.предстоящиезаписиBindingSource.DataMember = "Предстоящие_записи";
            this.предстоящиезаписиBindingSource.DataSource = this.salonKrasotiDataSet;
            // 
            // предстоящие_записиTableAdapter
            // 
            this.предстоящие_записиTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            // 
            // iDКлиентаDataGridViewTextBoxColumn
            // 
            this.iDКлиентаDataGridViewTextBoxColumn.DataPropertyName = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn.HeaderText = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn.Name = "iDКлиентаDataGridViewTextBoxColumn";
            // 
            // iDСотрудникаDataGridViewTextBoxColumn
            // 
            this.iDСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "IDСотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.HeaderText = "IDСотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.Name = "iDСотрудникаDataGridViewTextBoxColumn";
            // 
            // iDУслугиDataGridViewTextBoxColumn
            // 
            this.iDУслугиDataGridViewTextBoxColumn.DataPropertyName = "IDУслуги";
            this.iDУслугиDataGridViewTextBoxColumn.HeaderText = "IDУслуги";
            this.iDУслугиDataGridViewTextBoxColumn.Name = "iDУслугиDataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "ЗАЙКА";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияуслугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предстоящиезаписиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SalonKrasotiDataSet salonKrasotiDataSet;
        private System.Windows.Forms.BindingSource категорияуслугиBindingSource;
        private SalonKrasotiDataSetTableAdapters.Категория_услугиTableAdapter категория_услугиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фотоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource предстоящиезаписиBindingSource;
        private SalonKrasotiDataSetTableAdapters.Предстоящие_записиTableAdapter предстоящие_записиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDУслугиDataGridViewTextBoxColumn;
    }
}