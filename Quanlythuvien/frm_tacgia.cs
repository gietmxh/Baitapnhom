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
    public partial class frm_tacgia : MetroFramework.Forms.MetroForm
    {

        LOPDUNGCHUNG a = new LOPDUNGCHUNG();
        public frm_tacgia()
        {
            InitializeComponent();


        }

        private void docgia_them_Click(object sender, EventArgs e)
        {
            string madocgia = textBox1.Text.ToString();
            string ten = textBox2.Text.ToString();
            string website = textBox3.Text.ToString();
            string ghichu = textBox4.Text.ToString();

            string sql = "INSERT INTO TACGIA VALUES('" + madocgia + "','" + ten + "','" + website + "','" + ghichu + "')";

            int ketqua = a.ThemSuaXoa(sql);

            if (ketqua == 1)
            {
                MessageBox.Show("thêm thành công");

                DataTable dt = a.LayDuLieuBang("SELECT * FROM TACGIA");

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

        private void button2_Click(object sender, EventArgs e)
        {
            string madocgia = textBox1.Text.ToString();
            string ten = textBox2.Text.ToString();
            string msv = textBox3.Text.ToString();
            string diachi = textBox4.Text.ToString();

            string sql = "UPDATE TACGIA set TENTACGIA = '" + ten + "',GHICHU = '" + diachi + "',WEBSITE = '" + msv + "' WHERE MATACGIA = '" + madocgia + "'";

            int ketqua = a.ThemSuaXoa(sql);

            if (ketqua == 1)
            {
                MessageBox.Show("sửa thành công");

                DataTable dt = a.LayDuLieuBang("SELECT * FROM TACGIA");

                dataGridView1.DataSource = dt;


            }
            else
            {
                MessageBox.Show("lỗi");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (ok == DialogResult.Yes)
            {

                string madocgia = textBox1.Text.ToString();

                string sql = "DELETE FROM TACGIA WHERE MATACGIA = '" + madocgia + "'";

                int ketqua = a.ThemSuaXoa(sql);

                if (ketqua == 1)
                {
                    MessageBox.Show("Xóa Thành công");

                    DataTable dt = a.LayDuLieuBang("SELECT * FROM TACGIA");

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
            textBox1.Text = dataGridView1.CurrentRow.Cells["MATACGIA"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["TENTACGIA"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["WEBSITE"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["GHICHU"].Value.ToString();
        }

        private void frm_tacgia_Load(object sender, EventArgs e)
        {
            DataTable dt = a.LayDuLieuBang("SELECT * FROM TACGIA");

            dataGridView1.DataSource = dt;
        }
    }
}
