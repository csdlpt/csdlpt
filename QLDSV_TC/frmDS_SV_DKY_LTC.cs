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
    public partial class frmDS_SV_DKY_LTC : Form
    {
        public string macn = "";
        DataTable dt_ds_sv_dk_ltc = new DataTable();
        public frmDS_SV_DKY_LTC()
        {
            InitializeComponent();
        }

        private void frmDS_SV_DKY_LTC_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
           

            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            
            macn = ((DataRowView)kHOABindingSource[0])["MAKHOA"].ToString();
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
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dS.KHOA);

                macn = ((DataRowView)mONHOCBindingSource[0])["MAKHOA"].ToString();
            }
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            
                //string strlenh = "EXEC SP_REPORT_DS_SV_DK_LTC  '" 
                //+ cmbNienKhoa.Text +"','"+cmbHocKy.Text +"', '"+cmbMaMH.Text+"','"+cmbNhom.Text+"'";
                // dt_ds_sv_dk_ltc = Program.ExecSqlDataTable(strlenh);
                rp_DS_SV_DK_MH_LTC report = new rp_DS_SV_DK_MH_LTC(cmbNienKhoa.Text, Int32.Parse(cmbHocKy.Text),
                                                                   txtMamh.Text, Int32.Parse(cmbNhom.Text));
            report.xrKhoa.Text = "KHOA" + txtTenKhoa.Text; ;
            report.xrNienKhoa.Text = "Niên Khóa: " + cmbNienKhoa.Text;
            report.xrHocKy.Text = "Học Kỳ: " + cmbHocKy.Text;
            report.xrMonHoc.Text = " Môn Học: " + cmbTenMH.Text;
            report.xrNhom.Text = "Nhóm: " + cmbNhom.Text;
            //MessageBox.Show(cmbNienKhoa.Text + Int32.Parse(cmbHocKy.Text) + cmbMaMH.SelectedValue.ToString() + Int32.Parse(cmbNhom.Text));
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
            
        }
    }
}
