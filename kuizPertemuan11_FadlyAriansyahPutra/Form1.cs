using kuizPertemuan11_FadlyAriansyahPutra.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuizPertemuan11_FadlyAriansyahPutra
{
    public partial class Form1 : Form
    {
        private dataController dtctrl;

        public Form1()
        {
            dtctrl = new dataController();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            dataGridView1.DataSource = dtctrl.tampilData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            this.Hide();
        }


    }
}
