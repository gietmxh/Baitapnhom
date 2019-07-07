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
    public partial class frm_quanlythuesach : Form
    {
        public frm_quanlythuesach()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mamuontra = txtMamuontra.Text.ToString();
            string ngaythu = dateTimePicker1.Text.ToString();
            string madocgia = txtmadocgia.Text.ToString();
        }
    }
}
