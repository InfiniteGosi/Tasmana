﻿using System;
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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_chitiet_Click(object sender, EventArgs e)
        {
            LichSuCanHo lsch = new LichSuCanHo();
            lsch.Show();
        }
    }
}
