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
    public partial class thongke : DevExpress.XtraEditors.XtraForm
    {
        public thongke()
        {
            InitializeComponent();
        }
        public void GetManhanvien()
        {

            string query = "select * from NHANVIEN";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            ds = cn.Laydulieu(query, "NHANVIEN");
            txtmanv.DataSource = ds.Tables["NHANVIEN"];
            txtmanv.DisplayMember = "MANHANVIEN";
            txtmanv.ValueMember = "TENNHANVIEN";
            txttennv.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string tkiem = txttk.Text;
            string query = "select * from THONGKE where TENBAOCAO like N'%" + tkiem + "%'";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            ds = cn.Laydulieu(query, "QUANLYTAILIEU1");
            bool kq = cn.ThucThi(query);
            dgvbaocao.DataSource = ds.Tables["QUANLYTAILIEU1"];
            if (kq == false)
           
            {
                MessageBox.Show("Không tìm thấy thông tin !");
            }
        }
        public void Getdata()
        {
            string query = "select * from THONGKE ";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            ds = cn.Laydulieu(query, "THONGKE");
            dgvbaocao.DataSource = ds.Tables["THONGKE"];
       
        }

        private void thongke_Load(object sender, EventArgs e)
        {
            Getdata();
            GetManhanvien();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void butadd_Click(object sender, EventArgs e)
        {
            DateTime date = datengay.Value;
            string mabc = txtma.Text;
            string ten = txttenbcao.Text;
            string sl = txtsl.Text;
            string tennv = txttennv.Text;
            string manv = txtmanv.Text;
            string lt = txtlt.Text;
            string sql = "insert into THONGKE (MABAOCAO, TENBAOCAO,TAILIEUHIENCO, LUOTTAI, MANHANVIEN,TENNHANVIEN,NGAYTAO) VALUES ('" + mabc + "',N'" + ten + "','" + sl + "','" + lt+ "',N'" + manv + "',N'" + tennv + "','"+ date +"')";
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true)
            {
                MessageBox.Show("Thêm báo cáo thành công !");
                Getdata();
            }
            else
            {
                MessageBox.Show("Thêm báo cáo thất bại !");
            }
        }

        private void txtmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttennv.Text = txtmanv.SelectedValue.ToString();
        }

        private void dgvbaocao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvbaocao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {

                txtma.Text = dgvbaocao.Rows[row].Cells["MABAOCAO"].Value.ToString();
                txttenbcao.Text = dgvbaocao.Rows[row].Cells["TENBAOCAO"].Value.ToString();
                txtsl.Text = dgvbaocao.Rows[row].Cells["TAILIEUHIENCO"].Value.ToString();
                txtmanv.SelectedItem = dgvbaocao.Rows[row].Cells["MANHANVIEN"].Value.ToString();
                txttennv.Text = dgvbaocao.Rows[row].Cells["TENNHANVIEN"].Value.ToString();
                txtlt.Text = dgvbaocao.Rows[row].Cells["LUOTTAI"].Value.ToString();
                datengay.Text = dgvbaocao.Rows[row].Cells["NGAYTAO"].Value.ToString();
            }
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string sql = "delete  from THONGKE where MABAOCAO = '" + ma + "'";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true)
            {
                MessageBox.Show("Xóa báo cáo thành công!");
                Getdata();
            }
            else
            {
                MessageBox.Show("Xóa báo cáo thất bại!");
            }
        }

        private void butedit_Click(object sender, EventArgs e)
        {
            DateTime date = datengay.Value;
            string mabc = txtma.Text;
            string ten = txttenbcao.Text;
            string sl = txtsl.Text;
            string tennv = txttennv.Text;
            string manv = txtmanv.Text;
            string lt = txtlt.Text;
            string sql = "update THONGKE set MABAOCAO = '" + mabc + "',TENBAOCAO=N'" + ten + "',TAILIEUHIENCO=N'" + sl + "',LUOTTAI=N'" + lt + "',MANHANVIEN=N'" + manv + "',TENNHANVIEN=N'" + tennv + "',NGAYTAO=N'" + date + "' where MABAOCAO = '" + mabc + "'";
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true)
            {
                MessageBox.Show("Cập nhật thành công !");
                Getdata();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại !");
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Getdata();

            txtma.Text = "";
            txttenbcao.Text = "";
            txtsl.Text = "";
            txtmanv.SelectedItem = "";
            txttennv.Text = "";
            txtlt.Text = "";
            datengay.Text = "";
        }
    }
}