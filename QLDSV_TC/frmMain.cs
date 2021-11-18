using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {

            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            string strLenh = "SELECT TOP 1000 TENCN, TENSERVER FROM QLDSV_TC.dbo.V_DS_PHANMANH";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_NhapSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frm_NhapSinhVien f = new frm_NhapSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLopTinChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopTInChi));
            if (frm != null) frm.Activate();
            else
            {
                frmLopTInChi f = new frmLopTInChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MaSo_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKyLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDky_LopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                frmDky_LopTinChi f = new frmDky_LopTinChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSSVDKLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDS_SV_DKY_LTC));
            if (frm != null) frm.Activate();
            else
            {
                frmDS_SV_DKY_LTC f = new frmDS_SV_DKY_LTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            btnLop.Enabled = true;
            btnSinhVien.Enabled = true;
            btnMonHoc.Enabled = true; // Lop Hoc
            btnNhapDiem.Enabled = true;
            btnDangKyLTC.Enabled = true;
            btnDSDHPLTC.Enabled = true;
            btnBDTK.Enabled = true;
            btnDongHocPhi.Enabled = true;
            btnLopTinChi.Enabled = true;
            btnPhieuDiem.Enabled = true;
            btnBDMLTC.Enabled = true;
            btnDSLTC.Enabled = true;
            btnBDTK.Enabled = true;

            if (Program.mGroup == "PKT")
            {
                btnLop.Enabled = false;
                btnSinhVien.Enabled = false;
                btnMonHoc.Enabled = false; // Lop Hoc
                btnNhapDiem.Enabled = false;
                btnDangKyLTC.Enabled = false;
                btnDSDHPLTC.Enabled = true;
                btnBDTK.Enabled = false;
                btnDongHocPhi.Enabled = true;
                btnLopTinChi.Enabled = false;
                btnPhieuDiem.Enabled = false;
                btnBDMLTC.Enabled = false;
                btnDSLTC.Enabled = false;
                btnBDTK.Enabled = false;
            }
            else if (Program.mGroup == "KHOA")
            {
                btnDongHocPhi.Enabled = false;
                btnDSDHPLTC.Enabled = false;
            }
            else if (Program.mGroup == "SV")
            {
                btnLop.Enabled = false;
                btnSinhVien.Enabled = false;
                btnMonHoc.Enabled = false; // Lop Hoc
                btnNhapDiem.Enabled = false;
               
                btnDSDHPLTC.Enabled = false;
                btnBDTK.Enabled = false;
                btnDongHocPhi.Enabled = false;
                btnLopTinChi.Enabled = false;
                btnPhieuDiem.Enabled = false;
                btnBDMLTC.Enabled = false;
                btnDSLTC.Enabled = false;
                btnBDTK.Enabled = false;
            }
            else if (Program.mGroup == "PGV")
            {
                btnDongHocPhi.Enabled = false;
                btnDSDHPLTC.Enabled = false;
            }
        }

        private void btnPhieuDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_PhieuDiem));
            if (frm != null) frm.Activate();
            else
            {
                frm_PhieuDiem f = new frm_PhieuDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBDTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_Report_BDTK));
            if (frm != null) frm.Activate();
            else
            {
                frm_Report_BDTK f = new frm_Report_BDTK();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
