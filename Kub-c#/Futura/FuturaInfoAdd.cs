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
	public partial class FuturaInfoAdd : Form
	{
		private EFUnitOfWork UoW = new EFUnitOfWork();

		private int fId;
		public FuturaInfoAdd(int id)
		{
			fId = id;
			InitializeComponent();
			Update();
		}

		public void Update()
		{
			List<Product> products = UoW.Products.GetAll().ToList();
			productComboBox1.DataSource = products;
			productComboBox1.DisplayMember = "Name";
			productComboBox1.ValueMember = "Id";
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				UoW.FuturasInfo.Create(new DAL.Entities.FuturaInfo
				{
					ProductId = Convert.ToInt32(productComboBox1.SelectedValue),
					FuturaId = fId,
					Quantity = Convert.ToInt32(quantityTextBox.Text),
					Price = Convert.ToInt32(priceTextBox.Text)
				});
				UoW.Save();
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
