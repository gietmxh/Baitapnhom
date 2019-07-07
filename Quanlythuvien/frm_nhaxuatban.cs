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
        LOPDUNGCHUNG a = new LOPDUNGCHUNG();
        public frm_nhaxuatban()
        {
            InitializeComponent();
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaNXB = txtMaNXB.Text.ToString();
            string TenNXB = txtTenNXB.Text.ToString();
           
            string sql = "INSERT INTO NHAXUATBAN VALUES('" + MaNXB + "','"+ TenNXB + "');";
            int ketqua = a.ThemSuaXoa(sql);

            if (ketqua == 1)
            {
                MessageBox.Show("thêm thành công");

                DataTable dt = a.LayDuLieuBang("SELECT * FROM NHAXUATBAN");

                dataGridView1.DataSource = dt;


            }
            else
            {
                MessageBox.Show("lỗi");
            }

        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            string MaNXB = txtMaNXB.Text.ToString();
            string TenNXB = txtTenNXB.Text.ToString();

            string sql = "UPDATE NHAXUATBAN SET MANXB='"+ MaNXB + "',TENNXB ='"+ TenNXB + "' WHERE MANXB='" + MaNXB + "'";
            int ketqua = a.ThemSuaXoa(sql);

            if (ketqua == 1)
            {
                MessageBox.Show("Sửa thành công");

                DataTable dt = a.LayDuLieuBang("SELECT * FROM NHAXUATBAN");

                dataGridView1.DataSource = dt;


            }
            else
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (ok == DialogResult.Yes)
            {

                string MaNXB = txtMaNXB.Text.ToString();

                string sql = "DELETE FROM NHAXUATBAN WHERE MANXB = '" + MaNXB + "'";

                int ketqua = a.ThemSuaXoa(sql);

                if (ketqua == 1)
                {
                    MessageBox.Show("Xóa Thành công");

                    DataTable dt = a.LayDuLieuBang("SELECT * FROM NHAXUATBAN");

                    dataGridView1.DataSource = dt;


                }
                else
                {
                    MessageBox.Show("lỗi");
                }

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

        private void frm_nhaxuatban_Load(object sender, EventArgs e)
        {
            DataTable dt = a.LayDuLieuBang("SELECT * FROM NHAXUATBAN");

            dataGridView1.DataSource = dt;
        }
    }
}
