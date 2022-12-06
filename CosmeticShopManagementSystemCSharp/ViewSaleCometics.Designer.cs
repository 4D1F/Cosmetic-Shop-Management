namespace CosmeticShopManagementSystemCSharp
{
    partial class ViewSaleCometics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cosnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cosmeticsDataSet5 = new CosmeticShopManagementSystemCSharp.cosmeticsDataSet5();
            this.sale1TableAdapter = new CosmeticShopManagementSystemCSharp.cosmeticsDataSet5TableAdapters.sale1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticsDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(226, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 34);
            this.label2.TabIndex = 68;
            this.label2.Text = "View Sale Cosmetics";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.cosnameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.qntDataGridViewTextBoxColumn,
            this.tpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sale1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 330);
            this.dataGridView1.TabIndex = 70;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "c_name";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "c_name";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            // 
            // cosnameDataGridViewTextBoxColumn
            // 
            this.cosnameDataGridViewTextBoxColumn.DataPropertyName = "cos_name";
            this.cosnameDataGridViewTextBoxColumn.HeaderText = "cos_name";
            this.cosnameDataGridViewTextBoxColumn.Name = "cosnameDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "descr";
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // qntDataGridViewTextBoxColumn
            // 
            this.qntDataGridViewTextBoxColumn.DataPropertyName = "qnt";
            this.qntDataGridViewTextBoxColumn.HeaderText = "qnt";
            this.qntDataGridViewTextBoxColumn.Name = "qntDataGridViewTextBoxColumn";
            // 
            // tpriceDataGridViewTextBoxColumn
            // 
            this.tpriceDataGridViewTextBoxColumn.DataPropertyName = "t_price";
            this.tpriceDataGridViewTextBoxColumn.HeaderText = "t_price";
            this.tpriceDataGridViewTextBoxColumn.Name = "tpriceDataGridViewTextBoxColumn";
            // 
            // sale1BindingSource
            // 
            this.sale1BindingSource.DataMember = "sale1";
            this.sale1BindingSource.DataSource = this.cosmeticsDataSet5;
            // 
            // cosmeticsDataSet5
            // 
            this.cosmeticsDataSet5.DataSetName = "cosmeticsDataSet5";
            this.cosmeticsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sale1TableAdapter
            // 
            this.sale1TableAdapter.ClearBeforeFill = true;
            // 
            // ViewSaleCometics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 447);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "ViewSaleCometics";
            this.Text = "ViewSaleCometics";
            this.Load += new System.EventHandler(this.ViewSaleCometics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticsDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cosmeticsDataSet5 cosmeticsDataSet5;
        private System.Windows.Forms.BindingSource sale1BindingSource;
        private cosmeticsDataSet5TableAdapters.sale1TableAdapter sale1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpriceDataGridViewTextBoxColumn;
    }
}