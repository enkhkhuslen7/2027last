using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=172.16.2.26;user id=Lazy;password=ENMDC32w1$;database=enkhkhuslen";
            MySqlConnection conn = new MySqlConnection(connStr);
            try {
                conn.Open();
                DataTable tbl = new DataTable();
                MySqlDataAdapter dataAdp = new MySqlDataAdapter("select * from memotable", conn);
                dataAdp.Fill(tbl);
                dataGridView1.DataSource = tbl;
                conn.Close();
            }
            catch (MySqlException mse) {
                MessageBox.Show(mse.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=172.16.2.26;user id=tateno;password=ae21215926;database=tateno";
            MySqlConnection conn = new MySqlConnection(connStr);
            try {
                conn.Open();
                DataTable tbl = new DataTable();
                for (int i = 0; i < tbl.Rows.Count; i++) {
                    DataRow row = tbl.Rows[i];  // データ行

                    // 右のリストボックスにアイテムを追加
                }
                conn.Close();
            }
            catch (MySqlException mse) {
                MessageBox.Show(mse.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
