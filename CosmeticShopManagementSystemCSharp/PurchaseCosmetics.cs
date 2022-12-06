using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CosmeticShopManagementSystemCSharp
{
    public partial class PurchaseCosmetics : Form
    {
        public PurchaseCosmetics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            ConnectionString = ConnectionString.Replace("\\bin\\Debug", "\\cosmetics.mdf");
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + ConnectionString + ";Integrated Security=True;Connect Timeout=30");
            con.Open();
            string gen = string.Empty;

            try
            {
                string str = "INSERT INTO purchase(d_name,c_name,brand,price,descr,qnt,t_price,date_p) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"  + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(Id) from purchase;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Purchased Cosmetic Details Information Successfully..");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox1.Text = "";
                    
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
