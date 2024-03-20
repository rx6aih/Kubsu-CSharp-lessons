using Kub_c_.DAL.Entities;
using Kub_c_.DAL.Repositories;
using Kub_c_.DAL.Repositories;
using Kub_c_.ProductForms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kub_c_
{
    public partial class ProductsForm : Form
    {
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        EFUnitOfWork UoW = new EFUnitOfWork();
        public ProductsForm()
        {
            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            List<Product> products = UoW.Products.GetAll().ToList();
            dataGridView1.DataSource = products;

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductAdd pd = new ProductAdd();
            pd.ShowDialog();
            Update();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            DialogResult dr = MessageBox.Show("Удаление", "Вы уверены?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                UoW.Products.Delete(id);
                UoW.Save();
                Update();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
