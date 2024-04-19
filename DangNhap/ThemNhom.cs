﻿using BLL;
using DTO;
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
    public partial class ThemNhom : Form
    {
        public ThemNhom()
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
            PN_main.Controls.Add(childForm);
            PN_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void BTN_phongban_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemPhongBan());
            BTN_nhanvien.BackColor = Color.Transparent;
            BTN_phongban.BackColor = Color.FromArgb(51, 53, 55);
        }
        private void BTN_nhanvien_Click(object sender, EventArgs e)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            BTN_phongban.BackColor = Color.Transparent;
            BTN_nhanvien.BackColor = Color.FromArgb(51, 53, 55);
        }
        private void BTN_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Di chuyển form
        int mov;
        int movX;
        int movY;

        private void ThemNhom_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void ThemNhom_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void ThemNhom_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        public List<Division> GetPhongBan()
        {
            List<Division> listMaPB = new List<Division>();
            listMaPB = DivisionBLL.Instance.GetDivisionList();
            return listMaPB;
        }
        private void ReadPhongBan()
        {
            List<Division> listPB = new List<Division>();
            CBB_phongban.Enabled = true;
            CBB_phongban.Items.Clear();
            listPB = GetPhongBan();
            for (int i = 0; i < listPB.Count; i++)
            {
                CBB_phongban.Items.Add(listPB[i].MaBoPhan + "-" + listPB[i].TenBoPhan);
            }
        }

        public List<Employee> GetEmployee(string maBoPhan)
        {
            List<Employee> list = new List<Employee>();
            list = EmployeeBLL.Instance.GetEmployeeByDivision(maBoPhan);
            return list;
        }

        public void ReadNV()
        {
            List<Employee> employees = new List<Employee>();
            CBB_nhanvien.Enabled = true;
            CBB_nhanvien.Items.Clear();
            employees = GetEmployee(CBB_phongban.SelectedItem.ToString().Split('-')[0]);
            for (int i = 0;i < employees.Count;i++)
            {
                CBB_nhanvien.Items.Add(employees[i].MaNhanVien + "_" + employees[i].Ten);
            }
        }

        private void ThemNhom_Load(object sender, EventArgs e)
        {
            ReadPhongBan();
        }

        private void CBB_phongban_SelectedValueChanged(object sender, EventArgs e)
        {
            if(CBB_phongban.SelectedIndex != -1)
            {
                ReadNV();
            }
        }

        private void CBB_nhanvien_SelectedValueChanged(object sender, EventArgs e)
        {
            if(CBB_nhanvien.SelectedIndex != -1)
            {
                TXB_maNhom.Enabled = true;
            }
        }
        private Dictionary<string, object> AddParametersForGroup()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"@maNhom",  TXB_maNhom.Text},
                {"@maTruongNhom", CBB_nhanvien.SelectedItem.ToString().Split('_')[0]},
                {"@maBoPhan", CBB_phongban.SelectedItem.ToString().Split('-')[0]}
            };
            return dict;
        }
        private bool SaveGroup()
        {
            if (GroupBLL.Instance.AddGroup(AddParametersForGroup()))
            {
                return true;
            }
            return false;
        }
        private void BTN_ok_Click(object sender, EventArgs e)
        {
            if(CBB_phongban.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Phòng ban");
                return;
            }
            if(CBB_nhanvien.SelectedIndex == -1) 
            {
                MessageBox.Show("Vui lòng chọn nhóm trưởng");
                return;
            }
            if(string.IsNullOrEmpty(TXB_maNhom.Text))
            {
                MessageBox.Show("Vui lòng điền mã nhóm");
                return;
            }
            if(SaveGroup())
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
