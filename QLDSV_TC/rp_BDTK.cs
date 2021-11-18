using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class rp_BDTK : DevExpress.XtraReports.UI.XtraReport
    {
        public rp_BDTK(String MaLop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MaLop;
            this.sqlDataSource1.Fill();

        }

    }
}
