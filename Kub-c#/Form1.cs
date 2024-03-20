
using Kub_c_.DAL.Repositories;

namespace Kub_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            EFUnitOfWork efUnitOfWork=new(); 
            InitializeComponent();
        }

        private void ïðîäóêòûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm pf = new ProductsForm();
            pf.ShowDialog();
        }
    }
}
