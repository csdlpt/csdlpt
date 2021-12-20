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
    public partial class fmt_Lop : Form
    {
        public int vitri;
        public string macn = "";
        public string tenGV = Program.username;
        public fmt_Lop()
        {
            InitializeComponent();
        }



        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void fmt_Lop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS.DANGKY' table. You can move, or remove it, as needed.
        
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            macn = ((DataRowView)lOPBindingSource[0])["MAKHOA"].ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if(Program.mGroup == "KHOA" || Program.mGroup == "SV")
            {
                cmbChiNhanh.Enabled = false;
                btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = false;

            }


        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void lOPBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void lOPBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = lOPBindingSource.Position;
            lOPBindingSource.AddNew();
            txtMaKhoa.Text = macn;
            txtMaLop.ReadOnly = false;
            txtMaLop.Focus();
            

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lOPBindingSource.Count == 0)
            {
                return;
            } else
            {
                if(bdsSV.Count > 0)
                {
                    MessageBox.Show("Lớp có sinh viên, không thể xóa", "Thông báo", MessageBoxButtons.OK);
                    return;
                } else
                {
                    DialogResult ds = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                    if (ds == DialogResult.Yes)
                    {
                        try
                        {
                            lOPBindingSource.RemoveCurrent();
                            this.lOPTableAdapter.Update(dS.LOP);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa lớp!!\n" + ex.Message, "", MessageBoxButtons.OK);
                            return;
                        }
                    }

                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lOPBindingSource.CancelEdit();
            this.lOPTableAdapter.Fill(this.dS.LOP);
            EnableForm();
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = lOPBindingSource.Position;
            DisableForm();
        }
        private void EnableForm()
        {
            lOPGridControl.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
           // txtMaKhoa.Enabled = cmbMaMH.Enabled = cmbNienKhoa.Enabled = cmbHocKy.Enabled = cmbNhom.Enabled = seSVTT.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
            cmbChiNhanh.Enabled = true;
        }
        private void DisableForm()
        {
            lOPGridControl.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            txtMaKhoa.Enabled = false;
           // cmbMaMH.Enabled = cmbNienKhoa.Enabled = cmbHocKy.Enabled = cmbNhom.Enabled = seSVTT.Enabled = true;
            cmbChiNhanh.Enabled = false;
        }
    }
}
