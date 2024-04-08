namespace Kub_c_.ClientForms
{
	partial class ClientsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dataGridView1 = new DataGridView();
			menuStrip1 = new MenuStrip();
			добавитьToolStripMenuItem = new ToolStripMenuItem();
			изменитьToolStripMenuItem = new ToolStripMenuItem();
			удалитьToolStripMenuItem = new ToolStripMenuItem();
			выходToolStripMenuItem = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 27);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(630, 265);
			dataGridView1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, изменитьToolStripMenuItem, удалитьToolStripMenuItem, выходToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(696, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// добавитьToolStripMenuItem
			// 
			добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
			добавитьToolStripMenuItem.Size = new Size(71, 20);
			добавитьToolStripMenuItem.Text = "Добавить";
			добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
			// 
			// изменитьToolStripMenuItem
			// 
			изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
			изменитьToolStripMenuItem.Size = new Size(73, 20);
			изменитьToolStripMenuItem.Text = "Изменить";
			изменитьToolStripMenuItem.Click += изменитьToolStripMenuItem_Click;
			// 
			// удалитьToolStripMenuItem
			// 
			удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			удалитьToolStripMenuItem.Size = new Size(63, 20);
			удалитьToolStripMenuItem.Text = "Удалить";
			удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
			// 
			// выходToolStripMenuItem
			// 
			выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			выходToolStripMenuItem.Size = new Size(54, 20);
			выходToolStripMenuItem.Text = "Выход";
			выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
			// 
			// ClientsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(696, 392);
			Controls.Add(dataGridView1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "ClientsForm";
			Text = "ClientsForm";
			Load += ClientsForm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem добавитьToolStripMenuItem;
		private ToolStripMenuItem изменитьToolStripMenuItem;
		private ToolStripMenuItem удалитьToolStripMenuItem;
		private ToolStripMenuItem выходToolStripMenuItem;
	}
}