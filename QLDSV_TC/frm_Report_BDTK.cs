using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;



namespace QLDSV_TC
{
    public partial class frm_Report_BDTK : Form
    {
        public string macn = "";
        public frm_Report_BDTK()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frm_Report_BDTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.dS.KHOA);

            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);

            macn = ((DataRowView)lOPBindingSource[0])["MAKHOA"].ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm; // Sao chép bds_dspm từ form dn qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;


            if (Program.mGroup != "PGV")
            {
                cmbChiNhanh.Enabled = false;
            }

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Kết nối về khoa mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dS.KHOA);

                macn = ((DataRowView)lOPBindingSource[0])["MAKHOA"].ToString();
            }
        }


        private void btnInDS_Click(object sender, EventArgs e)
        {
            rp_BDTK report = new rp_BDTK(cmbMaLop.Text);
            report.xrKhoa.Text = "KHOA" + txtTenKhoa.Text; ;
            report.xrKhoaHoc.Text = "Niên Khóa: " + txtKhoaHoc.Text;
            report.xrMaLop.Text = " Môn Học: " + cmbMaLop.Text;
            report.xrLop.Text = "Nhóm: " + txtTenLop.Text;
            //MessageBox.Show(cmbNienKhoa.Text + Int32.Parse(cmbHocKy.Text) + cmbMaMH.SelectedValue.ToString() + Int32.Parse(cmbNhom.Text));
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }
    }
}
