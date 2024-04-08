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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kub_c_.ClientForms
{
	public partial class ClientAdd : Form
	{
		EFUnitOfWork UoW = new EFUnitOfWork();

		public ClientAdd()
		{
			InitializeComponent();
		}

		private void btn_Yes_Click(object sender, EventArgs e)
		{
			try
			{
				UoW.Clients.Create(new Client { Name = tb_Name.Text, Adress = tb_Adress.Text, Phone = tb_Phone.Text });
				UoW.Save();
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
