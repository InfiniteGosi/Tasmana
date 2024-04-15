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
    public partial class ChiTietCanHo : Form
    {
        public ChiTietCanHo()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            currentFormChild?.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PN_hienthi.Controls.Add(childForm);
            PN_hienthi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BTN_lichsu_Click(object sender, EventArgs e)
        {
             OpenChildForm(new CongViecChung());
             BTN_lichsu.BackColor = Color.FromArgb(51, 53, 55);
             BTN_chung.BackColor = Color.Transparent;
        }

        private void BTN_chung_Click(object sender, EventArgs e)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            BTN_chung.BackColor = Color.FromArgb(51, 53, 55);
            BTN_lichsu.BackColor = Color.Transparent;
        }
    }
}
