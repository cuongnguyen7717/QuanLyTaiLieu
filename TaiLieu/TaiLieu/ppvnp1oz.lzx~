using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaiLieu
{
    public class myClass
    {
        static SqlConnection conn = new SqlConnection();
        //Hàm tạo kết nối
        public static void taoKetNoi()
        {
            try
            {
                conn.ConnectionString = "Data Source=DESKTOP-1FHDCFR;Initial Catalog=QUANLYTAILIEU1;Integrated Security=True";
            }
            catch
            {

            }
            try
            {
                conn.Open();
            }
            catch 
            {
                
            }
        }
        public static void dongKetNoi()
        {
            conn.Close();
        }
        public static DataTable getData(string query)
        {
            taoKetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(tb);
            dongKetNoi();
            return tb;
        }
        public static DataSet getDataSet(string query)
        {
            taoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static void execQuery(string qr)
        {
            try
            {
                taoKetNoi();
                SqlCommand cmd = new SqlCommand(qr, conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                dongKetNoi();
            }
            catch
            {
              
            }
        }
        public static DateTime GetFirstDayInMont(int year, int month)
        {
            return new DateTime(year, month, 1);
        }
    }
}
