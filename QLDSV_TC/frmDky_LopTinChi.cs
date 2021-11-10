using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmDky_LopTinChi : Form
    {
        DataTable dt_ds_ltc = new DataTable();
        public frmDky_LopTinChi()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            String strlenh = "EXEC SP_LAY_DS_MONHOC_NKHK '" + cmbNienKhoa.Text + "','" + int.Parse(cmbHocKy.Text) + "'";
            dt_ds_ltc = Program.ExecSqlDataTable(strlenh);
            gcDSMH.DataSource = dt_ds_ltc;
           
            try
            {
                this.sP_LAY_DS_MONHOC_DADKY_NKHKTableAdapter.Fill(this.dS.SP_LAY_DS_MONHOC_DADKY_NKHK, Program.frmChinh.MaSo.Text, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.sP_LAY_DS_MONHOC_NKHKTableAdapter.Fill(this.dS.SP_LAY_DS_MONHOC_NKHK, cmbNienKhoa.Text,int.Parse(cmbHocKy.Text));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void frmDky_LopTinChi_Load(object sender, EventArgs e)
        {
            txtMasv.Text = Program.frmChinh.MaSo.Text;
            txtHoTen.Text = Program.mHoten;
            
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    this.sP_LAY_DS_MONHOC_DADKY_NKHKTableAdapter.Fill(this.dS.SP_LAY_DS_MONHOC_DADKY_NKHK, mASVToolStripTextBox.Text, nIENKHOAToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hOCKYToolStripTextBox.Text, typeof(int))))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }
    }
}
