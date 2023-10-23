using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuizPertemuan11_FadlyAriansyahPutra.Controller
{
    internal class dataController : Model.connection
    {
        public DataTable tampilData() 
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM mahasiswa";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void tambahData(string nim, string nama, string alamat, string prodi, string hobi)
        {
            string tambah = "insert into mahasiswa set(" + "@nim = NIM,@nama=Nama,@alamat=Alamat,@prodi=Prodi,@hobi=Hobi)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@nim", MySqlConnector.MySqlDbType.VarChar).Value = nim;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@alamat", MySqlConnector.MySqlDbType.VarChar).Value = alamat;
                cmd.Parameters.Add("@prodi", MySqlConnector.MySqlDbType.VarChar).Value = prodi;
                cmd.Parameters.Add("@hobi", MySqlConnector.MySqlDbType.VarChar).Value = hobi;

            }
            catch(Exception ex)
            {
                MessageBox.Show("gagal" + ex.Message);
            }

        }
    }
}
 