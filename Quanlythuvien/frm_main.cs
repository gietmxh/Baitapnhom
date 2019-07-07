using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quarnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void heToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýĐọcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_docgia a = new frm_docgia();
            a.Show();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void quảnLýNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nhaxuatban a = new frm_nhaxuatban();
            a.Show();
        }

        private void quảnLýSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_QuanliSach a = new frm_QuanliSach();
            a.Show();
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tacgia a = new frm_tacgia();
            a.Show();
        }
    }
}
