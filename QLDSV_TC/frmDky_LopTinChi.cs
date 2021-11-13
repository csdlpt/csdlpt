using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLDSV_TC
{
    public partial class frmDky_LopTinChi : Form
    {
        DataTable dt_ds_ltc = new DataTable();
        SqlCommand sp_dky_mh = new SqlCommand();
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
            //MessageBox.Show(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MALTC").ToString());
            
            try
            {
                this.sP_LAY_DS_MONHOC_DADKY_NKHKTableAdapter.Connection.ConnectionString = Program.connstr;
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

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            String strlenh1 = "DECLARE @result int " 
                    + "EXEC @result = SP_KT_MH_KHI_DKY  '"
                    + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMH").ToString()+ "','"
                    + cmbNienKhoa.Text + "','"
                    +cmbHocKy.Text +"' "+" SELECT 'result' = @result ";


            bool result = Program.ExecSqlNonQuery(strlenh1);
            
            if(result == true)
            {
              MessageBox.Show("Bạn đã đăng ký môn học này rồi!!", "", MessageBoxButtons.OK);
               return;
            }
            try
            {
                String strlenh = "EXEC SP_INSERT_DKY_MONHOC '" + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MALTC") + "','" + Program.frmChinh.MaSo.Text + "'";
                 Program.ExecSqlNonQuery(strlenh);
                this.sP_LAY_DS_MONHOC_DADKY_NKHKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_DS_MONHOC_DADKY_NKHKTableAdapter.Fill(this.dS.SP_LAY_DS_MONHOC_DADKY_NKHK, Program.frmChinh.MaSo.Text, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Đăng ký thành công môn học " + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENMH").ToString());
        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            
            try
            {
                String strlenh = "EXEC SP_HUY_DKY_MONHOC '" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MALTC") + "','" + Program.frmChinh.MaSo.Text + "'";
                Program.ExecSqlNonQuery(strlenh);
                this.sP_LAY_DS_MONHOC_DADKY_NKHKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_DS_MONHOC_DADKY_NKHKTableAdapter.Fill(this.dS.SP_LAY_DS_MONHOC_DADKY_NKHK, Program.frmChinh.MaSo.Text, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
                MessageBox.Show("Hủy đăng ký thành công môn học " + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TENMH").ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
    }
}
