namespace Kub_c_.ProductForms
{
    partial class ProductAdd
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			btn_Yes = new Button();
			btn_No = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(161, 55);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(201, 27);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(161, 120);
			textBox2.Margin = new Padding(3, 4, 3, 4);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(148, 27);
			textBox2.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(0, 55);
			label1.Name = "label1";
			label1.Size = new Size(155, 28);
			label1.TabIndex = 2;
			label1.Text = "Наименование:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(0, 116);
			label2.Name = "label2";
			label2.Size = new Size(150, 28);
			label2.TabIndex = 3;
			label2.Text = "Ед. Измерения:";
			// 
			// btn_Yes
			// 
			btn_Yes.Location = new Point(229, 189);
			btn_Yes.Margin = new Padding(3, 4, 3, 4);
			btn_Yes.Name = "btn_Yes";
			btn_Yes.Size = new Size(61, 31);
			btn_Yes.TabIndex = 4;
			btn_Yes.Text = "Да";
			btn_Yes.UseVisualStyleBackColor = true;
			btn_Yes.Click += btn_Yes_Click;
			// 
			// btn_No
			// 
			btn_No.Location = new Point(296, 189);
			btn_No.Margin = new Padding(3, 4, 3, 4);
			btn_No.Name = "btn_No";
			btn_No.Size = new Size(61, 31);
			btn_No.TabIndex = 5;
			btn_No.Text = "Нет";
			btn_No.UseVisualStyleBackColor = true;
			btn_No.Click += btn_No_Click;
			// 
			// ProductAdd
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(385, 236);
			Controls.Add(btn_No);
			Controls.Add(btn_Yes);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "ProductAdd";
			Text = "ProductAdd";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button btn_Yes;
        private Button btn_No;
    }
}