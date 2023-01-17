namespace WindowsFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.salonKrasotiDataSet1 = new WindowsFormsApp1.SalonKrasotiDataSet1();
            this.предстоящиезаписиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предстоящие_записиTableAdapter = new WindowsFormsApp1.SalonKrasotiDataSet1TableAdapters.Предстоящие_записиTableAdapter();
            this.услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугиTableAdapter = new WindowsFormsApp1.SalonKrasotiDataSet1TableAdapters.УслугиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предстоящиезаписиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // salonKrasotiDataSet1
            // 
            this.salonKrasotiDataSet1.DataSetName = "SalonKrasotiDataSet1";
            this.salonKrasotiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // предстоящиезаписиBindingSource
            // 
            this.предстоящиезаписиBindingSource.DataMember = "Предстоящие_записи";
            this.предстоящиезаписиBindingSource.DataSource = this.salonKrasotiDataSet1;
            // 
            // предстоящие_записиTableAdapter
            // 
            this.предстоящие_записиTableAdapter.ClearBeforeFill = true;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(53, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 146);
            this.button1.TabIndex = 0;
            this.button1.Text = "Записи";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(303, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 146);
            this.button2.TabIndex = 1;
            this.button2.Text = "Услуги";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(537, 219);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Салон красоты Меню";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предстоящиезаписиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SalonKrasotiDataSet1 salonKrasotiDataSet1;
        private System.Windows.Forms.BindingSource предстоящиезаписиBindingSource;
        private SalonKrasotiDataSet1TableAdapters.Предстоящие_записиTableAdapter предстоящие_записиTableAdapter;
        private System.Windows.Forms.BindingSource услугиBindingSource;
        private SalonKrasotiDataSet1TableAdapters.УслугиTableAdapter услугиTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}