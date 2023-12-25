
namespace QuanLiDoanVienTruongDHDN
{
    partial class FormXepLoai
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
            this.MaXL = new System.Windows.Forms.Label();
            this.TenXL = new System.Windows.Forms.Label();
            this.ChiDoan = new System.Windows.Forms.Label();
            this.textMaxl = new System.Windows.Forms.TextBox();
            this.textTenxl = new System.Windows.Forms.TextBox();
            this.textChidoan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MaXL
            // 
            this.MaXL.AutoSize = true;
            this.MaXL.Location = new System.Drawing.Point(12, 93);
            this.MaXL.Name = "MaXL";
            this.MaXL.Size = new System.Drawing.Size(67, 13);
            this.MaXL.TabIndex = 0;
            this.MaXL.Text = "Mã Xếp Loại";
            this.MaXL.Click += new System.EventHandler(this.MaXL_Click);
            // 
            // TenXL
            // 
            this.TenXL.AutoSize = true;
            this.TenXL.Location = new System.Drawing.Point(12, 186);
            this.TenXL.Name = "TenXL";
            this.TenXL.Size = new System.Drawing.Size(71, 13);
            this.TenXL.TabIndex = 1;
            this.TenXL.Text = "Tên Xếp Loại";
            // 
            // ChiDoan
            // 
            this.ChiDoan.AutoSize = true;
            this.ChiDoan.Location = new System.Drawing.Point(12, 279);
            this.ChiDoan.Name = "ChiDoan";
            this.ChiDoan.Size = new System.Drawing.Size(51, 13);
            this.ChiDoan.TabIndex = 3;
            this.ChiDoan.Text = "Chi Đoàn";
            // 
            // textMaxl
            // 
            this.textMaxl.Location = new System.Drawing.Point(98, 86);
            this.textMaxl.Name = "textMaxl";
            this.textMaxl.Size = new System.Drawing.Size(100, 20);
            this.textMaxl.TabIndex = 4;
            this.textMaxl.TextChanged += new System.EventHandler(this.textMaxl_TextChanged);
            // 
            // textTenxl
            // 
            this.textTenxl.Location = new System.Drawing.Point(98, 183);
            this.textTenxl.Name = "textTenxl";
            this.textTenxl.Size = new System.Drawing.Size(100, 20);
            this.textTenxl.TabIndex = 5;
            // 
            // textChidoan
            // 
            this.textChidoan.Location = new System.Drawing.Point(98, 279);
            this.textChidoan.Name = "textChidoan";
            this.textChidoan.Size = new System.Drawing.Size(100, 20);
            this.textChidoan.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(116, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Xếp Loại Đoàn Viên";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormXepLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 393);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textChidoan);
            this.Controls.Add(this.textTenxl);
            this.Controls.Add(this.textMaxl);
            this.Controls.Add(this.ChiDoan);
            this.Controls.Add(this.TenXL);
            this.Controls.Add(this.MaXL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormXepLoai";
            this.Text = "FormXepLoai";
            this.Load += new System.EventHandler(this.FormXepLoai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaXL;
        private System.Windows.Forms.Label TenXL;
        private System.Windows.Forms.Label ChiDoan;
        private System.Windows.Forms.TextBox textMaxl;
        private System.Windows.Forms.TextBox textTenxl;
        private System.Windows.Forms.TextBox textChidoan;
        private System.Windows.Forms.Label label5;
    }
}