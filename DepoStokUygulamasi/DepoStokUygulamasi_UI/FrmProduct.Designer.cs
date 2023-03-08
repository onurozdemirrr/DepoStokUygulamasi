namespace DepoStokUygulamasi_UI
{
    partial class FrmProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxBarkodKodu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxStokMiktari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxBirimFiyati = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxRaf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxMinStok = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxMaxStok = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnFormuTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxKategoriId = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoStokUygulamasiDataSet = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet();
            this.cbxBirimId = new System.Windows.Forms.ComboBox();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoStokUygulamasiDataSet1 = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet1();
            this.cbxDepoId = new System.Windows.Forms.ComboBox();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoStokUygulamasiDataSet2 = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet2();
            this.categoriesTableAdapter = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSetTableAdapters.CategoriesTableAdapter();
            this.unitsTableAdapter = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet1TableAdapters.UnitsTableAdapter();
            this.warehousesTableAdapter = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet2TableAdapters.WarehousesTableAdapter();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKategoriFormuAc = new System.Windows.Forms.Button();
            this.btnDepoFormAc = new System.Windows.Forms.Button();
            this.btnBirimFormAc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // tbxId
            // 
            this.tbxId.Enabled = false;
            this.tbxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxId.Location = new System.Drawing.Point(157, 86);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(49, 26);
            this.tbxId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı";
            // 
            // tbxUrunAdi
            // 
            this.tbxUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrunAdi.Location = new System.Drawing.Point(157, 118);
            this.tbxUrunAdi.Name = "tbxUrunAdi";
            this.tbxUrunAdi.Size = new System.Drawing.Size(121, 26);
            this.tbxUrunAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Barkod Kodu";
            // 
            // tbxBarkodKodu
            // 
            this.tbxBarkodKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBarkodKodu.Location = new System.Drawing.Point(157, 182);
            this.tbxBarkodKodu.Name = "tbxBarkodKodu";
            this.tbxBarkodKodu.Size = new System.Drawing.Size(121, 26);
            this.tbxBarkodKodu.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stok Mitarı";
            // 
            // tbxStokMiktari
            // 
            this.tbxStokMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStokMiktari.Location = new System.Drawing.Point(157, 214);
            this.tbxStokMiktari.Name = "tbxStokMiktari";
            this.tbxStokMiktari.Size = new System.Drawing.Size(121, 26);
            this.tbxStokMiktari.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Birim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(359, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Birim Fiyatı";
            // 
            // tbxBirimFiyati
            // 
            this.tbxBirimFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBirimFiyati.Location = new System.Drawing.Point(492, 80);
            this.tbxBirimFiyati.Name = "tbxBirimFiyati";
            this.tbxBirimFiyati.Size = new System.Drawing.Size(123, 26);
            this.tbxBirimFiyati.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(359, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Depo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(359, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Raf";
            // 
            // tbxRaf
            // 
            this.tbxRaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxRaf.Location = new System.Drawing.Point(492, 144);
            this.tbxRaf.Name = "tbxRaf";
            this.tbxRaf.Size = new System.Drawing.Size(123, 26);
            this.tbxRaf.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(359, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Minumum Stok";
            // 
            // tbxMinStok
            // 
            this.tbxMinStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMinStok.Location = new System.Drawing.Point(492, 176);
            this.tbxMinStok.Name = "tbxMinStok";
            this.tbxMinStok.Size = new System.Drawing.Size(123, 26);
            this.tbxMinStok.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(359, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Maksimum Stok";
            // 
            // tbxMaxStok
            // 
            this.tbxMaxStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMaxStok.Location = new System.Drawing.Point(492, 208);
            this.tbxMaxStok.Name = "tbxMaxStok";
            this.tbxMaxStok.Size = new System.Drawing.Size(123, 26);
            this.tbxMaxStok.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(143, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(125, 36);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(274, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(125, 38);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(409, 14);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(125, 38);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnFormuTemizle
            // 
            this.btnFormuTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFormuTemizle.Location = new System.Drawing.Point(12, 12);
            this.btnFormuTemizle.Name = "btnFormuTemizle";
            this.btnFormuTemizle.Size = new System.Drawing.Size(125, 34);
            this.btnFormuTemizle.TabIndex = 2;
            this.btnFormuTemizle.Text = "Formu Temizle";
            this.btnFormuTemizle.UseVisualStyleBackColor = true;
            this.btnFormuTemizle.Click += new System.EventHandler(this.btnFormuTemizle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(609, 134);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cbxKategoriId
            // 
            this.cbxKategoriId.DataSource = this.categoriesBindingSource;
            this.cbxKategoriId.DisplayMember = "Name";
            this.cbxKategoriId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxKategoriId.FormattingEnabled = true;
            this.cbxKategoriId.Location = new System.Drawing.Point(157, 150);
            this.cbxKategoriId.Name = "cbxKategoriId";
            this.cbxKategoriId.Size = new System.Drawing.Size(121, 26);
            this.cbxKategoriId.TabIndex = 4;
            this.cbxKategoriId.ValueMember = "Id";
            this.cbxKategoriId.Click += new System.EventHandler(this.cbxKategoriId_Click);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.depoStokUygulamasiDataSet;
            // 
            // depoStokUygulamasiDataSet
            // 
            this.depoStokUygulamasiDataSet.DataSetName = "DepoStokUygulamasiDataSet";
            this.depoStokUygulamasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxBirimId
            // 
            this.cbxBirimId.DataSource = this.unitsBindingSource;
            this.cbxBirimId.DisplayMember = "BirimAdi";
            this.cbxBirimId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxBirimId.FormattingEnabled = true;
            this.cbxBirimId.Location = new System.Drawing.Point(157, 248);
            this.cbxBirimId.Name = "cbxBirimId";
            this.cbxBirimId.Size = new System.Drawing.Size(121, 26);
            this.cbxBirimId.TabIndex = 5;
            this.cbxBirimId.ValueMember = "Id";
            this.cbxBirimId.Click += new System.EventHandler(this.cbxBirimId_Click);
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.depoStokUygulamasiDataSet1;
            // 
            // depoStokUygulamasiDataSet1
            // 
            this.depoStokUygulamasiDataSet1.DataSetName = "DepoStokUygulamasiDataSet1";
            this.depoStokUygulamasiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxDepoId
            // 
            this.cbxDepoId.DataSource = this.warehousesBindingSource;
            this.cbxDepoId.DisplayMember = "DepoAdi";
            this.cbxDepoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDepoId.FormattingEnabled = true;
            this.cbxDepoId.Location = new System.Drawing.Point(494, 113);
            this.cbxDepoId.Name = "cbxDepoId";
            this.cbxDepoId.Size = new System.Drawing.Size(121, 26);
            this.cbxDepoId.TabIndex = 6;
            this.cbxDepoId.ValueMember = "Id";
            this.cbxDepoId.Click += new System.EventHandler(this.cbxDepoId_Click);
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "Warehouses";
            this.warehousesBindingSource.DataSource = this.depoStokUygulamasiDataSet2;
            // 
            // depoStokUygulamasiDataSet2
            // 
            this.depoStokUygulamasiDataSet2.DataSetName = "DepoStokUygulamasiDataSet2";
            this.depoStokUygulamasiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(28, 278);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKategoriFormuAc
            // 
            this.btnKategoriFormuAc.Location = new System.Drawing.Point(284, 150);
            this.btnKategoriFormuAc.Name = "btnKategoriFormuAc";
            this.btnKategoriFormuAc.Size = new System.Drawing.Size(44, 23);
            this.btnKategoriFormuAc.TabIndex = 8;
            this.btnKategoriFormuAc.Text = "Ekle";
            this.btnKategoriFormuAc.UseVisualStyleBackColor = true;
            this.btnKategoriFormuAc.Click += new System.EventHandler(this.btnKategoriFormuAc_Click);
            // 
            // btnDepoFormAc
            // 
            this.btnDepoFormAc.Location = new System.Drawing.Point(621, 113);
            this.btnDepoFormAc.Name = "btnDepoFormAc";
            this.btnDepoFormAc.Size = new System.Drawing.Size(45, 23);
            this.btnDepoFormAc.TabIndex = 9;
            this.btnDepoFormAc.Text = "Ekle";
            this.btnDepoFormAc.UseVisualStyleBackColor = true;
            this.btnDepoFormAc.Click += new System.EventHandler(this.btnDepoFormAc_Click);
            // 
            // btnBirimFormAc
            // 
            this.btnBirimFormAc.Location = new System.Drawing.Point(284, 251);
            this.btnBirimFormAc.Name = "btnBirimFormAc";
            this.btnBirimFormAc.Size = new System.Drawing.Size(44, 23);
            this.btnBirimFormAc.TabIndex = 9;
            this.btnBirimFormAc.Text = "Ekle";
            this.btnBirimFormAc.UseVisualStyleBackColor = true;
            this.btnBirimFormAc.Click += new System.EventHandler(this.btnBirimFormAc_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 550);
            this.Controls.Add(this.btnBirimFormAc);
            this.Controls.Add(this.btnDepoFormAc);
            this.Controls.Add(this.btnKategoriFormuAc);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cbxDepoId);
            this.Controls.Add(this.cbxBirimId);
            this.Controls.Add(this.cbxKategoriId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFormuTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tbxMaxStok);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxMinStok);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxRaf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxBirimFiyati);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxStokMiktari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxBarkodKodu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxUrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxBarkodKodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxStokMiktari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxBirimFiyati;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxRaf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxMinStok;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxMaxStok;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnFormuTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxKategoriId;
        private System.Windows.Forms.ComboBox cbxBirimId;
        private System.Windows.Forms.ComboBox cbxDepoId;
        private DepoStokUygulamasiDataSet depoStokUygulamasiDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private DepoStokUygulamasiDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DepoStokUygulamasiDataSet1 depoStokUygulamasiDataSet1;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private DepoStokUygulamasiDataSet1TableAdapters.UnitsTableAdapter unitsTableAdapter;
        private DepoStokUygulamasiDataSet2 depoStokUygulamasiDataSet2;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private DepoStokUygulamasiDataSet2TableAdapters.WarehousesTableAdapter warehousesTableAdapter;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKategoriFormuAc;
        private System.Windows.Forms.Button btnDepoFormAc;
        private System.Windows.Forms.Button btnBirimFormAc;
    }
}