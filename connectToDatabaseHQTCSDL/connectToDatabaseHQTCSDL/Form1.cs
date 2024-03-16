using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connectToDatabaseHQTCSDL
{
    public partial class Form1 : Form
    {
        string conn = @"Data Source=LEHUNG\THAIHUNG;Initial Catalog=test;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    MessageBox.Show("Da ket noi thanh cong");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);        
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                    MessageBox.Show("Da dong ket noi thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlCon= new SqlConnection(conn);
        }
    }
}
