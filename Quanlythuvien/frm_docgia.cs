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
    public partial class frm_docgia : Form
    {
        LOPDUNGCHUNG a = new LOPDUNGCHUNG();


        public frm_docgia()
        {
            InitializeComponent();
            
        }

        private void frm_docgia_Load(object sender, EventArgs e)
        {

            DataTable dt = a.LayDuLieuBang("SELECT * FROM DOCGIA");

            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void docgia_them_Click(object sender, EventArgs e)
        {
            string madocgia = textBox1.Text.ToString();
            string ten = textBox2.Text.ToString();
            string msv = textBox3.Text.ToString();
            string diachi = textBox4.Text.ToString();

            string sql = "INSERT INTO DOCGIA VALUES('" + ten + "','" + diachi + "','" + madocgia + "','" + msv + "')";

            int ketqua = a.ThemSuaXoa(sql);

            if(ketqua == 1)
            {
                MessageBox.Show("thêm thành công");

                DataTable dt = a.LayDuLieuBang("SELECT * FROM DOCGIA");

                dataGridView1.DataSource = dt;


            } else
            {
                MessageBox.Show("lỗi");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string madocgia = textBox1.Text.ToString();
            string ten = textBox2.Text.ToString();
            string msv = textBox3.Text.ToString();
            string diachi = textBox4.Text.ToString();

            string sql = "UPDATE DOCGIA set HOTEN = '" + ten + "',DIACHI = '" + diachi + "',MASV = '" + msv + "' WHERE MADOCGIA = '"+madocgia+"'";

            int ketqua = a.ThemSuaXoa(sql);

            if (ketqua == 1)
            {
                MessageBox.Show("sửa thành công");

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["MADOCGIA"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["HOTEN"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["MASV"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["DIACHI"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(ok == DialogResult.Yes)
            {

                string madocgia = textBox1.Text.ToString();

                string sql = "DELETE FROM DOCGIA WHERE MADOCGIA = '" + madocgia + "'";

                int ketqua = a.ThemSuaXoa(sql);

                if (ketqua == 1)
                {
                    MessageBox.Show("Xóa Thành công");

                    DataTable dt = a.LayDuLieuBang("SELECT * FROM DOCGIA");

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
