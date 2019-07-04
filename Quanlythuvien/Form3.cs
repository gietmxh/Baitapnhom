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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "")
                MessageBox.Show("Chưa nhập password cũ");
            else if (txtnewpassword.Text == "")
                MessageBox.Show("Chưa nhập password mới");
            else if (txtconfirmnewpassword.Text == "")
                MessageBox.Show("Chưa nhập lại password mới");
            else if (txtnewpassword.Text != txtconfirmnewpassword.Text)
                MessageBox.Show("Password không trùng khớp");
           else
            {
              
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
