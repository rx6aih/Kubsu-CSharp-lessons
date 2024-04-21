using Kub_c_.ClientForms;
using Kub_c_.DAL.Entities;
using Kub_c_.DAL.Repositories;
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

namespace Kub_c_.Futura
{
	public partial class FuturaForm : Form
	{
		DataTable dt = new DataTable();
		DataSet ds = new DataSet();
		EFUnitOfWork UoW = new EFUnitOfWork();
		public FuturaForm()
		{
			StartPosition = FormStartPosition.CenterParent;
			InitializeComponent();
			Update();
		}
		public void Update()
		{
			List<DAL.Entities.Futura> futuras = UoW.Futuras.GetAll().ToList();
			dataGridView1.DataSource = futuras;

			List<DAL.Entities.FuturaInfo> futurasInfo = UoW.FuturasInfo.GetAll().ToList();
			dataGridView2.DataSource = futurasInfo;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FuturaAdd cd = new FuturaAdd();
			cd.ShowDialog();
			Update();
		}

		private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
			DialogResult dr = MessageBox.Show("Удаление", "Вы уверены?", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				UoW.Futuras.Delete(id);
				UoW.Save();
				Update();
			}
		}

		private void FuturaForm_Load(object sender, EventArgs e)
		{

		}

		private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			int id = (int)dataGridView2.CurrentRow.Cells["ID"].Value;
			DialogResult dr = MessageBox.Show("Удаление", "Вы уверены?", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				UoW.FuturasInfo.Delete(id);
				UoW.Save();
				Update();
			}
		}

		private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
			FuturaInfoAdd fid = new FuturaInfoAdd(id);
			fid.ShowDialog();
			Update();
		}
	}
}
