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

namespace Kub_c_.Futura
{
	public partial class FuturaAdd : Form
	{
		EFUnitOfWork UoW = new EFUnitOfWork();
		public FuturaAdd()
		{
			InitializeComponent();
			Update();
		}
		public void Update()
		{
			List<Client> clients = UoW.Clients.GetAll().ToList();
			comboBoxClientName.DataSource = clients;
			comboBoxClientName.DisplayMember = "Name";
			comboBoxClientName.ValueMember = "Id";
		}

		private void btnYes_Click_Click(object sender, EventArgs e)
		{
			try
			{
				UoW.Futuras.Create(new DAL.Entities.Futura
				{
					ClientId = Convert.ToInt32(comboBoxClientName.SelectedValue),
					Data = dateTimePicker1.Value.Date.ToString()
				});
				UoW.Save();
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnNo_Click_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
