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


            }


        }
    }
}
