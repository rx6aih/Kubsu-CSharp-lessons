
using Kub_c_.ClientForms;
using Kub_c_.DAL.Repositories;
using Kub_c_.Futura;

namespace Kub_c_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			EFUnitOfWork efUnitOfWork = new();
			InitializeComponent();
		}

		private void ïğîäóêòûToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProductsForm pf = new ProductsForm();
			pf.ShowDialog();
		}
		private void êëèåíòûToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClientsForm cf = new ClientsForm();
			cf.ShowDialog();
		}

		private void íàêëàäíûåToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FuturaForm ff = new FuturaForm();
			ff.ShowDialog();
		}
	}
}
