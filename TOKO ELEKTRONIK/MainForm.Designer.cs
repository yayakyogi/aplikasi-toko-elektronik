/*
 * Created by SharpDevelop.
 * User: PCKURO
 * Date: 24/06/2020
 * Time: 4:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TOKO_ELEKTRONIK
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonTampilkan;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxJenis;
		private System.Windows.Forms.ComboBox comboBoxTipe;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxHarga;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxStock;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonTambah;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonHapus;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.Label label6;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonTampilkan = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxJenis = new System.Windows.Forms.ComboBox();
			this.comboBoxTipe = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxHarga = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxStock = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonTambah = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonHapus = new System.Windows.Forms.Button();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(26, 25);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(164, 274);
			this.treeView1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(225, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(645, 274);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// buttonTampilkan
			// 
			this.buttonTampilkan.BackColor = System.Drawing.Color.Chartreuse;
			this.buttonTampilkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTampilkan.Location = new System.Drawing.Point(46, 338);
			this.buttonTampilkan.Name = "buttonTampilkan";
			this.buttonTampilkan.Size = new System.Drawing.Size(103, 34);
			this.buttonTampilkan.TabIndex = 2;
			this.buttonTampilkan.Text = "TAMPILKAN";
			this.buttonTampilkan.UseVisualStyleBackColor = false;
			this.buttonTampilkan.Click += new System.EventHandler(this.ButtonTampilkanClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(448, 354);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nama Barang";
			// 
			// textBoxNama
			// 
			this.textBoxNama.Location = new System.Drawing.Point(537, 354);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(149, 20);
			this.textBoxNama.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(225, 323);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Jenis Barang";
			// 
			// comboBoxJenis
			// 
			this.comboBoxJenis.FormattingEnabled = true;
			this.comboBoxJenis.Location = new System.Drawing.Point(309, 320);
			this.comboBoxJenis.Name = "comboBoxJenis";
			this.comboBoxJenis.Size = new System.Drawing.Size(121, 21);
			this.comboBoxJenis.TabIndex = 6;
			this.comboBoxJenis.SelectedIndexChanged += new System.EventHandler(this.ComboBoxJenisSelectedIndexChanged);
			// 
			// comboBoxTipe
			// 
			this.comboBoxTipe.FormattingEnabled = true;
			this.comboBoxTipe.Location = new System.Drawing.Point(309, 417);
			this.comboBoxTipe.Name = "comboBoxTipe";
			this.comboBoxTipe.Size = new System.Drawing.Size(121, 21);
			this.comboBoxTipe.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(225, 416);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Tipe Barang";
			// 
			// textBoxHarga
			// 
			this.textBoxHarga.Location = new System.Drawing.Point(537, 386);
			this.textBoxHarga.Name = "textBoxHarga";
			this.textBoxHarga.Size = new System.Drawing.Size(149, 20);
			this.textBoxHarga.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(448, 385);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Harga Barang";
			// 
			// textBoxStock
			// 
			this.textBoxStock.Location = new System.Drawing.Point(537, 419);
			this.textBoxStock.Name = "textBoxStock";
			this.textBoxStock.Size = new System.Drawing.Size(55, 20);
			this.textBoxStock.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(448, 419);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Stock Barang";
			// 
			// buttonTambah
			// 
			this.buttonTambah.BackColor = System.Drawing.Color.SkyBlue;
			this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTambah.Location = new System.Drawing.Point(723, 317);
			this.buttonTambah.Name = "buttonTambah";
			this.buttonTambah.Size = new System.Drawing.Size(75, 33);
			this.buttonTambah.TabIndex = 13;
			this.buttonTambah.Text = "TAMBAH";
			this.buttonTambah.UseVisualStyleBackColor = false;
			this.buttonTambah.Click += new System.EventHandler(this.ButtonTambahClick);
			// 
			// buttonEdit
			// 
			this.buttonEdit.BackColor = System.Drawing.Color.Yellow;
			this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEdit.Location = new System.Drawing.Point(723, 364);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(75, 30);
			this.buttonEdit.TabIndex = 14;
			this.buttonEdit.Text = "EDIT";
			this.buttonEdit.UseVisualStyleBackColor = false;
			this.buttonEdit.Click += new System.EventHandler(this.ButtonEditClick);
			// 
			// buttonHapus
			// 
			this.buttonHapus.BackColor = System.Drawing.Color.Red;
			this.buttonHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonHapus.Location = new System.Drawing.Point(723, 414);
			this.buttonHapus.Name = "buttonHapus";
			this.buttonHapus.Size = new System.Drawing.Size(75, 29);
			this.buttonHapus.TabIndex = 15;
			this.buttonHapus.Text = "HAPUS";
			this.buttonHapus.UseVisualStyleBackColor = false;
			this.buttonHapus.Click += new System.EventHandler(this.ButtonHapusClick);
			// 
			// textBoxID
			// 
			this.textBoxID.Location = new System.Drawing.Point(537, 322);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(88, 20);
			this.textBoxID.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(448, 322);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "ID Barang";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 476);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.buttonHapus);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonTambah);
			this.Controls.Add(this.textBoxStock);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxHarga);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBoxTipe);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxJenis);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonTampilkan);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.treeView1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DAFTAR BARANG TOKO ELEKTRONIK";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
