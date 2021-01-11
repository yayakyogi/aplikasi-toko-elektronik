/*
 * Created by SharpDevelop.
 * User: User
 * Date: 24/06/2020
 * Time: 4:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
namespace TOKO_ELEKTRONIK
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string koneksi="server=localhost;database=toko;uid=root;password=";
		MySqlConnection connection;
		MySqlCommand cmd;
		MySqlDataAdapter adap;
		DataSet ds;
		string update,id,nama,harga,jenis,tipe,stock,data;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void gagal(){
			MessageBox.Show("Query gagal","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
		}
		private void reset(){
			textBoxID.Clear();
			textBoxNama.Clear();
			textBoxHarga.Clear();
			textBoxStock.Clear();
		}
		// Load data
		private void tampilkanData(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT*FROM tb_daftarbarang";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				gagal();
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// Tambahkan Data
		private void tambahData(){
			Object pil1 = comboBoxJenis.SelectedItem;
			jenis = pil1.ToString();
			Object pil2 = comboBoxTipe.SelectedItem;
			tipe = pil2.ToString();
			id = textBoxID.Text;
			nama = textBoxNama.Text;
			harga = textBoxHarga.Text;
			stock = textBoxStock.Text;
			
			connection = new MySqlConnection(koneksi);
			connection.Open();
			
			try{
				cmd = connection.CreateCommand();
				cmd.CommandText = "INSERT INTO tb_daftarbarang (id,nama,jenis,tipe,harga,stock) VALUES (@id,@nama,@jenis,@tipe,@harga,@stock)";
				cmd.Parameters.AddWithValue("jenis",jenis);
				cmd.Parameters.AddWithValue("tipe",tipe);
				cmd.Parameters.AddWithValue("id",id);
				cmd.Parameters.AddWithValue("nama",nama);
				cmd.Parameters.AddWithValue("harga",harga);
				cmd.Parameters.AddWithValue("stock",stock);
				cmd.ExecuteNonQuery();
			}
			catch(Exception){
				gagal();
			}
			finally{
				if(connection.State==ConnectionState.Open){
					MessageBox.Show("Sukses menambahkan data","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
					connection.Close();
					logicTampil();
					reset();
				}
			}
		}
		// Edit data
		private void editData(){
			id = update;
			nama = textBoxNama.Text;
			harga = textBoxHarga.Text;
			stock = textBoxStock.Text;
			Object pil1 = comboBoxJenis.SelectedItem;
			jenis = pil1.ToString();
			Object pil2 = comboBoxTipe.SelectedItem;
			tipe = pil2.ToString();
			
			connection = new MySqlConnection(koneksi);
			connection.Open();
			
			try{
				cmd = connection.CreateCommand();
				cmd.CommandText = "UPDATE tb_daftarbarang SET nama=@nama,jenis=@jenis,tipe=@tipe,harga=@harga,stock=@stock WHERE id=@id";
				cmd.Parameters.AddWithValue("jenis",jenis);
				cmd.Parameters.AddWithValue("tipe",tipe);
				cmd.Parameters.AddWithValue("id",id);
				cmd.Parameters.AddWithValue("nama",nama);
				cmd.Parameters.AddWithValue("harga",harga);
				cmd.Parameters.AddWithValue("stock",stock);
				cmd.ExecuteNonQuery();
			}
			catch(Exception){
				gagal();
			}
			finally{
				if(connection.State==ConnectionState.Open){
					MessageBox.Show("Sukses menambahkan data","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
					connection.Close();
					logicTampil();
					reset();
				}
			}
		}
		// Hapus data
		private void hapusData(){
			DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data "+textBoxNama.Text+" ?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
			if(result==DialogResult.Yes){
				id =update;
				connection = new MySqlConnection(koneksi);
				connection.Open();
				cmd = connection.CreateCommand();
				cmd.CommandText="DELETE FROM tb_daftarbarang WHERE id=@id";
				cmd.Parameters.AddWithValue("id",id);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Sukses menghapus data","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
				logicTampil();
				reset();
			}
		}
		/*
		 * Tampilkan data berdasarkan treeview
		 */
		// TV
		private void TV(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jenis as Jenis_Barang,tb.tipe as Tipe_barang,tb.harga as Harga_Barang,tb.stock as Stock FROM tb_daftarbarang as tb WHERE jenis LIKE '%Televisi%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				gagal();
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// Radio
		private void radio(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jenis as Jenis_Barang,tb.tipe as Tipe_barang,tb.harga as Harga_Barang,tb.stock as Stock FROM tb_daftarbarang as tb WHERE jenis LIKE '%Radio%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				gagal();
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// Kulkas
		private void Kulkas(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jenis as Jenis_Barang,tb.tipe as Tipe_barang,tb.harga as Harga_Barang,tb.stock as Stock FROM tb_daftarbarang as tb WHERE jenis LIKE '%Kulkas%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				gagal();
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// TV Tabung
		private void tvtabung(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jenis as Jenis_Barang,tb.tipe as Tipe_barang,tb.harga as Harga_Barang,tb.stock as Stock FROM tb_daftarbarang as tb WHERE tipe LIKE '%Tabung%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				gagal();
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// TV LED
		private void tvled(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jenis as Jenis_Barang,tb.tipe as Tipe_barang,tb.harga as Harga_Barang,tb.stock as Stock FROM tb_daftarbarang as tb WHERE tipe LIKE '%LED%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				gagal();
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// TV LCD
		private void tvlcd(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jenis as Jenis_Barang,tb.tipe as Tipe_barang,tb.harga as Harga_Barang,tb.stock as Stock FROM tb_daftarbarang as tb WHERE tipe LIKE '%LCD%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				gagal();
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// Kulkas 1 pintu
		private void satupintu(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jenis as Jenis_Barang,tb.tipe as Tipe_barang,tb.harga as Harga_Barang,tb.stock as Stock FROM tb_daftarbarang as tb WHERE tipe LIKE '%1 Pintu%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				gagal();
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// Kulkas 2 pintu
		private void duapintu(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jenis as Jenis_Barang,tb.tipe as Tipe_barang,tb.harga as Harga_Barang,tb.stock as Stock FROM tb_daftarbarang as tb WHERE tipe LIKE '%2 Pintu%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				gagal();
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// Radio Wireless
		private void wireless(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jenis as Jenis_Barang,tb.tipe as Tipe_barang,tb.harga as Harga_Barang,tb.stock as Stock FROM tb_daftarbarang as tb WHERE tipe LIKE '%Wireless%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				gagal();
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// Radio Non Wireless
		private void nonwireless(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jenis as Jenis_Barang,tb.tipe as Tipe_barang,tb.harga as Harga_Barang,tb.stock as Stock FROM tb_daftarbarang as tb WHERE tipe LIKE '%Non Wireless%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				gagal();
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// Logic
		private void logic(){
			data = treeView1.SelectedNode.Text;
			if(data=="Tabung") tvtabung();
			else if(data=="LED") tvled();
			else if(data=="LCD") tvlcd();
			else if(data=="1 Pintu") satupintu();
			else if(data=="2 Pintu") duapintu();
			else if(data=="Wireless") wireless();
			else if(data=="Non Wireless") nonwireless();
			else if(data=="Televisi") TV();
			else if(data=="Radio") radio();
			else if(data=="Kulkas") Kulkas();
		}
		private void logicTampil(){
			Object pilihan = comboBoxTipe.SelectedItem;
			tipe = pilihan.ToString();
			if(tipe=="Tabung") tvtabung();
			else if(tipe=="LED") tvled();
			else if(tipe=="LCD") tvlcd();
			else if(tipe=="1 Pintu") satupintu();
			else if(tipe=="2 Pintu") duapintu();
			else if(tipe=="Wireless") wireless();
			else if(tipe=="Non Wireless") nonwireless();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			comboBoxJenis.Items.Add("Televisi");
			comboBoxJenis.Items.Add("Kulkas");
			comboBoxJenis.Items.Add("Radio");
			
			treeView1.Nodes.Add("Daftar Barang");
			treeView1.Nodes[0].Nodes.Add("Televisi");
			treeView1.Nodes[0].Nodes[0].Nodes.Add("Tabung");
			treeView1.Nodes[0].Nodes[0].Nodes.Add("LED");
			treeView1.Nodes[0].Nodes[0].Nodes.Add("LCD");
			treeView1.Nodes[0].Nodes.Add("Kulkas");
			treeView1.Nodes[0].Nodes[1].Nodes.Add("1 Pintu");
			treeView1.Nodes[0].Nodes[1].Nodes.Add("2 Pintu");
			treeView1.Nodes[0].Nodes.Add("Radio");
			treeView1.Nodes[0].Nodes[2].Nodes.Add("Wireless");
			treeView1.Nodes[0].Nodes[2].Nodes.Add("Non Wireless");
		}
		void ComboBoxJenisSelectedIndexChanged(object sender, EventArgs e)
		{
			Object pilihan = comboBoxJenis.SelectedItem;
			jenis = pilihan.ToString();
			if(jenis=="Televisi"){
				comboBoxTipe.Items.Clear();
				comboBoxTipe.Items.Add("Tabung");
				comboBoxTipe.Items.Add("LED");
				comboBoxTipe.Items.Add("LCD");
			}
			else if(jenis=="Kulkas"){
				comboBoxTipe.Items.Clear();
				comboBoxTipe.Items.Add("1 Pintu");
				comboBoxTipe.Items.Add("2 Pintu");
			}
			else if(jenis=="Radio"){
				comboBoxTipe.Items.Clear();
				comboBoxTipe.Items.Add("Wireless");
				comboBoxTipe.Items.Add("Non Wireless");
			}
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			update=dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
			nama=dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
			jenis=dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
			tipe=dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
			harga=dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
			stock=dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
			textBoxID.Text=update;
			textBoxID.Enabled=false;
			textBoxNama.Text=nama;
			comboBoxJenis.SelectedItem=jenis;
			comboBoxTipe.SelectedItem=tipe;
			textBoxHarga.Text=harga;
			textBoxStock.Text=stock;
		}
		void ButtonTampilkanClick(object sender, EventArgs e)
		{
			logic();
		}
		void ButtonTambahClick(object sender, EventArgs e)
		{
			tambahData();
		}
		void ButtonEditClick(object sender, EventArgs e)
		{
			editData();
		}
		void ButtonHapusClick(object sender, EventArgs e)
		{
			hapusData();
		}
	}
}
