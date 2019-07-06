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
    public partial class frm_theloai : MetroFramework.Forms.MetroForm
    {
        LOPDUNGCHUNG a = new LOPDUNGCHUNG();
        public frm_theloai()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaNXB = txtMaNXB.Text.ToString();
            string TenNXB = txtTenNXB.Text.ToString();
           
            string sql = "INSERT INTO THELOAI VALUES('" + MaNXB + "','"+ TenNXB + "');";
            int ketqua = a.ThemSuaXoa(sql);

            if (ketqua == 1)
            {
                MessageBox.Show("thêm thành công");

                DataTable dt = a.LayDuLieuBang("SELECT * FROM THELOAI");

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

            string sql = "UPDATE THELOAI SET MATHELOAI='" + MaNXB + "',TENTHELOAI ='" + TenNXB + "' WHERE MATHELOAI='" + MaNXB + "'";
            int ketqua = a.ThemSuaXoa(sql);

            if (ketqua == 1)
            {
                MessageBox.Show("Sửa thành công");

                DataTable dt = a.LayDuLieuBang("SELECT * FROM THELOAI");

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

                string sql = "DELETE FROM THELOAI WHERE MATHELOAI = '" + MaNXB + "'";

                int ketqua = a.ThemSuaXoa(sql);

                if (ketqua == 1)
                {
                    MessageBox.Show("Xóa Thành công");

                    DataTable dt = a.LayDuLieuBang("SELECT * FROM THELOAI");

                    dataGridView1.DataSource = dt;


                }
                else
                {
                    MessageBox.Show("lỗi");
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_theloai_Load(object sender, EventArgs e)
        {
            DataTable dt = a.LayDuLieuBang("SELECT * FROM THELOAI");

            dataGridView1.DataSource = dt;
        }
    }
}
