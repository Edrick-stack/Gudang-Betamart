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
    public partial class FormLogin : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public FormLogin()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Sekolah\Kelas XII RPL 4\Bootcamp\Kasir Betamart\Userinfo_db.mdb;Persist Security Info=False;";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Info where Username='"+ txtbx_Username.Text + "' and Password="+ txtbx_Password.Text+"";
            
            OleDbDataReader reader= command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
                //count++;
                //
            }
            if (count == 1)
            {
                MessageBox.Show("Username dan Password Benar !");
                connection.Close();
                connection.Dispose();
                this.Hide();
                FormHome f1 = new FormHome();
                f1.ShowDialog();
            }
            else if (count > 1)
            {
                MessageBox.Show("Username dan Password ada yang Sama !");
            }
            else
            {
                MessageBox.Show("Username dan Password Salah !");
            }

            connection.Close();
        }
    }
}
