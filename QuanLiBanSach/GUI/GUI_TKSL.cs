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
using BLL;
namespace GUI
{
    public partial class GUI_TKSL : DevExpress.XtraEditors.XtraForm
    {
        BLL_BC_TK bctk = new BLL_BC_TK();
        public GUI_TKSL()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_TKSL_Load(object sender, EventArgs e)
        {
            dgvDSS.DataSource = bctk.showDSS();
            cbxNXB.DisplayMember = "tenNXB";
            cbxNXB.DataSource = bctk.LoadTenNXB();
            cbxTG.DisplayMember = "tenTG";
            cbxTG.DataSource = bctk.LoadTenTG();
            cbxTG.Text = "";
            cbxNXB.Text = "";
        }

        private void btnRF_Click(object sender, EventArgs e)
        {
            dgvDSS.DataSource = bctk.showDSS();
            cbxNXB.DisplayMember = "tenNXB";
            cbxNXB.DataSource = bctk.LoadTenNXB();
            cbxTG.DisplayMember = "tenTG";
            cbxTG.DataSource = bctk.LoadTenTG();
            cbxTG.Text = "";
            cbxNXB.Text = "";
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            try
            {
                RP_TKSL tksl = new RP_TKSL();
                tksl.SetDataSource(bctk.inTKSL(cbxNXB.Text.Trim(), cbxTG.Text.Trim()));
                GUI_RP RP = new GUI_RP();
                RP.cryRP.ReportSource = tksl;
                RP.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Xuất báo cáo không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}