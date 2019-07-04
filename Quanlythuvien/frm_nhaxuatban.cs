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
    public partial class frm_nhaxuatban : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_nhaxuatban()
        {
            InitializeComponent();
        }
        public void LoadData(string sql)
        {
            DataTable dt = lopchung.LayDuLieuBang(sql);
            dataGridView1.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            string sql = "INSERT INTO NHAXUATBAN VALUE('" + txtMaNXB + "')";
            if (lopchung.ThemSuaXoa(sql) == 1)
            {
                MessageBox.Show("Them thanh cong");
                LoadData("SELeCT *FROM NHAXUATBAN");
            }
            else
            {
                MessageBox.Show("That bai");

            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            string sql = "UPDATA SINH VIEN set MaNXB='" + txtMaNXB.Text.ToString() + "',TenNXB='" + txtTenNXB.Text.ToString() + "'";
            if (lopchung.ThemSuaXoa(sql) == 1)
            {
                MessageBox.Show("Thanh cong");
                LoadData("SELECT *FROM NHAXUATBAN");
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM SINH VIEN where MaNXB='" + txtMaNXB.Text.ToString() + "'";
            if (lopchung.ThemSuaXoa(sql) == 1)
            {
                MessageBox.Show("Thanh cong");
                LoadData("SELECT *FROM NHAXUATBAN");

                txtMaNXB.Text = "";
                txtTenNXB.Text = "";
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNXB.Text = dataGridView1.CurrentRow.Cells["MaNXB"].Value.ToString();
            txtTenNXB.Text = dataGridView1.CurrentRow.Cells["TenNXB"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
