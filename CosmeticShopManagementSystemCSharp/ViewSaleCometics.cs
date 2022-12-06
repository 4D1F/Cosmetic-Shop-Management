using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace CosmeticShopManagementSystemCSharp
{
    public partial class ViewSaleCometics : Form
    {
        public ViewSaleCometics()
        {
            InitializeComponent();
        }

        private void ViewSaleCometics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cosmeticsDataSet5.sale1' table. You can move, or remove it, as needed.
            this.sale1TableAdapter.Fill(this.cosmeticsDataSet5.sale1);
            string ConnectionString = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            ConnectionString = ConnectionString.Replace("\\bin\\Debug", "\\cosmetics.mdf");
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + ConnectionString + ";Integrated Security=True;Connect Timeout=30"))
            {

                string str2 = "SELECT * FROM sale1";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
