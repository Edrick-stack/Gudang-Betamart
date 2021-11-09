using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Kasir_Betamart
{
    public partial class FormHome : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public FormHome()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Sekolah\Kelas XII RPL 4\Bootcamp\Kasir Betamart\Beta_db.mdb;Persist Security Info=False;";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLihat_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Produk where Produk_ID=" + txtbx_idProduk.Text + "";
                command.CommandText = query;
                MessageBox.Show("Yakin Ingin Menghapus Data '"+query+"' ?");

                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil dihapus !");
                connection.Close();
            }
            catch (Exception bh)
            {
                MessageBox.Show("Error  " + bh);
            }
        }

        private void txtbx_cariProduk_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Produk set Nama_produk ='"+ txtbx_namaProduk.Text +"' ,Stok_produk ="+ txtbx_stokProduk.Text +" ,Harga_produk ="+ txtbx_hargaProduk.Text +" where Produk_ID="+ txtbx_idProduk.Text +"";
                command.CommandText = query;
                MessageBox.Show("Yakin Ingin mengubah Produk '"+query+"' ?");

                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil diubah !");
                connection.Close();
            }
            catch (Exception bu)
            {
                MessageBox.Show("Error  " + bu);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Produk (Nama_produk,Produk_ID,Stok_produk,Harga_produk) VALUES('"+ txtbx_namaProduk.Text + "','" + txtbx_idProduk.Text + "','" + txtbx_stokProduk.Text + "','" + txtbx_hargaProduk.Text + "')";
                MessageBox.Show("Ingin Menambah Produk ?");

                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil disimpan !");
                connection.Close();
            }
            catch (Exception bt)
            {
                MessageBox.Show("Error  " + bt);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();            
        }
        void clear()
        {
            txtbx_namaProduk.Clear();
            txtbx_idProduk.Clear();
            txtbx_stokProduk.Clear();
            txtbx_hargaProduk.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        private void btn_Tampilkandata_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Produk";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataTabel.DataSource = dt;


                connection.Close();
            }
            catch (Exception bl)
            {
                MessageBox.Show("Error  " + bl);
            }
        }

        private void dataTabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dataTabel.Rows[e.RowIndex];
                txtbx_idProduk.Text = row.Cells[0].Value.ToString();
                txtbx_namaProduk.Text = row.Cells[1].Value.ToString();
                txtbx_stokProduk.Text = row.Cells[2].Value.ToString();
                txtbx_hargaProduk.Text = row.Cells[3].Value.ToString();
            }
        }

        private void dataTabel_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataTabel.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txtbx_idProduk.Text = row.Cells[0].Value.ToString();
                txtbx_namaProduk.Text = row.Cells[1].Value.ToString();
                txtbx_stokProduk.Text = row.Cells[2].Value.ToString();
                txtbx_hargaProduk.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
