namespace Quanlythuvien
{
    partial class frm_QuanliSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txtMatacgia = new System.Windows.Forms.TextBox();
            this.txtMatheloai = new System.Windows.Forms.TextBox();
            this.txtManhaxuatban = new System.Windows.Forms.TextBox();
            this.txtNamxuatban = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ SÁCH ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(88, 245);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(151, 51);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(204, 22);
            this.txtMasach.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(588, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã sách ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên sách ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã tác giả ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã thể loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã nhà xuất bản ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Năm xuất bản ";
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(490, 51);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(207, 22);
            this.txtTensach.TabIndex = 10;
            // 
            // txtMatacgia
            // 
            this.txtMatacgia.Location = new System.Drawing.Point(151, 105);
            this.txtMatacgia.Name = "txtMatacgia";
            this.txtMatacgia.Size = new System.Drawing.Size(204, 22);
            this.txtMatacgia.TabIndex = 11;
            // 
            // txtMatheloai
            // 
            this.txtMatheloai.Location = new System.Drawing.Point(490, 105);
            this.txtMatheloai.Name = "txtMatheloai";
            this.txtMatheloai.Size = new System.Drawing.Size(207, 22);
            this.txtMatheloai.TabIndex = 12;
            // 
            // txtManhaxuatban
            // 
            this.txtManhaxuatban.Location = new System.Drawing.Point(151, 170);
            this.txtManhaxuatban.Name = "txtManhaxuatban";
            this.txtManhaxuatban.Size = new System.Drawing.Size(204, 22);
            this.txtManhaxuatban.TabIndex = 13;
            // 
            // txtNamxuatban
            // 
            this.txtNamxuatban.Location = new System.Drawing.Point(490, 170);
            this.txtNamxuatban.Name = "txtNamxuatban";
            this.txtNamxuatban.Size = new System.Drawing.Size(207, 22);
            this.txtNamxuatban.TabIndex = 14;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(325, 245);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(566, 245);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frm_QuanliSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 441);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtNamxuatban);
            this.Controls.Add(this.txtManhaxuatban);
            this.Controls.Add(this.txtMatheloai);
            this.Controls.Add(this.txtMatacgia);
            this.Controls.Add(this.txtTensach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMasach);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Name = "frm_QuanliSach";
            this.Text = "frm_QuanliSach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.TextBox txtMatacgia;
        private System.Windows.Forms.TextBox txtMatheloai;
        private System.Windows.Forms.TextBox txtManhaxuatban;
        private System.Windows.Forms.TextBox txtNamxuatban;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}