
using Kub_c_.ClientForms;
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

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm pf = new ProductsForm();
            pf.ShowDialog();
        }
		private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClientsForm cf = new ClientsForm();
			cf.ShowDialog();
		}
	}
}
