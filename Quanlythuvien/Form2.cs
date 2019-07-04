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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection();


        }




        string connect_string = @"C:\USERS\ADMINISTRATOR\SOURCE\REPOS\BAITAPNHOM\QUANLYTHUVIEN\DATABASE2.MDF";

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
                {
                    Form  form = new Form ();
                    form.Show();
                    Application.Run(new Form ());
                }
                else
                {
                    i = i + 1;
                    MessageBox.Show("dang nhap sai");
                }
            }
            while (i < 2);

        }
    }


}
