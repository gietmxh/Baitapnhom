using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanlythuvien
{


    class LOPDUNGCHUNG
    {

        string connect_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "/Database2.mdf;Integrated Security=True";

        SqlConnection conn;


        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(connect_string);

        }

        public void Mo()
        {
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public void Dong()
        {
            if(conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public int ThemSuaXoa(string sql)
        {
            SqlCommand query = new SqlCommand(sql, conn);
            Mo();

            try
            {
                int ketqua = query.ExecuteNonQuery();
                Dong();
                return ketqua;
            }
            catch
            {
                return -1;
            }
        }

        public DataTable LayDuLieuBang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
