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
    public partial class GUI_TKNHAP : DevExpress.XtraEditors.XtraForm
    {
        BLL_BC_TK bctk = new BLL_BC_TK();
        public GUI_TKNHAP()
        {
            InitializeComponent();
        }
        private void showDSPN()
        {
            dgvDSPN.DataSource = bctk.showDSPN();
        }
        private void loadNXB()
        {
            cbxNXB.DisplayMember = "tenNXB";
            cbxNXB.DataSource = bctk.LoadTenNXB();
        }
        private void btnIN_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoTKPN.Checked)
                {
                    RP_IN_TKPN tkpn = new RP_IN_TKPN();
                    tkpn.SetDataSource(bctk.inPN(cbxThang.Text.Trim(), cbxNam.Text.Trim(), cbxNXB.Text.Trim()));
                    GUI_RP RP = new GUI_RP();
                    RP.cryRP.ReportSource = tkpn;
                    RP.ShowDialog();
                }
                else if (rdoTKCTPN.Checked)
                {
                    RP_INCTPN tkpn = new RP_INCTPN();
                    tkpn.SetDataSource(bctk.inCTPN(cbxThang.Text.Trim(), cbxNam.Text.Trim(), cbxNXB.Text.Trim()));
                    GUI_RP RP = new GUI_RP();
                    RP.cryRP.ReportSource = tkpn;
                    RP.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng tích vào mục muốn thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Xuất báo cáo không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GUI_TKNHAP_Load(object sender, EventArgs e)
        {
            showDSPN();
            loadNXB();
            cbxNXB.Text = "";
        }

        private void txtMaPN_TextChanged(object sender, EventArgs e)
        {
            dgvCTPN.DataSource = bctk.showCTDSPN(txtMaPN.Text.Trim());
        }

        private void dgvDSPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSPN.CurrentRow.Index;
            txtMaPN.Text = dgvDSPN.Rows[i].Cells[0].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRF_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            dgvCTPN.DataSource = dt;
            txtMaPN.Clear();
            cbxNam.Text = "";
            cbxThang.Text = "";
            cbxNXB.Text = "";
        }
    }
}