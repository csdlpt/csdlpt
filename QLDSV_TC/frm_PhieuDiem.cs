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
   
    public partial class frm_PhieuDiem : Form
    {
        public string macn = "";
        public frm_PhieuDiem()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frm_PhieuDiem_Load(object sender, EventArgs e)
        {

            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            macn = ((DataRowView)lOPBindingSource[0])["MAKHOA"].ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup != "PGV")
            {
                cmbChiNhanh.Enabled = false;
            }


        }

      

        private void btnInDS_Click(object sender, EventArgs e)
        {
           rp_PhieuDiem report = new rp_PhieuDiem(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MASV").ToString());
            report.xrMaSV.Text = "Mã Sinh Viên: " + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MASV").ToString();
            report.xrHoTen.Text = "Họ Tên Sinh Viên: " + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "HO").ToString() +" " +
                                    " "+ gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TEN").ToString();
            report.xrLop.Text = "Lớp: " + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MALOP").ToString();
            
            //MessageBox.Show(cmbNienKhoa.Text + Int32.Parse(cmbHocKy.Text) + cmbMaMH.SelectedValue.ToString() + Int32.Parse(cmbNhom.Text));
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void cmbChiNhanh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }

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
                MessageBox.Show("Chyển sang khoa mới!!", "", MessageBoxButtons.OK);
            }
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);

                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

                macn = ((DataRowView)lOPBindingSource[0])["MAKHOA"].ToString();
            }
        }
    }
}
