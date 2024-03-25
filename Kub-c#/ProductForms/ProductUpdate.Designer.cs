namespace Kub_c_.ProductForms
{
    partial class ProductUpdate
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
            lbl_Name = new Label();
            lbl_Ed = new Label();
            btn_No_click = new Button();
            btn_Yes_click = new Button();
            tb_Name = new TextBox();
            tb_Ed = new TextBox();
            SuspendLayout();
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI", 12F);
            lbl_Name.Location = new Point(36, 40);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(81, 21);
            lbl_Name.TabIndex = 0;
            lbl_Name.Text = "Название:";
            // 
            // lbl_Ed
            // 
            lbl_Ed.AutoSize = true;
            lbl_Ed.Font = new Font("Segoe UI", 12F);
            lbl_Ed.Location = new Point(36, 85);
            lbl_Ed.Name = "lbl_Ed";
            lbl_Ed.Size = new Size(115, 21);
            lbl_Ed.TabIndex = 1;
            lbl_Ed.Text = "Ед. измерения:";
            // 
            // btn_No_click
            // 
            btn_No_click.Font = new Font("Segoe UI", 12F);
            btn_No_click.Location = new Point(213, 149);
            btn_No_click.Name = "btn_No_click";
            btn_No_click.Size = new Size(75, 34);
            btn_No_click.TabIndex = 2;
            btn_No_click.Text = "Нет";
            btn_No_click.UseVisualStyleBackColor = true;
            btn_No_click.Click += btn_No_сlick;
            // 
            // btn_Yes_click
            // 
            btn_Yes_click.Font = new Font("Segoe UI", 12F);
            btn_Yes_click.Location = new Point(106, 149);
            btn_Yes_click.Name = "btn_Yes_click";
            btn_Yes_click.Size = new Size(80, 34);
            btn_Yes_click.TabIndex = 3;
            btn_Yes_click.Text = "Да";
            btn_Yes_click.UseVisualStyleBackColor = true;
            btn_Yes_click.Click += btn_Yes_сlick;
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 12F);
            tb_Name.Location = new Point(169, 37);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(100, 29);
            tb_Name.TabIndex = 4;
            // 
            // tb_Ed
            // 
            tb_Ed.Font = new Font("Segoe UI", 12F);
            tb_Ed.Location = new Point(169, 82);
            tb_Ed.Name = "tb_Ed";
            tb_Ed.Size = new Size(100, 29);
            tb_Ed.TabIndex = 5;
            // 
            // ProductUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 192);
            Controls.Add(tb_Ed);
            Controls.Add(tb_Name);
            Controls.Add(btn_Yes_click);
            Controls.Add(btn_No_click);
            Controls.Add(lbl_Ed);
            Controls.Add(lbl_Name);
            Name = "ProductUpdate";
            Text = "ProductUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Name;
        private Label lbl_Ed;
        private Button btn_No_click;
        private Button btn_Yes_click;
        private TextBox tb_Name;
        private TextBox tb_Ed;
    }
}