namespace Quanlythuvien
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quarnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đọcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐọcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThuêSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quarnToolStripMenuItem,
            this.đọcGiảToolStripMenuItem,
            this.sáchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quarnToolStripMenuItem
            // 
            this.quarnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoTàiKhoảnToolStripMenuItem});
            this.quarnToolStripMenuItem.Name = "quarnToolStripMenuItem";
            this.quarnToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.quarnToolStripMenuItem.Text = "Quản Lý Hệ Thống";
            this.quarnToolStripMenuItem.Click += new System.EventHandler(this.quarnToolStripMenuItem_Click);
            // 
            // tạoTàiKhoảnToolStripMenuItem
            // 
            this.tạoTàiKhoảnToolStripMenuItem.Name = "tạoTàiKhoảnToolStripMenuItem";
            this.tạoTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tạoTàiKhoảnToolStripMenuItem.Text = "Đổi mật khẩu";
            this.tạoTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tạoTàiKhoảnToolStripMenuItem_Click);
            // 
            // đọcGiảToolStripMenuItem
            // 
            this.đọcGiảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýĐọcGiảToolStripMenuItem});
            this.đọcGiảToolStripMenuItem.Name = "đọcGiảToolStripMenuItem";
            this.đọcGiảToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.đọcGiảToolStripMenuItem.Text = "Đọc Giả";
            this.đọcGiảToolStripMenuItem.Click += new System.EventHandler(this.đọcGiảToolStripMenuItem_Click);
            // 
            // quảnLýĐọcGiảToolStripMenuItem
            // 
            this.quảnLýĐọcGiảToolStripMenuItem.Name = "quảnLýĐọcGiảToolStripMenuItem";
            this.quảnLýĐọcGiảToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.quảnLýĐọcGiảToolStripMenuItem.Text = "Quản lý đọc giả";
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSáchToolStripMenuItem,
            this.quảnLýThuêSáchToolStripMenuItem});
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.sáchToolStripMenuItem.Text = "Sách";
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản lý sách";
            // 
            // quảnLýThuêSáchToolStripMenuItem
            // 
            this.quảnLýThuêSáchToolStripMenuItem.Name = "quảnLýThuêSáchToolStripMenuItem";
            this.quảnLýThuêSáchToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.quảnLýThuêSáchToolStripMenuItem.Text = "Quản lý thuê sách";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 369);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quarnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đọcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐọcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThuêSáchToolStripMenuItem;
    }
}

