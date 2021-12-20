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
    
    public partial class frmLopTInChi : Form
    {
        public int vitri;
        public string  macn = "";
        
        public frmLopTInChi()
        {
            InitializeComponent();
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPTINCHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmLopTInChi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            
            // TODO: This line of code loads data into the 'dS.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
  

            macn = ((DataRowView)lOPTINCHIBindingSource[0])["MAKHOA"].ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm; // Sao chép bds_dspm từ form dn qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            EnableForm();
            
            if(Program.mGroup == "PGV")
            {
                cmbChiNhanh.Enabled = true;
            }
            
            txtMaKhoa.Text = macn;
           

        }
        private void DisableForm()
        {
            lOPTINCHIGridControl.Enabled = false;
            btnThem.Enabled = btnSuaa.Enabled = btnXoa.Enabled =  false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            txtMaKhoa.Enabled = false ;
            cmbMaMH.Enabled = cmbNienKhoa.Enabled = cmbHocKy.Enabled = cmbNhom.Enabled = seSVTT.Enabled = true;
            cmbChiNhanh.Enabled = false;
        }

        private void EnableForm()
        {
            lOPTINCHIGridControl.Enabled = true;
            btnThem.Enabled = btnSuaa.Enabled = btnXoa.Enabled = true;
             txtMaKhoa.Enabled = cmbMaMH.Enabled = cmbNienKhoa.Enabled = cmbHocKy.Enabled = cmbNhom.Enabled = seSVTT.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
            cmbChiNhanh.Enabled = true;
        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           if( MessageBox.Show("Bạn có muốn xóa lớp này??","", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    lOPTINCHIBindingSource.RemoveCurrent();
                    this.lOPTINCHITableAdapter.Update(this.dS.LOPTINCHI);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp tín chỉ!!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = lOPTINCHIBindingSource.Position;
            lOPTINCHIBindingSource.AddNew();
            
            txtMaKhoa.Text = macn;
            ceHuyLop.Checked = false;
            
            DisableForm();

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if(cmbNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Nien khoa khong được để trống!!!", "", MessageBoxButtons.OK);
                cmbNienKhoa.Focus();
                return;
            }
            if (int.Parse(seSVTT.Text) <= 0)
            {
                MessageBox.Show("Số sinh viên tối thiểu phải lớn hơn 0 !!!", "", MessageBoxButtons.OK);
                seSVTT.Focus();
                return;
            }
            string strLenh = " DECLARE @result int " +
                    "EXEC @result = sp_ktLopTinChi '" + cmbNienKhoa.Text + "', '" + int.Parse(cmbHocKy.Text) + "','" + cmbMaMH.SelectedValue.ToString() + "', '" + int.Parse(cmbNhom.Text)
                    + "' " + "SELECT 'result' = @result";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            int positionTenLopTC = lOPTINCHIBindingSource.Find("MAMH", cmbMaMH.Text);
            
            if (result == 1 )
            {
                MessageBox.Show("Lớp tín chỉ đã tồn tại", "", MessageBoxButtons.OK);
                return;
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            }
            try
            {
                ((DataRowView)lOPTINCHIBindingSource[lOPTINCHIBindingSource.Position])["NIENKHOA"] = cmbNienKhoa.Text;
                ((DataRowView)lOPTINCHIBindingSource[lOPTINCHIBindingSource.Position])["HOCKY"] = cmbHocKy.Text;
                ((DataRowView)lOPTINCHIBindingSource[lOPTINCHIBindingSource.Position])["NHOM"] = cmbNhom.Text;
                ((DataRowView)lOPTINCHIBindingSource[lOPTINCHIBindingSource.Position])["MAMH"] = cmbMaMH.SelectedValue.ToString();
                ((DataRowView)lOPTINCHIBindingSource[lOPTINCHIBindingSource.Position])["MAGV"] = Program.username;
                ((DataRowView)lOPTINCHIBindingSource[lOPTINCHIBindingSource.Position])["SOSVTOITHIEU"] = seSVTT.Text;
                lOPTINCHIBindingSource.EndEdit();
                lOPTINCHIBindingSource.ResetCurrentItem();
               
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Update(this.dS.LOPTINCHI);
                MessageBox.Show("Đã ghi thành công!!!", " ", MessageBoxButtons.OK);
                lOPTINCHIBindingSource.Position = vitri;
                EnableForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi thêm lớp tín chỉ" + ex.Message, "", MessageBoxButtons.OK);
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            }

        }

        private void seSVTT_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSuaa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = lOPTINCHIBindingSource.Position;
            DisableForm();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lOPTINCHIBindingSource.CancelEdit();
            EnableForm();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

            if(cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if(Program.KetNoi() == 0)
            {
                MessageBox.Show("Kết nối về khoa mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);

                macn = ((DataRowView)lOPTINCHIBindingSource[0])["MAKHOA"].ToString();
            }
        }

        private void mAMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void cmbMaMH_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mAKHOALabel_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKhoa_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
