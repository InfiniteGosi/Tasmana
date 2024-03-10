using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(childForm);
            pn_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongBao());
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
        }

        private void btn_cv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CongViecChung());
        }
    }
}
