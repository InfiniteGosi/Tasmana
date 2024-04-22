﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace DangNhap
{
    public partial class QuenMatKhau : Form
    {
        private Employee employee = null;
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        public static int RandomCode()
        {
            Random rdn = new Random();
            int num = rdn.Next(10000, 99999);
            return num;
        }
        int num = RandomCode();
        private void GetEmployeeByEmployeeId(string maNhanVien)
        {
            employee = EmployeeBLL.Instance.GetEmployeeByEmployeeId(maNhanVien);
        }

        private void BTN_guima_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TXB_employeId.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để xác minh email");
                return;
            }
            GetEmployeeByEmployeeId(TXB_employeId.Text);
            if (employee == null)
            {
                MessageBox.Show("Mã nhân viên không tồn tại");
                return;
            }
            TXB_email.Text = employee.Email;
            timer.Stop();
            string to, from, pass;
            to = employee.Email;
            from = "duyenman19@gmail.com";
            pass = "xglr vuyt mzre mmlp";
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Subject = "Hệ thống xác nhận mã tự động Tasmana";
            message.Body = "Mã xác nhận của anh/chị là: " + num.ToString();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show($"Đã gửi thành công mã xác nhận, vui lòng kiểm tra hộp thoại của email {employee.Email}", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi gửi mã xác nhận: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BTN_ok_Click(object sender, EventArgs e)
        {
            if (TXB_verify.Text.Equals(num.ToString()))
            {
                MessageBox.Show($"Mật khẩu cũ của bạn là {employee.TaiKhoanNguoiDung.Password}");
                Close();
            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng");
                return;
            }

        }
    }
}