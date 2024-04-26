using BLL;
using Syncfusion.Licensing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DangNhap
{
    public partial class CuDan : Form
    {
        private List<Resident> residents; 
        public CuDan()
        {
            InitializeComponent();
            SyncfusionLicenseProvider.RegisterLicense("MzIxOTI2MkAzMjM1MmUzMDJlMzBORkJZeFRVdUQxeERjT2xkWC9vdFgxS29wUmREOU9CZVdENkRUN0lrSStVPQ==;Mgo+DSMBaFt6QHFqVkNrXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRbQlliS3xTck1hW35Wcnc=");
        }
        private void GetAllResidents()
        {
            residents = ResidentBLL.Instance.GetAllResidents();
        }
        private void DisplayGGC_cudan()
        {
            GetAllResidents();
            GGC_cudan.DataSource = residents;
        }

        private void CuDan_Load(object sender, EventArgs e)
        {
            DisplayGGC_cudan();
        }
    }
}
