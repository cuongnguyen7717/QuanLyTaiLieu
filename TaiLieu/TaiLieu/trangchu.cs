using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaiLieu
{
    public partial class trangchu : DevExpress.XtraEditors.XtraForm
    {
        public trangchu()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.Dock = DockStyle.Fill;
            childform.FormBorderStyle = FormBorderStyle.None;
            panel_Body.Controls.Add(childform);
            panel_Body.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

      


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lb_form.Text = " Trang chủ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lb_form.Text = " Trang chủ";
        }

        private void buttlieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new tailieu());
            lb_form.Text = buttlieu.Text;
        }

        private void buttloai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new loaitailieu());
            lb_form.Text = buttloai.Text;
        }

        private void butnvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new nhanvien());
            lb_form.Text = butnvien.Text;
        }

        private void buttke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new thongke());
            lb_form.Text = buttke.Text;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new dangky());
            lb_form.Text = buttlieu.Text;

        }

        private void trangchu_Load(object sender, EventArgs e)
        {
            if (dangnhap.quyen == "Admin")
            {
                buttloai.Enabled = true;
                butdktk.Enabled = true;
                butnvien.Enabled = true;
                buttke.Enabled = true;
                buttlieu.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                butdktk.Enabled = false;
                butnvien.Enabled = false;
         

            }
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
