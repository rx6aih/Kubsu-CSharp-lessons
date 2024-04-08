using Kub_c_.DAL.Entities;
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

namespace Kub_c_.ClientForms
{
	public partial class ClientsForm : Form
	{
		DataTable dt = new DataTable();
		DataSet ds = new DataSet();
		EFUnitOfWork UoW = new EFUnitOfWork();
		public ClientsForm()
		{
			StartPosition = FormStartPosition.CenterParent;
			InitializeComponent();
			Update();
		}

		public void Update()
		{
			NpgsqlDataAdapter da = new NpgsqlDataAdapter();
			List<Client> clients = UoW.Clients.GetAll().ToList();
			dataGridView1.DataSource = clients;

		}
		private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClientAdd cd = new ClientAdd();
			cd.ShowDialog();
			Update();
		}

		private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
			DialogResult dr = MessageBox.Show("Удаление", "Вы уверены?", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				UoW.Clients.Delete(id);
				UoW.Save();
				Update();
			}
		}

		private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
			ClientUpdate pu = new ClientUpdate(id);
			pu.ShowDialog();
			Update();
		}

		private void ClientsForm_Load(object sender, EventArgs e)
		{

		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
