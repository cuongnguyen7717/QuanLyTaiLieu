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
    public partial class nhanvien : DevExpress.XtraEditors.XtraForm
    {
        public nhanvien()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void Getdata()
        {
            string query = "select * from NHANVIEN";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            ds = cn.Laydulieu(query, "NHANVIEN");
            dgvnhanvien.DataSource = ds.Tables["NHANVIEN"];
        }
        private void nhanvien_Load(object sender, EventArgs e)
        {
            Getdata();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string sql = "delete  from NHANVIEN where MANHANVIEN= '" + ma + "'";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true && ma!="")
            {
                MessageBox.Show("Xóa nhân viên thành công!");
                Getdata();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ma = txtma.Text;
            string ten = txtten.Text;
            string sdt = txtsdt.Text;
            string chucvu = txtcv.Text;
            string pb = txtpb.Text;
            string dc = txtdc.Text;
            string sql = "insert into NHANVIEN (MANHANVIEN, TENNHANVIEN, SODIENTHOAI, CHUCVU, PHONGBAN,DIACHI) VALUES ('" + ma + "',N'" + ten + "',N'" + sdt+ "',N'" + chucvu + "',N'" + pb + "',N'" + dc + "')";
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true && ma != "")
            {
                MessageBox.Show("Thêm nhân viên thành công !");
                Getdata();
            }
            else
            {
                MessageBox.Show("Thêm thông tin thất bại !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string ten = txtten.Text;
            string sdt = txtsdt.Text;
            string chucvu = txtcv.Text;
            string pb = txtpb.Text;
            string dc = txtdc.Text;
            string sql = "update NHANVIEN set MANHANVIEN = '" + ma + "',TENNHANVIEN=N'" + ten + "',SODIENTHOAI=N'" + sdt + "',CHUCVU=N'" + chucvu + "',PHONGBAN=N'" + pb + "',DIACHI=N'" + dc + "' where MANHANVIEN = '" + ma + "'";
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true && ma != "")
            {
                MessageBox.Show("Cập nhật thành công !");
                Getdata();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại !");
            }
        }

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {

                txtma.Text = dgvnhanvien.Rows[row].Cells["MANHANVIEN"].Value.ToString();
                txtten.Text = dgvnhanvien.Rows[row].Cells["TENNHANVIEN"].Value.ToString();
                txtsdt.Text = dgvnhanvien.Rows[row].Cells["SODIENTHOAI"].Value.ToString();
                txtcv.SelectedItem = dgvnhanvien.Rows[row].Cells["CHUCVU"].Value.ToString();
                txtpb.SelectedItem = dgvnhanvien.Rows[row].Cells["PHONGBAN"].Value.ToString();
                txtdc.Text = dgvnhanvien.Rows[row].Cells["DIACHI"].Value.ToString();
            }   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tkiem = txttk.Text;
            string query = "select * from NHANVIEN where TENNHANVIEN like N'%" + tkiem + "%'";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            ds = cn.Laydulieu(query, "QUANLYTAILIEU1");
            dgvnhanvien.DataSource = ds.Tables["QUANLYTAILIEU1"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Getdata();
            txtma.Text="";
             txtten.Text="";
               txtsdt.Text="";
             txtcv.ResetText();
            txtpb.ResetText();
            txtdc.Text="";
        }
    }
}