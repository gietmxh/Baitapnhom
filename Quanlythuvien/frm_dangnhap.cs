using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace Quanlythuvien
{
    public partial class frm_dangnhap : MetroFramework.Forms.MetroForm
    {

        LOPDUNGCHUNG a = new LOPDUNGCHUNG();
        public frm_dangnhap()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '*';
            // The control will allow no more than 14 characters.  
            txtMatKhau.MaxLength = 14;


        }





        private void button2_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text.ToString();
            string mk = txtMatKhau.Text.ToString();

            if (a.dem("SELECT * FROM DANGNHAP WHERE TAIKHOAN = '" + tk + "' AND MATKHAU = '" + mk + "' ") > 0)
            {
                this.Hide();
                MessageBox.Show("Đăng Nhập Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_main a = new frm_main();
                a.Show();

   

            } else
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBox.Show("Bạn có chắc chắn tắt", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (ok == DialogResult.Yes)
            {

                Application.Exit();
            }
        }
    }


}
