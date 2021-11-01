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
    public partial class frm_NhapSinhVien : Form

    {
        public string macn = "";
        public int vitri;
        public frm_NhapSinhVien()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frm_NhapSinhVien_Load(object sender, EventArgs e)
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
            EnableForm();
            if(Program.mGroup == "PGV")
            {
                cmbChiNhanh.Enabled = true;
            }
            cmbChiNhanh.Text = macn;

        }

        private void DisableForm()
        {
            lOPGridControl.Enabled = sINHVIENGridControl.Enabled = false;
            btnThem.Enabled  = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

            txtMaSV.Enabled = txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled =
                checkPhai.Enabled = editDay.Enabled = true;
            cmbChiNhanh.Enabled = false;
        }

        private void EnableForm()
        {
            lOPGridControl.Enabled = sINHVIENGridControl.Enabled = true;
            btnThem.Enabled  = btnXoa.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
            txtMaSV.Enabled = txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled =
                checkPhai.Enabled = editDay.Enabled = false;
            cmbChiNhanh.Enabled = false;
        }
        private void dIACHILabel_Click(object sender, EventArgs e)
        {

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbChiNhanh.SelectedValue.ToString()== "System.Data.DataRowView")
            {
                return;
            }

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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = sINHVIENBindingSource.Position;
            
            sINHVIENBindingSource.AddNew();
            
            DisableForm();
            geNghiHoc.Checked = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa sinh viên này?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    sINHVIENBindingSource.RemoveCurrent();
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView current = (DataRowView)(sINHVIENBindingSource[sINHVIENBindingSource.Position]);
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            if(txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ sinh viên không được để trống!!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if(txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên sinh viên không được để trống!!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }

            try
            {
                sINHVIENBindingSource.EndEdit();
                sINHVIENBindingSource.ResetCurrentItem();
               
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
               
                MessageBox.Show("Thêm lớp tín chỉ thành công!!", "", MessageBoxButtons.OK);
                EnableForm();

            }
            catch(Exception ex)
            {
                MessageBox.Show(" Lỗi thêm sinh viên" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sINHVIENBindingSource.CancelEdit();
            EnableForm();
        }
    }
}
