using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaiLieu
{
    public partial class loaitailieu : DevExpress.XtraEditors.XtraForm
    {
        public loaitailieu()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            string query = "select * from LOAITAILIEU ";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            ds = cn.Laydulieu(query, "QUANLYTAILIEU1");
            dataGridView1.DataSource = ds.Tables["QUANLYTAILIEU1"];
        }

        private void loaitailieu_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ma = txtma.Text;
            string ten = txtten.Text;
            string gc = txtgc.Text;
            string sql = "insert into LOAITAILIEU (MALOAI, LOAITAILIEU,GHICHU) VALUES ('" + ma + "',N'" + ten + "',N'" + gc +"')";
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true)
            {
                MessageBox.Show("Thêm thông tin thành công !");
                GetData();
            }
            else
            {
                MessageBox.Show("Thêm thông tin thất bại !");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = e.RowIndex;
            if (row >= 0)
            {

                txtma.Text = dataGridView1.Rows[row].Cells["MALOAI"].Value.ToString();
                txtten.Text = dataGridView1.Rows[row].Cells["LOAITAILIEU"].Value.ToString();
                txtgc.Text = dataGridView1.Rows[row].Cells["GHICHU"].Value.ToString();
            

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string ten = txtten.Text;
            string gc = txtgc.Text;
            string sql = "update LOAITAILIEU set MALOAI = '"+ma+"',LOAITAILIEU=N'"+ten+"',GHICHU=N'"+gc+"' where MALOAI = '"+ma+"'";
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true)
            {
                MessageBox.Show("Cập nhật thành công !");
                GetData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string sql = "delete  from LOAITAILIEU where MALOAI = '" + ma + "'";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true)
            {
                MessageBox.Show("Xóa thành công!");
                GetData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tkiem = txttkltl.Text;
            string query = "select * from LOAITAILIEU where LOAITAILIEU like N'%" + tkiem + "%'";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            ds = cn.Laydulieu(query, "QUANLYTAILIEU1");
            dataGridView1.DataSource = ds.Tables["QUANLYTAILIEU1"];
        }

        private void txttkltl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}