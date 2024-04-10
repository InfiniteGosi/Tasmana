using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Office.Interop.Excel;
using System.Collections;

namespace DangNhap
{
    public partial class DangNhap : Form
    {
        public static Account currentAccount;
        int mov;
        int movX;
        int movY;
        public DangNhap()
        {
            InitializeComponent();
        }
        private bool CheckAccountExistence(string userId)
        {
            return AccountBLL.Instance.CheckAccountExistence(userId);
        }
        private bool CheckAccountPassword(string userId, string password)
        {
            return AccountBLL.Instance.CheckAccountPasword(userId, password);
        }
        private void GetAccount(string userId)
        {
            currentAccount = AccountBLL.Instance.GetAccount(userId);
        }

        private void BT_DangNhap_Click(object sender, EventArgs e)
        {
            string userId = TB_TaiKhoan.Text;
            string pwd = TB_MatKhau.Text;

            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Vui lòng nhập mã người dùng");
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }

            if (CheckAccountExistence(userId))
            {
                if (CheckAccountPassword(userId, pwd))
                {
                    GetAccount(userId);
                    if (!currentAccount.IsDisabled)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        TrangHienThi formTrangChu = new TrangHienThi();
                        formTrangChu.ShowDialog();
                    }
                    else
                    {
                        LB_error.Text = "Tài khoản đã bị vô hiệu hóa";
                    }
                }
                else
                {
                    LB_error.Text = "Mật khẩu không đúng";
                }
            }
            else
            {
                LB_error.Text = "Tài khoản không tồn tại";
            }
        }

        private void VB_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (VB_HienMatKhau.Checked)
            {
                TB_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                TB_MatKhau.UseSystemPasswordChar = true;
            }
        }

        private void BTN_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void DangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void DangNhap_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
