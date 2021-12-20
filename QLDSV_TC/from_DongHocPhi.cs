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
    public partial class from_DongHocPhi : Form
    {
        public from_DongHocPhi()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
              //  this.sP_LAY_HOTEN_SVTableAdapter.Fill(this.dS.SP_LAY_HOTEN_SV, mASVToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
              //  System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_LAY_HOTEN_SVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_HOTEN_SVTableAdapter.Fill(this.dS.SP_LAY_HOTEN_SV, txtMaSV.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
           // try
           // {
           //     this.sP_LAY_DS_HOCPHI_1SVTableAdapter.Fill(this.dS.SP_LAY_DS_HOCPHI_1SV, mASVToolStripTextBox.Text);
           // }
          //  catch (System.Exception ex)
          //  {
           //     System.Windows.Forms.MessageBox.Show(ex.Message);
          //  }

        }

        private void btnInDS_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sP_LAY_HOTEN_SVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_HOTEN_SVTableAdapter.Fill(this.dS.SP_LAY_HOTEN_SV, txtMaSV.Text);
                this.sP_LAY_DS_HOCPHI_1SVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_DS_HOCPHI_1SVTableAdapter.Fill(this.dS.SP_LAY_DS_HOCPHI_1SV, txtMaSV.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
           // try
            //{
                //this.sP_LAY_DS_CT_DHP_SVTableAdapter.Fill(this.dS.SP_LAY_DS_CT_DHP_SV, mASVToolStripTextBox.Text, nIENKHOAToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hOCKYToolStripTextBox.Text, typeof(int))))));
           // }
            //catch (System.Exception ex)
          //  {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void btnDongHocPhi_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_LAY_DS_CT_DHP_SVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_DS_CT_DHP_SVTableAdapter.Fill(this.dS.SP_LAY_DS_CT_DHP_SV, txtMaSV.Text,
                               gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NIENKHOA").ToString(),
                               int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOCKY").ToString()) );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sOTIENDONGSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sP_LAY_DS_CT_DHP_SVGridControl_Click(object sender, EventArgs e)
        {

        }

        private void from_DongHocPhi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            cmbNienKhoa.Enabled = cmbHocKy.Enabled = seHocPhi.Enabled = btnThem.Enabled =  false;
            seSoTienDong.Enabled = btnDong.Enabled = false;
        }

        private void btnThemHocPhi_Click(object sender, EventArgs e)
        {
            cmbNienKhoa.Enabled = cmbHocKy.Enabled = seHocPhi.Enabled = btnThem.Enabled = true;
            this.sP_LAY_DS_HOCPHI_1SVBindingSource.AddNew();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                String strlenh = "EXEC SP_INSERT_HOCPHI_SV '" + txtMaSV.Text + "','" + cmbNienKhoa.Text + "','" +int.Parse(cmbHocKy.Text) + "','" + int.Parse(seHocPhi.Text) +"'";
                Program.ExecSqlNonQuery(strlenh);
                this.sP_LAY_DS_HOCPHI_1SVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_DS_HOCPHI_1SVTableAdapter.Fill(this.dS.SP_LAY_DS_HOCPHI_1SV, txtMaSV.Text);
                MessageBox.Show("Thêm thành công!!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            cmbNienKhoa.Enabled = cmbHocKy.Enabled = seHocPhi.Enabled = btnThem.Enabled = false;
        }

        private void btnDongHP_Click(object sender, EventArgs e)
        {
            seSoTienDong.Enabled = btnDong.Enabled = true;
            seSoTienDong.Value = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOTIENCANDONG").ToString());
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if(int.Parse(seSoTienDong.Text) <= 0)
            {
                MessageBox.Show("Đóng học phí không thành công, Số tiền đóng phải lớn hơn 0 ", "", MessageBoxButtons.OK);
                return;
                seSoTienDong.Focus();
            }
            try
            {
                String strlenh = "EXEC SP_INSERT_CT_DHP_SV '" + txtMaSV.Text + "','" + cmbNienKhoa.Text + "','" + int.Parse(cmbHocKy.Text) + "','" + int.Parse(seSoTienDong.Text) + "'";
                Program.ExecSqlNonQuery(strlenh);
                this.sP_LAY_DS_CT_DHP_SVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_DS_CT_DHP_SVTableAdapter.Fill(this.dS.SP_LAY_DS_CT_DHP_SV, txtMaSV.Text,
                               gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NIENKHOA").ToString(),
                               int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOCKY").ToString()));
                this.sP_LAY_DS_HOCPHI_1SVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_DS_HOCPHI_1SVTableAdapter.Fill(this.dS.SP_LAY_DS_HOCPHI_1SV, txtMaSV.Text);
                MessageBox.Show("Bạn đã đóng học phí thành công!!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            seSoTienDong.Enabled = btnDong.Enabled = false;
        }
    }
}
