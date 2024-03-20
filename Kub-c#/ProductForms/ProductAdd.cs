using Kub_c_.DAL.Entities;
using Kub_c_.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kub_c_.ProductForms
{
    public partial class ProductAdd : Form
    {
        EFUnitOfWork UoW = new EFUnitOfWork();
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            try
            {
                UoW.Products.Create(new Product { Name = textBox1.Text, Ed = textBox2.Text });
                UoW.Save();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
