using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmeticShopManagementSystemCSharp
{
    public partial class Home2 : Form
    {
        public Home2()
        {
            InitializeComponent();
        }

        private void AddCosmeticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cosmetic obj = new CosmeticShopManagementSystemCSharp.Cosmetic();
            obj.ShowDialog();
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee obj = new CosmeticShopManagementSystemCSharp.Employee();
            obj.ShowDialog();
        }

        private void DealerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer obj = new AddCustomer();
            obj.ShowDialog();
        }

        private void SaledCosmeticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleDetails obj = new CosmeticShopManagementSystemCSharp.SaleDetails();
            obj.ShowDialog();
        }

        private void PurchasedCosmeticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseCosmetics obj = new PurchaseCosmetics();
            obj.ShowDialog();
        }

        private void SearchCosmeticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCosmetics obj = new SearchCosmetics();
            obj.ShowDialog();
        }

        private void CosmeticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCosmetics obj = new ViewCosmetics();
            obj.ShowDialog();
        }

        private void EmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewEmployee obj = new ViewEmployee();
            obj.ShowDialog();
        }

        private void SaledCosmeticsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewSaleCometics obj = new ViewSaleCometics();
            obj.ShowDialog();
        }

        private void PurchasedCosmeticsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewCosmeticsPurchaseData obj = new CosmeticShopManagementSystemCSharp.ViewCosmeticsPurchaseData();
            obj.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new CosmeticShopManagementSystemCSharp.Login();
            obj.ShowDialog();
        }
    }
}
