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
    public partial class ThongKeCanHo : Form
    {
        public ThongKeCanHo()
        {
            InitializeComponent();
        }

        private void CBB_DuLieuTK_SelectedValueChanged(object sender, EventArgs e)
        {
            if(CBB_DuLieuTK.SelectedValue.Equals("Mã căn hộ")) 
            {
                string[] ListOption = {"Công nợ", "Danh sách sữa chữa", "Tổng chi phí điện/nước", "Tổng chi phí quản lý"};
            }
        }
    }
}
