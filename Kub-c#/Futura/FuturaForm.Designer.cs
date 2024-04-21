namespace Kub_c_.Futura
{
	partial class FuturaForm
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
			удалитьToolStripMenuItem = new ToolStripMenuItem();
			dataGridView2 = new DataGridView();
			menuStrip2 = new MenuStrip();
			добавитьToolStripMenuItem1 = new ToolStripMenuItem();
			удалитьToolStripMenuItem1 = new ToolStripMenuItem();
			label1 = new Label();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			menuStrip2.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(9, 37);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(530, 150);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// menuStrip1
			// 
			menuStrip1.Anchor = AnchorStyles.Top;
			menuStrip1.BackColor = SystemColors.Control;
			menuStrip1.Dock = DockStyle.None;
			menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, удалитьToolStripMenuItem });
			menuStrip1.Location = new Point(9, 190);
			menuStrip1.MinimumSize = new Size(160, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(6, 2, 150, 2);
			menuStrip1.Size = new Size(302, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// добавитьToolStripMenuItem
			// 
			добавитьToolStripMenuItem.BackColor = Color.Gainsboro;
			добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
			добавитьToolStripMenuItem.Size = new Size(71, 20);
			добавитьToolStripMenuItem.Text = "Добавить";
			добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
			// 
			// удалитьToolStripMenuItem
			// 
			удалитьToolStripMenuItem.BackColor = Color.Gainsboro;
			удалитьToolStripMenuItem.Margin = new Padding(10, 0, 0, 0);
			удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			удалитьToolStripMenuItem.Size = new Size(63, 20);
			удалитьToolStripMenuItem.Text = "Удалить";
			удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
			// 
			// dataGridView2
			// 
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(9, 275);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.Size = new Size(530, 150);
			dataGridView2.TabIndex = 4;
			// 
			// menuStrip2
			// 
			menuStrip2.BackColor = SystemColors.Control;
			menuStrip2.Dock = DockStyle.None;
			menuStrip2.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem1, удалитьToolStripMenuItem1 });
			menuStrip2.Location = new Point(9, 428);
			menuStrip2.Name = "menuStrip2";
			menuStrip2.Size = new Size(152, 24);
			menuStrip2.TabIndex = 5;
			menuStrip2.Text = "menuStrip2";
			// 
			// добавитьToolStripMenuItem1
			// 
			добавитьToolStripMenuItem1.BackColor = Color.Gainsboro;
			добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
			добавитьToolStripMenuItem1.Size = new Size(71, 20);
			добавитьToolStripMenuItem1.Text = "Добавить";
			добавитьToolStripMenuItem1.Click += добавитьToolStripMenuItem1_Click;
			// 
			// удалитьToolStripMenuItem1
			// 
			удалитьToolStripMenuItem1.BackColor = Color.Gainsboro;
			удалитьToolStripMenuItem1.Margin = new Padding(10, 0, 0, 0);
			удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
			удалитьToolStripMenuItem1.Size = new Size(63, 20);
			удалитьToolStripMenuItem1.Text = "Удалить";
			удалитьToolStripMenuItem1.Click += удалитьToolStripMenuItem1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F);
			label1.Location = new Point(9, 9);
			label1.Name = "label1";
			label1.Size = new Size(108, 25);
			label1.TabIndex = 6;
			label1.Text = "Накладные";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14F);
			label2.Location = new Point(9, 247);
			label2.Name = "label2";
			label2.Size = new Size(194, 25);
			label2.TabIndex = 7;
			label2.Text = "Данные о накладных";
			// 
			// FuturaForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(546, 463);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dataGridView2);
			Controls.Add(dataGridView1);
			Controls.Add(menuStrip1);
			Controls.Add(menuStrip2);
			MainMenuStrip = menuStrip1;
			Name = "FuturaForm";
			Text = "FuturaForm";
			Load += FuturaForm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			menuStrip2.ResumeLayout(false);
			menuStrip2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem добавитьToolStripMenuItem;
		private ToolStripMenuItem удалитьToolStripMenuItem;
		private DataGridView dataGridView2;
		private MenuStrip menuStrip2;
		private ToolStripMenuItem добавитьToolStripMenuItem1;
		private ToolStripMenuItem удалитьToolStripMenuItem1;
		private Label label1;
		private Label label2;
	}
}