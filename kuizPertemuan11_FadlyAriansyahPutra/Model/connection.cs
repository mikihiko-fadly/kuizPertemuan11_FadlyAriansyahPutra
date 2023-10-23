﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuizPertemuan11_FadlyAriansyahPutra.Model
{
    internal class connection
    {
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;
        public MySqlConnection Conn;


        public MySqlConnection GetConn()
        {
            Conn = new MySqlConnection();
            Conn.ConnectionString = "server = localhost;user = root; database = unaspasim";

            try
            {
                Conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("koneksi gagal" + ex.Message);

            }
            return Conn;
        }
    }
}
