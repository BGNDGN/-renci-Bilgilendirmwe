namespace Öğrenci_Bilgilendirmwe
{
    partial class Öğrenci
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.öğrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.öğrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.öğrenciSoyAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sınav1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sınav2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.öğrenciNumarasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.öğrenciBilgilendirmeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.okulDataSet = new Öğrenci_Bilgilendirmwe.OkulDataSet();
            this.öğrenciBilgilendirmeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.öğrenciBilgilendirmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okulDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.öğrenciBilgilendirmeTableAdapter = new Öğrenci_Bilgilendirmwe.OkulDataSetTableAdapters.ÖğrenciBilgilendirmeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBilgilendirmeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBilgilendirmeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBilgilendirmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 175);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.öğrenciIDDataGridViewTextBoxColumn,
            this.öğrenciAdDataGridViewTextBoxColumn,
            this.öğrenciSoyAdDataGridViewTextBoxColumn,
            this.sınav1DataGridViewTextBoxColumn,
            this.sınav2DataGridViewTextBoxColumn,
            this.finalDataGridViewTextBoxColumn,
            this.öğrenciNumarasıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.öğrenciBilgilendirmeBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // öğrenciIDDataGridViewTextBoxColumn
            // 
            this.öğrenciIDDataGridViewTextBoxColumn.DataPropertyName = "ÖğrenciID";
            this.öğrenciIDDataGridViewTextBoxColumn.HeaderText = "ÖğrenciID";
            this.öğrenciIDDataGridViewTextBoxColumn.Name = "öğrenciIDDataGridViewTextBoxColumn";
            this.öğrenciIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // öğrenciAdDataGridViewTextBoxColumn
            // 
            this.öğrenciAdDataGridViewTextBoxColumn.DataPropertyName = "ÖğrenciAd";
            this.öğrenciAdDataGridViewTextBoxColumn.HeaderText = "ÖğrenciAd";
            this.öğrenciAdDataGridViewTextBoxColumn.Name = "öğrenciAdDataGridViewTextBoxColumn";
            // 
            // öğrenciSoyAdDataGridViewTextBoxColumn
            // 
            this.öğrenciSoyAdDataGridViewTextBoxColumn.DataPropertyName = "ÖğrenciSoyAd";
            this.öğrenciSoyAdDataGridViewTextBoxColumn.HeaderText = "ÖğrenciSoyAd";
            this.öğrenciSoyAdDataGridViewTextBoxColumn.Name = "öğrenciSoyAdDataGridViewTextBoxColumn";
            // 
            // sınav1DataGridViewTextBoxColumn
            // 
            this.sınav1DataGridViewTextBoxColumn.DataPropertyName = "Sınav1";
            this.sınav1DataGridViewTextBoxColumn.HeaderText = "Sınav1";
            this.sınav1DataGridViewTextBoxColumn.Name = "sınav1DataGridViewTextBoxColumn";
            // 
            // sınav2DataGridViewTextBoxColumn
            // 
            this.sınav2DataGridViewTextBoxColumn.DataPropertyName = "Sınav2";
            this.sınav2DataGridViewTextBoxColumn.HeaderText = "Sınav2";
            this.sınav2DataGridViewTextBoxColumn.Name = "sınav2DataGridViewTextBoxColumn";
            // 
            // finalDataGridViewTextBoxColumn
            // 
            this.finalDataGridViewTextBoxColumn.DataPropertyName = "Final";
            this.finalDataGridViewTextBoxColumn.HeaderText = "Final";
            this.finalDataGridViewTextBoxColumn.Name = "finalDataGridViewTextBoxColumn";
            // 
            // öğrenciNumarasıDataGridViewTextBoxColumn
            // 
            this.öğrenciNumarasıDataGridViewTextBoxColumn.DataPropertyName = "ÖğrenciNumarası";
            this.öğrenciNumarasıDataGridViewTextBoxColumn.HeaderText = "ÖğrenciNumarası";
            this.öğrenciNumarasıDataGridViewTextBoxColumn.Name = "öğrenciNumarasıDataGridViewTextBoxColumn";
            // 
            // öğrenciBilgilendirmeBindingSource2
            // 
            this.öğrenciBilgilendirmeBindingSource2.DataMember = "ÖğrenciBilgilendirme";
            this.öğrenciBilgilendirmeBindingSource2.DataSource = this.okulDataSet;
            // 
            // okulDataSet
            // 
            this.okulDataSet.DataSetName = "OkulDataSet";
            this.okulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // öğrenciBilgilendirmeBindingSource1
            // 
            this.öğrenciBilgilendirmeBindingSource1.DataMember = "ÖğrenciBilgilendirme";
            this.öğrenciBilgilendirmeBindingSource1.DataSource = this.okulDataSet;
            // 
            // öğrenciBilgilendirmeBindingSource
            // 
            this.öğrenciBilgilendirmeBindingSource.DataMember = "ÖğrenciBilgilendirme";
            this.öğrenciBilgilendirmeBindingSource.DataSource = this.okulDataSetBindingSource;
            // 
            // okulDataSetBindingSource
            // 
            this.okulDataSetBindingSource.DataSource = this.okulDataSet;
            this.okulDataSetBindingSource.Position = 0;
            // 
            // öğrenciBilgilendirmeTableAdapter
            // 
            this.öğrenciBilgilendirmeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Giriş Sayfasına Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(608, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Çıkış Yap";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Öğrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(759, 224);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Öğrenci";
            this.Text = "Öğrenci";
            this.Load += new System.EventHandler(this.Öğrenci_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBilgilendirmeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBilgilendirmeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBilgilendirmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource okulDataSetBindingSource;
        private OkulDataSet okulDataSet;
        private System.Windows.Forms.BindingSource öğrenciBilgilendirmeBindingSource;
        private OkulDataSetTableAdapters.ÖğrenciBilgilendirmeTableAdapter öğrenciBilgilendirmeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sınavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sınavDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource öğrenciBilgilendirmeBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn öğrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn öğrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn öğrenciSoyAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sınav1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sınav2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn öğrenciNumarasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource öğrenciBilgilendirmeBindingSource2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}