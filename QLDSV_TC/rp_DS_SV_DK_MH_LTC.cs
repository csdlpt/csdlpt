using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class rp_DS_SV_DK_MH_LTC : DevExpress.XtraReports.UI.XtraReport
    {
        public rp_DS_SV_DK_MH_LTC(string NienKhoa, int HocKy, string MaMH, int Nhom)
        {
            InitializeComponent();
                this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
                this.sqlDataSource1.Queries[0].Parameters[0].Value = NienKhoa;
                this.sqlDataSource1.Queries[0].Parameters[1].Value = HocKy;
                this.sqlDataSource1.Queries[0].Parameters[2].Value = MaMH;
                this.sqlDataSource1.Queries[0].Parameters[3].Value = Nhom;
                this.sqlDataSource1.Fill();

            

        }

    }
}
