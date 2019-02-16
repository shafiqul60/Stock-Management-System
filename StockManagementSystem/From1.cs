using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace StockManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 

            SqlConnection connection = new SqlConnection(@"Data Source=SHAFIQUL-PC;Initial Catalog=StockManagementSystem;Integrated Security=True");
            string query = "SELECT * FROM LoginPanel WHERE UserName = '"+textBox1.Text.Trim() + "' and UserPassword = '"+textBox2.Text.Trim () +"' ";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
            DataTable DTBL = new DataTable();
            sqlData.Fill(DTBL);

            if(DTBL.Rows.Count == 1)
            {
                MainUI mainui = new MainUI();
                this.Hide();
                mainui.Show();
            }

            else
            {
                MessageBox.Show("Please Check Your User Name And Password ");
            }

                connection.Close();

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
