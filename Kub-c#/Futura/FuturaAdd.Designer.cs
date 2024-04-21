namespace Kub_c_.Futura
{
	partial class FuturaAdd
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
			btnYes_Click = new Button();
			btnNo_Click = new Button();
			dateTimePicker1 = new DateTimePicker();
			label2 = new Label();
			comboBoxClientName = new ComboBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// btnYes_Click
			// 
			btnYes_Click.Location = new Point(90, 124);
			btnYes_Click.Name = "btnYes_Click";
			btnYes_Click.Size = new Size(80, 32);
			btnYes_Click.TabIndex = 2;
			btnYes_Click.Text = "Да";
			btnYes_Click.UseVisualStyleBackColor = true;
			btnYes_Click.Click += btnYes_Click_Click;
			// 
			// btnNo_Click
			// 
			btnNo_Click.Location = new Point(185, 124);
			btnNo_Click.Name = "btnNo_Click";
			btnNo_Click.Size = new Size(80, 32);
			btnNo_Click.TabIndex = 3;
			btnNo_Click.Text = "Нет";
			btnNo_Click.UseVisualStyleBackColor = true;
			btnNo_Click.Click += btnNo_Click_Click;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Font = new Font("Segoe UI", 12F);
			dateTimePicker1.Location = new Point(90, 77);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(175, 29);
			dateTimePicker1.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(12, 26);
			label2.Name = "label2";
			label2.Size = new Size(60, 21);
			label2.TabIndex = 6;
			label2.Text = "Клиент";
			// 
			// comboBoxClientName
			// 
			comboBoxClientName.FormattingEnabled = true;
			comboBoxClientName.Location = new Point(90, 28);
			comboBoxClientName.Name = "comboBoxClientName";
			comboBoxClientName.Size = new Size(175, 23);
			comboBoxClientName.TabIndex = 5;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(12, 77);
			label1.Name = "label1";
			label1.Size = new Size(44, 21);
			label1.TabIndex = 7;
			label1.Text = "Дата";
			// 
			// FuturaAdd
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonFace;
			ClientSize = new Size(308, 177);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(comboBoxClientName);
			Controls.Add(dateTimePicker1);
			Controls.Add(btnNo_Click);
			Controls.Add(btnYes_Click);
			Name = "FuturaAdd";
			Text = "FuturaAdd";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnYes_Click;
		private Button btnNo_Click;
		private DateTimePicker dateTimePicker1;
		private Label label2;
		private ComboBox comboBoxClientName;
		private Label label1;
	}
}