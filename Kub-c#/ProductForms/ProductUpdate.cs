using Kub_c_.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kub_c_.ProductForms
{
    public partial class ProductUpdate : Form
    {
        int id;
        public ProductUpdate(int id)
        {
            this.id = id;
            InitializeComponent();
            tb_Name.Text = UoW.Products.Get(id).Name;
            tb_Ed.Text = UoW.Products.Get(id).Ed;
        }
        EFUnitOfWork UoW = new EFUnitOfWork();

        private void btn_Yes_сlick(object sender, EventArgs e)
        {
            try
            {
                UoW.Products.Get(id).Name = tb_Name.Text;
                UoW.Products.Get(id).Ed = tb_Ed.Text;
                UoW.Save();
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_No_сlick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
