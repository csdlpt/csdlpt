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
    }
}
