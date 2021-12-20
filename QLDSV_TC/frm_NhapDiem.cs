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
    public partial class frm_NhapDiem : Form
    {
        DataTable dt_DS_DangKy = new DataTable();
        string maltc;
        public string macn = "";

        public frm_NhapDiem()
        {
            InitializeComponent();
        }

        private void btnLoadLTC_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_LAY_DS_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_DS_LTCTableAdapter.Fill(this.dS.SP_LAY_DS_LTC, cmbNK.Text, int.Parse(cmbHK.Text));
            } catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void cmbHK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_NhapDiem_Load(object sender, EventArgs e)
        {

            if (Program.KetNoi() == 0) return;
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbNK.SelectedIndex = 1;
            cmbNK.SelectedIndex = 0;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
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
               
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                maltc = ((DataRowView)bdsDSLTC[bdsDSLTC.Position])["MALTC"].ToString();
                string strLenh = "EXEC SP_LAY_DSSV_DANGKY " + maltc;
                dt_DS_DangKy = Program.ExecSqlDataTable(strLenh);
                sP_LAY_DSSV_DANGKYGridControl.DataSource = dt_DS_DangKy;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {


                DataTable dt = new DataTable();
                dt.Columns.Add("MALTC", typeof(int));
                dt.Columns.Add("MASV", typeof(string));
                dt.Columns.Add("DIEM_CC", typeof(int));
                dt.Columns.Add("DIEM_GK", typeof(float));
                dt.Columns.Add("DIEM_CK", typeof(float));
                int intmaltc = int.Parse(maltc);
                for (int i = 0; i < dt_DS_DangKy.Rows.Count; i++)
                {
                    dt.Rows.Add(intmaltc, dt_DS_DangKy.Rows[i]["MASV"], dt_DS_DangKy.Rows[i]["DIEM_CC"], dt_DS_DangKy.Rows[i]["DIEM_GK"], dt_DS_DangKy.Rows[i]["DIEM_CK"]);
                }
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_DANGKY";
                para.ParameterName = "@DIEMTHI";
                para.Value = dt;
                Program.KetNoi();

                SqlCommand Sqlcmd = new SqlCommand("SP_UPDATE_DIEM", Program.conn);
                Sqlcmd.Parameters.Clear();
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.Add(para);
                Sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Ghi Điểm Thành Công!!!", "", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.sP_LAY_DS_LTCTableAdapter.Fill(this.dS.SP_LAY_DS_LTC, new System.Nullable<int>(((int)(System.Convert.ChangeType(hKToolStripTextBox.Text, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //private void fillToolStripButton_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.sP_LAY_DSSV_DANGKYTableAdapter.Fill(this.dS.SP_LAY_DSSV_DANGKY, new System.Nullable<int>(((int)(System.Convert.ChangeType(mALTCToolStripTextBox.Text, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
