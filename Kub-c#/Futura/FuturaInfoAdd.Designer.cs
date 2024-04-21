namespace Kub_c_.Futura
{
	partial class FuturaInfoAdd
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
			productComboBox1 = new ComboBox();
			label1 = new Label();
			quantityTextBox = new TextBox();
			label2 = new Label();
			priceTextBox = new TextBox();
			label3 = new Label();
			buttonSave = new Button();
			buttonCancel = new Button();
			SuspendLayout();
			// 
			// productComboBox1
			// 
			productComboBox1.FormattingEnabled = true;
			productComboBox1.Location = new Point(120, 22);
			productComboBox1.Name = "productComboBox1";
			productComboBox1.Size = new Size(121, 23);
			productComboBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(21, 20);
			label1.Name = "label1";
			label1.Size = new Size(71, 21);
			label1.TabIndex = 1;
			label1.Text = "Продукт";
			// 
			// quantityTextBox
			// 
			quantityTextBox.Location = new Point(120, 64);
			quantityTextBox.Name = "quantityTextBox";
			quantityTextBox.Size = new Size(121, 23);
			quantityTextBox.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(21, 66);
			label2.Name = "label2";
			label2.Size = new Size(93, 21);
			label2.TabIndex = 3;
			label2.Text = "Количество";
			// 
			// priceTextBox
			// 
			priceTextBox.Location = new Point(120, 104);
			priceTextBox.Name = "priceTextBox";
			priceTextBox.Size = new Size(121, 23);
			priceTextBox.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(21, 104);
			label3.Name = "label3";
			label3.Size = new Size(47, 21);
			label3.TabIndex = 5;
			label3.Text = "Цена";
			// 
			// buttonSave
			// 
			buttonSave.Font = new Font("Segoe UI", 12F);
			buttonSave.Location = new Point(18, 157);
			buttonSave.Name = "buttonSave";
			buttonSave.Size = new Size(96, 33);
			buttonSave.TabIndex = 6;
			buttonSave.Text = "Сохранить";
			buttonSave.UseVisualStyleBackColor = true;
			buttonSave.Click += buttonSave_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.Font = new Font("Segoe UI", 12F);
			buttonCancel.Location = new Point(145, 157);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(96, 33);
			buttonCancel.TabIndex = 7;
			buttonCancel.TabStop = false;
			buttonCancel.Text = "Отмена";
			buttonCancel.UseVisualStyleBackColor = true;
			buttonCancel.Click += buttonCancel_Click;
			// 
			// FuturaInfoAdd
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(266, 212);
			Controls.Add(buttonCancel);
			Controls.Add(buttonSave);
			Controls.Add(label3);
			Controls.Add(priceTextBox);
			Controls.Add(label2);
			Controls.Add(quantityTextBox);
			Controls.Add(label1);
			Controls.Add(productComboBox1);
			Name = "FuturaInfoAdd";
			Text = "FuturaInfoAdd";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox productComboBox1;
		private Label label1;
		private TextBox quantityTextBox;
		private Label label2;
		private TextBox priceTextBox;
		private Label label3;
		private Button buttonSave;
		private Button buttonCancel;
	}
}