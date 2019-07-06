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
    public partial class frm_QuanliSach : MetroFramework.Forms.MetroForm
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

            string sql = "INSERT INTO SACH VALUES('" + Masach + "','" + Tensach + "','" + Matacgia + "','" + Matheloai + "','" + Manhaxuatban + "','" + Namxuatban + "')";


            int ketqua = a.ThemSuaXoa(sql);

            if (ketqua == 1)
            {
                MessageBox.Show("thêm thành công");

                DataTable dt = a.LayDuLieuBang("SELECT * FROM SACH");

                dataGridView1.DataSource = dt;


            }
            else
            {
                MessageBox.Show("lỗi");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasach.Text = dataGridView1.CurrentRow.Cells["Masach"].Value.ToString();
            txtTensach.Text = dataGridView1.CurrentRow.Cells["Tensach"].Value.ToString();
            txtMatacgia.Text = dataGridView1.CurrentRow.Cells["Matacgia"].Value.ToString();
            txtMatheloai.Text = dataGridView1.CurrentRow.Cells["Matheloai"].Value.ToString();
            txtManhaxuatban.Text = dataGridView1.CurrentRow.Cells["Manhaxuatban"].Value.ToString();
            txtNamxuatban.Text = dataGridView1.CurrentRow.Cells["Namxuatban"].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Masach = txtMasach.Text.ToString();
            string Tensach = txtTensach.Text.ToString();
            string Matheloai = txtMatheloai.Text.ToString();
            string Matacgia = txtMatacgia.Text.ToString();
            string Manhaxuatban = txtManhaxuatban.Text.ToString();
            string Namxuatban = txtNamxuatban.Text.ToString();

            string sql = "UPDATA SACH SET MASACH='" + Masach + "',TENSACH ='" + Tensach + "',MATHELOAI='" + Matheloai + "',MATACGIA='" + Matacgia + "',MANXB='" + Manhaxuatban + "',NAMXB='" + Namxuatban + "' WHERE MASACH = '"+ Masach + "' ";
            int ketqua = a.ThemSuaXoa(sql);

            if (ketqua == 1)
            {
                MessageBox.Show("Sửa thành công");

                DataTable dt = a.LayDuLieuBang("SELECT * FROM SACH");

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

                string sql = "DELETE FROM SACH WHERE MASACH = '" + MaSach + "'";

                int ketqua = a.ThemSuaXoa(sql);

                if (ketqua == 1)
                {
                    MessageBox.Show("Xóa Thành công");

                    DataTable dt = a.LayDuLieuBang("SELECT * FROM SACH");

                    dataGridView1.DataSource = dt;


                }
                else
                {
                    MessageBox.Show("lỗi");
                }

            }
        }

        private void frm_QuanliSach_Load(object sender, EventArgs e)
        {
            DataTable dt = a.LayDuLieuBang("SELECT * FROM SACH");

            dataGridView1.DataSource = dt;
        }
    }
}
