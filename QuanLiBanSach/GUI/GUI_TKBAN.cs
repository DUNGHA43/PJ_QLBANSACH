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
    public partial class GUI_TKBAN : DevExpress.XtraEditors.XtraForm
    {
        BLL_BC_TK bctk = new BLL_BC_TK();
        public GUI_TKBAN()
        {
            InitializeComponent();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            dgvCTHD.DataSource = bctk.showCTDSHD(txtMaHD.Text.Trim());
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            if(rdoTKHD.Checked)
            {
                RP_TKHD tkpn = new RP_TKHD();
                tkpn.SetDataSource(bctk.inHD(cbxThang.Text.Trim(), cbxNam.Text.Trim()));
                GUI_RP RP = new GUI_RP();
                RP.cryRP.ReportSource = tkpn;
                RP.ShowDialog();
            }
            else if(rdoTKCTHD.Checked)
            {
                RP_TKCTHD tkpn = new RP_TKCTHD();
                tkpn.SetDataSource(bctk.inCTHD(cbxThang.Text.Trim(), cbxNam.Text.Trim()));
                GUI_RP RP = new GUI_RP();
                RP.cryRP.ReportSource = tkpn;
                RP.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức năng cần thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRF_Click(object sender, EventArgs e)
        {
            var clear = new DataTable();
            txtMaHD.Clear();
            cbxNam.Text = "";
            cbxThang.Text = "";
            dgvCTHD.DataSource = clear;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSHD.CurrentRow.Index;
            txtMaHD.Text = dgvDSHD.Rows[i].Cells[0].Value.ToString();
        }
        private void loadHD()
        {
            dgvDSHD.DataSource = bctk.showDSHD();
        }
        private void GUI_TKBAN_Load(object sender, EventArgs e)
        {
            loadHD();
        }
    }
}