
namespace Kasir_Betamart
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_namaProduk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_idProduk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_stokProduk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_hargaProduk = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.dataTabel = new System.Windows.Forms.DataGridView();
            this.btn_Tampilkandata = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Black", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(950, 10);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(242, 112);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Black", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(950, 139);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(242, 95);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Black", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(657, 10);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(258, 112);
            this.btnTambah.TabIndex = 14;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Black", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(657, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(258, 98);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama produk :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbx_namaProduk
            // 
            this.txtbx_namaProduk.BackColor = System.Drawing.SystemColors.Info;
            this.txtbx_namaProduk.Location = new System.Drawing.Point(194, 10);
            this.txtbx_namaProduk.Name = "txtbx_namaProduk";
            this.txtbx_namaProduk.Size = new System.Drawing.Size(406, 39);
            this.txtbx_namaProduk.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID produk      :";
            // 
            // txtbx_idProduk
            // 
            this.txtbx_idProduk.BackColor = System.Drawing.SystemColors.Info;
            this.txtbx_idProduk.Location = new System.Drawing.Point(194, 74);
            this.txtbx_idProduk.Name = "txtbx_idProduk";
            this.txtbx_idProduk.Size = new System.Drawing.Size(406, 39);
            this.txtbx_idProduk.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stok Produk   :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtbx_stokProduk
            // 
            this.txtbx_stokProduk.BackColor = System.Drawing.SystemColors.Info;
            this.txtbx_stokProduk.Location = new System.Drawing.Point(194, 136);
            this.txtbx_stokProduk.Name = "txtbx_stokProduk";
            this.txtbx_stokProduk.Size = new System.Drawing.Size(406, 39);
            this.txtbx_stokProduk.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Harga jual      :";
            // 
            // txtbx_hargaProduk
            // 
            this.txtbx_hargaProduk.BackColor = System.Drawing.SystemColors.Info;
            this.txtbx_hargaProduk.Location = new System.Drawing.Point(194, 195);
            this.txtbx_hargaProduk.Name = "txtbx_hargaProduk";
            this.txtbx_hargaProduk.Size = new System.Drawing.Size(406, 39);
            this.txtbx_hargaProduk.TabIndex = 10;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.btnClear);
            this.panel.Controls.Add(this.txtbx_hargaProduk);
            this.panel.Controls.Add(this.btnTambah);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.btnSimpan);
            this.panel.Controls.Add(this.txtbx_stokProduk);
            this.panel.Controls.Add(this.btnHapus);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtbx_idProduk);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtbx_namaProduk);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1209, 251);
            this.panel.TabIndex = 3;
            // 
            // dataTabel
            // 
            this.dataTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabel.Location = new System.Drawing.Point(12, 279);
            this.dataTabel.Name = "dataTabel";
            this.dataTabel.RowHeadersWidth = 82;
            this.dataTabel.RowTemplate.Height = 41;
            this.dataTabel.Size = new System.Drawing.Size(1192, 370);
            this.dataTabel.TabIndex = 17;
            this.dataTabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTabel_CellContentClick);
            this.dataTabel.SelectionChanged += new System.EventHandler(this.dataTabel_SelectionChanged);
            // 
            // btn_Tampilkandata
            // 
            this.btn_Tampilkandata.BackColor = System.Drawing.Color.Tan;
            this.btn_Tampilkandata.Font = new System.Drawing.Font("Segoe UI Black", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Tampilkandata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Tampilkandata.Location = new System.Drawing.Point(12, 665);
            this.btn_Tampilkandata.Name = "btn_Tampilkandata";
            this.btn_Tampilkandata.Size = new System.Drawing.Size(401, 62);
            this.btn_Tampilkandata.TabIndex = 18;
            this.btn_Tampilkandata.Text = "Segarkan Tabel";
            this.btn_Tampilkandata.UseVisualStyleBackColor = false;
            this.btn_Tampilkandata.Click += new System.EventHandler(this.btn_Tampilkandata_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1233, 749);
            this.Controls.Add(this.btn_Tampilkandata);
            this.Controls.Add(this.dataTabel);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gudang Beta";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_namaProduk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_idProduk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_stokProduk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_hargaProduk;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataTabel;
        private System.Windows.Forms.Button btn_Tampilkandata;
        private System.Windows.Forms.Button btnClear;
    }
}

