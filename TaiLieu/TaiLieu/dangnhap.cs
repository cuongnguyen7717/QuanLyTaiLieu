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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TaiLieu
{
    public partial class dangnhap : DevExpress.XtraEditors.XtraForm
    {
        public static string quyen = "";
        public dangnhap()
        {
            InitializeComponent();
        }

        private void txttk_Leave(object sender, EventArgs e)
        {
            if (txttk.Text.Trim() == "")
            {
                txttk.Text = txttk.Tag.ToString();
                txttk.ForeColor = Color.White;
            }
        }

        private void txttk_Enter(object sender, EventArgs e)
        {
            if (txttk.Text == txttk.Tag.ToString())
            {
                txttk.Text = "";
                txttk.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim() == "")
            {
                txtPass.Text = txtPass.Tag.ToString();
                txtPass.ForeColor = Color.White;
            }
        }
        public Form currentFormChild1;
        public void OpenChildForm1(Form childform)
        {
            if (currentFormChild1 != null)
            {
                currentFormChild1.Close();
            }
            currentFormChild1 = childform;
            childform.TopLevel = false;
            childform.Dock = DockStyle.Fill;
            childform.FormBorderStyle = FormBorderStyle.None;
            panel_login.Controls.Add(childform);
            panel_login.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == txtPass.Tag.ToString())
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
            }
        }

        private void CheckBoxMk_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = CheckBoxMk.Checked ? '\0' : '●';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenChildForm1(new dangky());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentFormChild1 != null)
            {
                currentFormChild1.Close();
            }

            string tk = txttk.Text;
            string mk = txtPass.Text;
            string Query = "Select * From TAIKHOAN where TAIKHOAN = '" + tk + "' and MATKHAU = '" + mk + "'";
            ketnoi cn = new ketnoi();
            DataSet ds = cn.Laydulieu(Query, "taikhoan");
            if (txttk.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
            }
            else if (ds.Tables["taikhoan"].Rows.Count > 0)
            {
                quyen = ds.Tables["TAIKHOAN"].Rows[0][2].ToString();
                trangchu frm = new trangchu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại !");
            }

        }
    }
}