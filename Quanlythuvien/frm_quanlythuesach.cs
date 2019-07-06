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
    public partial class frm_quanlythuesach : MetroFramework.Forms.MetroForm
    {
        LOPDUNGCHUNG a = new LOPDUNGCHUNG();
        public frm_quanlythuesach()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ten = listBox1.SelectedValue.ToString();

            txtmadocgia.Text = ten;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mamuontra = txtMamuontra.Text.ToString();
            string madocgia = txtmadocgia.Text.ToString();
            string masach = textBox1.Text.ToString();

            DateTime time = DateTime.Now;              // Use current time
            string format = "yyyy-MM-dd HH:mm:ss";    // modify the format depending upon input required in the column in database 





            string sql = "INSERT INTO MUONTRA VALUES('" + mamuontra + "','" + time.ToString(format) + "','NV01','" + madocgia + "')";

            int ketqua = a.ThemSuaXoa(sql);

            if (ketqua == 1)
            {

                sql = "INSERT INTO CTMUONTRA VALUES('" + mamuontra + "','" + masach + "','','1','')";

                a.ThemSuaXoa(sql);


                MessageBox.Show("thêm thành công");

                DataTable dt = a.LayDuLieuBang("SELECT * FROM MUONTRA");

                dataGridView1.DataSource = dt;


            }
            else
            {
                MessageBox.Show("lỗi");
            }


        }

        private void frm_quanlythuesach_Load(object sender, EventArgs e)
        {
        
            DataTable dt = a.LayDuLieuBang("SELECT * FROM DOCGIA");
            listBox1.DataSource = dt;

            listBox1.DisplayMember = "HOTEN";
            listBox1.ValueMember = "MADOCGIA";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string dulieu = textBox2.Text.ToString();

            string sql = "SELECT * FROM DOCGIA WHERE HOTEN LIKE '%" + dulieu + "%'";

            DataTable dt = a.LayDuLieuBang(sql);

            listBox1.DataSource = dt;

            listBox1.DisplayMember = "HOTEN";
            listBox1.ValueMember = "MADOCGIA";

        }
    }
}
