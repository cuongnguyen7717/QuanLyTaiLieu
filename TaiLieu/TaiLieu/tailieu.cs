using DevExpress.Utils.CommonDialogs;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaiLieu
{
    public partial class tailieu : DevExpress.XtraEditors.XtraForm
    {
        public tailieu()
        {
            InitializeComponent();
        }
 
    
        private void butchon_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:\\Documents";
            openFileDialog1.Title = "Chọn tài liệu để upload";
            openFileDialog1.Filter = "Chọn loại tài liệu(*.pdf;*.dox;*.xlsx;*.zip)|*.pdf; *.dox; *.xlsx; *.zip";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.CheckFileExists)
                {
                    string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                    txtUrl.Text = path;
                }
                else
                    MessageBox.Show("Tài liệu không tồn tại !");
            }
        }
        public void Getloaitl()
        {

            string query = "select * from LOAITAILIEU";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            ds = cn.Laydulieu(query, "LOAITAILIEU");
            txtloaitl.DataSource = ds.Tables["LOAITAILIEU"];
            txtloaitl.DisplayMember = "LOAITAILIEU";
            
        }

        private void butup_Click(object sender, EventArgs e)
        {
            int tid = Convert.ToInt32(num1.Value.ToString());
            string filename = txttentl.Text;
            string url = System.IO.Path.GetFileName(openFileDialog1.FileName);
            if (txtloaitl.Text == null || filename == null || txtMota.Text == null ||  txtnguoidang.Text == null)
            {
                MessageBox.Show("Lỗi khi tải tài liệu !");
               
            }
            else
            {
                try

                {
                    myClass.execQuery("INSERT INTO TAILIEU(MATAILIEU,MOTA, TENTAILIEU, LOAITAILIEU,URL, NGAY, NGUOIDANG) VALUES (N'" + tid + "',N'" + txtMota.Text + "',N'" + filename + "',N'" + txtloaitl.Text + "','\\Documents\\" + url + "','" + DateTime.Now.ToShortDateString() + "',N'" + txtnguoidang.Text + "')");
                    System.IO.File.Copy(openFileDialog1.FileName, Application.StartupPath + "\\Documents\\" + url);
                    MessageBox.Show("Tải tài liệu thành công !");
                }

                catch
                {
                    MessageBox.Show("Lỗi khi tải tài liệu rồi !");
                }
            }
   
         
            getdocument();
        }
        private void tailieu_Load(object sender, EventArgs e)
        {
            dttungay.Value = myClass.GetFirstDayInMont(DateTime.Now.Year, DateTime.Now.Month);
            dtdenngay.Value = DateTime.Now;
            getdocument();
            GetData();
            Getloaitl();
            txtloaitl.ResetText();
        }

        private void GetData()
        {
            string query = "select * from TAILIEU ";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            ds = cn.Laydulieu(query, "QUANLYTAILIEU1");
            dgvct.DataSource = ds.Tables["QUANLYTAILIEU1"];
        }

        public void getdocument()
        {
            gcDanhSach.DataSource = myClass.getData("select * from TAILIEU");
           gvDanhsach.OptionsBehavior.Editable=false;
        }

        private void gvDanhsach_DoubleClick(object sender, EventArgs e)
        {
            if (gvDanhsach.GetFocusedRowCellValue("URL") != null)
            {
                string path = Application.StartupPath + gvDanhsach.GetFocusedRowCellValue("URL").ToString();
                System.Diagnostics.Process.Start(path);
              
            }
        }

        private void dttungay_ValueChanged(object sender, EventArgs e)
        {
            if (dttungay.Value > dtdenngay.Value)
            {
                MessageBox.Show(" Ngày không hợp lệ !");
                return;            
            }
            else
                 getdocument();
        }

        private void dttungay_Leave(object sender, EventArgs e)
        {
            if (dttungay.Value > dtdenngay.Value)
            {
                MessageBox.Show(" Ngày không hợp lệ !");
                return;
            }
            else
               getdocument();
        }

        private void dtdenngay_ValueChanged(object sender, EventArgs e)
        {
            if (dttungay.Value > dtdenngay.Value)
            {
                MessageBox.Show(" Ngày không hợp lệ !");
                return;
            }
            else
                getdocument();
        }

        private void dtdenngay_Leave(object sender, EventArgs e)
        {
            if (dttungay.Value > dtdenngay.Value)
            {
                MessageBox.Show(" Ngày không hợp lệ !");
                return;
            }
            else
                getdocument();
        }

        private void gvDanhsach_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
      
        }

        private void gvDanhsach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void gvDanhsach_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
        
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtloaitl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txttenct.Text = dgvct.Rows[row].Cells["TENTAILIEU"].Value.ToString();
                txtid.Text = dgvct.Rows[row].Cells["MATAILIEU"].Value.ToString();
                txtmtct.Text = dgvct.Rows[row].Cells["MOTA"].Value.ToString();
                txtloaict.Text=dgvct.Rows[row].Cells["LOAITAILIEU"].Value.ToString();
                txturlct.Text = dgvct.Rows[row].Cells["URL"].Value.ToString();
                txtngct.Text = dgvct.Rows[row].Cells["NGUOIDANG"].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string ten = txttenct.Text;
            string mt = txtmtct.Text;
            string loai = txtloaict.Text;
            string nguoict = txtngct.Text;
            string urlct = txturlct.Text;
            string sql = "update TAILIEU set MATAILIEU = '" + id + "',MOTA=N'" + mt + "',TENTAILIEU=N'" + ten + "',LOAITAILIEU=N'" + loai + "',URL=N'" + urlct + "',NGAY=N'" + DateTime.Now.ToShortDateString() + "',NGUOIDANG=N'" + nguoict + "' where MATAILIEU = '" + id + "'";
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true && id != "")
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
            string ma = txtid.Text;
            string sql = "delete  from TAILIEU where MATAILIEU = '" + ma + "'";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true && ma != "")
            {
                MessageBox.Show("Xóa tài liệu thành công!");
                GetData();
            }
            else
            {
                MessageBox.Show("Xóa tài liệu thất bại!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
          
                string tkiem = texttkct.Text;
                string query = "select * from TAILIEU where TENTAILIEU like N'%" + tkiem + "%'";
                DataSet ds = new DataSet();
                ketnoi cn = new ketnoi();
                ds = cn.Laydulieu(query, "QUANLYTAILIEU1");
                dgvct.DataSource = ds.Tables["QUANLYTAILIEU1"];
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetData();
            txttenct.Text = "";
            txtid.Text = "";
            txtmtct.Text = "";
            txtloaict.Text = "";
            txturlct.Text = "";
            txtngct.Text = "";
            txttkct.Text = "";
        }
        }
}