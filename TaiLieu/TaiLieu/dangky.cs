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
    public partial class dangky : DevExpress.XtraEditors.XtraForm
    {
        public dangky()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string taikhoan = txttk.Text;
            string matkhau = txtmk.Text;
            string quyen = cbquyen.SelectedItem.ToString();
            string query = "insert into taikhoan (TAIKHOAN,MATKHAU,QUYEN)VALUES('" + taikhoan + "','" + matkhau + "', '" + quyen + "')";
            ketnoi cn = new ketnoi();
            bool kt = cn.ThucThi(query);
            if (txttk.Text == "" && txtmk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else if (txtmk.Text != txtnhaplai.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp !");
            }
            else if (kt == true)
            {
                MessageBox.Show("Thêm thành công !");
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmk.Text = "";
            txttk.Text = "";
            cbquyen.ResetText();
        }
    }
}