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
    public partial class frm_QuanliSach : Form
    {
        LOPDUNGCHUNG a = new LOPDUNGCHUNG();
        public frm_QuanliSach()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Masach = txtMasach.Text.ToString();
            string Tensach = txtTensach.Text.ToString();
            string Matheloai = txtMatheloai.Text.ToString();
            string Matacgia = txtMatacgia.Text.ToString();
            string Manhaxuatban = txtManhaxuatban.Text.ToString();
            string Namxuatban = txtNamxuatban.Text.ToString();

            string sql = "INSERT INTO QUANLISACH VALUE('" + txtMasach + "','" + txtTensach + "','" + txtMatacgia + "','" + txtTensach + "','" + txtMatheloai + "','" + txtManhaxuatban + "','" + txtNamxuatban + "')";

            int ketqua = a.ThemSuaXoa(sql);

            if (ketqua == 1)
            {
                MessageBox.Show("thêm thành công");

                DataTable dt = a.LayDuLieuBang("SELECT * FROM DOCGIA");

                dataGridView1.DataSource = dt;


            }
            else
            {
                MessageBox.Show("lỗi");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Masach = txtMasach.Text.ToString();
            string Tensach = txtTensach.Text.ToString();
            string Matheloai = txtMatheloai.Text.ToString();
            string Matacgia = txtMatacgia.Text.ToString();
            string Manhaxuatban = txtManhaxuatban.Text.ToString();
            string Namxuatban = txtNamxuatban.Text.ToString();

            string sql = "UPDATA QuanliSach SET MASach='" + Masach + "',Tensach ='" + Tensach + "',Matheloai='" + Matheloai + "',Matacgia='" + Matacgia + "',Manhaxuatban='" + Manhaxuatban + "',Namxuatban='" + Namxuatban + "'";
            int ketqua = a.ThemSuaXoa(sql);

            if (ketqua == 1)
            {
                MessageBox.Show("Sửa thành công");

                DataTable dt = a.LayDuLieuBang("SELECT * FROM QuanliSach");

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

                string MaSach = txtMasach.Text.ToString();

                string sql = "DELETE FROM DOCGIA WHERE MANXB = '" + MaSach + "'";

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
    }
}
