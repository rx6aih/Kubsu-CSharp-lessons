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

namespace Kub_c_.ClientForms
{
	public partial class ClientUpdate : Form
	{
		int id;

		public ClientUpdate(int id)
		{
			this.id = id;
			InitializeComponent();
			tb_Name.Text = UoW.Clients.Get(id).Name;
			tb_Adress.Text = UoW.Clients.Get(id).Adress;
			tb_Phone.Text = UoW.Clients.Get(id).Phone;
		}
		EFUnitOfWork UoW = new EFUnitOfWork();


		private void btn_Yes_Click(object sender, EventArgs e)
		{
			try
			{
				UoW.Clients.Get(id).Name = tb_Name.Text;
				UoW.Clients.Get(id).Adress = tb_Adress.Text;
				UoW.Clients.Get(id).Phone = tb_Phone.Text;
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
