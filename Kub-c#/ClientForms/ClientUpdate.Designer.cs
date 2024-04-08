namespace Kub_c_.ClientForms
{
	partial class ClientUpdate
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
			tb_Name = new TextBox();
			tb_Adress = new TextBox();
			tb_Phone = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			btn_Yes = new Button();
			btn_No = new Button();
			SuspendLayout();
			// 
			// tb_Name
			// 
			tb_Name.Font = new Font("Segoe UI", 12F);
			tb_Name.Location = new Point(104, 43);
			tb_Name.Name = "tb_Name";
			tb_Name.Size = new Size(137, 29);
			tb_Name.TabIndex = 0;
			// 
			// tb_Adress
			// 
			tb_Adress.Font = new Font("Segoe UI", 12F);
			tb_Adress.Location = new Point(104, 77);
			tb_Adress.Name = "tb_Adress";
			tb_Adress.Size = new Size(137, 29);
			tb_Adress.TabIndex = 1;
			// 
			// tb_Phone
			// 
			tb_Phone.Font = new Font("Segoe UI", 12F);
			tb_Phone.Location = new Point(104, 114);
			tb_Phone.Name = "tb_Phone";
			tb_Phone.Size = new Size(137, 29);
			tb_Phone.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(26, 46);
			label1.Name = "label1";
			label1.Size = new Size(41, 21);
			label1.TabIndex = 3;
			label1.Text = "Имя";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(26, 80);
			label2.Name = "label2";
			label2.Size = new Size(53, 21);
			label2.TabIndex = 4;
			label2.Text = "Адрес";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(26, 117);
			label3.Name = "label3";
			label3.Size = new Size(71, 21);
			label3.TabIndex = 5;
			label3.Text = "Телефон";
			// 
			// btn_Yes
			// 
			btn_Yes.Font = new Font("Segoe UI", 12F);
			btn_Yes.Location = new Point(70, 162);
			btn_Yes.Name = "btn_Yes";
			btn_Yes.Size = new Size(75, 40);
			btn_Yes.TabIndex = 6;
			btn_Yes.Text = "Да";
			btn_Yes.UseVisualStyleBackColor = true;
			btn_Yes.Click += btn_Yes_Click;
			// 
			// btn_No
			// 
			btn_No.Font = new Font("Segoe UI", 12F);
			btn_No.Location = new Point(166, 162);
			btn_No.Name = "btn_No";
			btn_No.Size = new Size(75, 40);
			btn_No.TabIndex = 7;
			btn_No.Text = "Нет";
			btn_No.UseVisualStyleBackColor = true;
			btn_No.Click += btn_No_Click;
			// 
			// ClientUpdate
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(281, 228);
			Controls.Add(btn_No);
			Controls.Add(btn_Yes);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tb_Phone);
			Controls.Add(tb_Adress);
			Controls.Add(tb_Name);
			Name = "ClientUpdate";
			Text = "ClientUpdate";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tb_Name;
		private TextBox tb_Adress;
		private TextBox tb_Phone;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button btn_Yes;
		private Button btn_No;
	}
}