using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace QLDSV_TC
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = "Data Source=DESKTOP-NLR9NQP\\SERVER;Initial Catalog=" + Program.database + ";Integrated Security=True";
            Program.conn.ConnectionString = chuoiketnoi;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cmbChiNhanh.DataSource = dt;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = -1;
            cmbChiNhanh.SelectedIndex = 0;
            rbtnGiaoVien.Checked = true;

        }
        private void rbtnSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnSinhVien.Checked == true)
            {
                cmbChiNhanh.Enabled = false;
            }
        }

       

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult choose;
            choose = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Có", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choose == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (rbtnGiaoVien.Checked == true)
            {
                if (txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập, mật khẩu không được để trống!!!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mlogin = txtLogin.Text;
                Program.password = txtPassword.Text;
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
                if (Program.KetNoi() == 0) return;
                Program.mChinhanh = cmbChiNhanh.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
               
                String strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Tài khoản của bạn không có quyền truy cập vào hệ thống!!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();

                Program.frmChinh = new frmMain();
                Program.frmChinh.Activate();
                Program.frmChinh.Show();
                Program.frmDN.Visible = false;

                if (Program.mGroup != "SINHVIEN")
                {
                    Program.frmChinh.MaSo.Text = "Mã: " + Program.username;
                    Program.frmChinh.HoTen.Text = "Họ và Tên: " + Program.mHoten;
                    Program.frmChinh.Nhom.Text = "Nhóm: " + Program.mGroup;
                }
            }
            else
            {
                if (txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập, mật khẩu không được để trống!!!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mlogin = "sinhvien";
                Program.password = txtPassword.Text;
                
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
                if (Program.KetNoi() == 0) return;
                Program.mChinhanh = cmbChiNhanh.SelectedIndex;
                Program.mloginDN = "sinhvien";
                Program.passwordDN = Program.password;

                String strLenh = "EXEC SP_DANGNHAP_SV '" + txtLogin.Text + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                try
                {
                    Program.mHoten = Program.myReader.GetString(0);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không tồn tại sinh viên này", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mGroup = "SV";
                Program.myReader.Close();
                Program.conn.Close();

                Program.frmChinh = new frmMain();
                Program.frmChinh.Activate();
                Program.frmChinh.Show();
                Program.frmDN.Visible = false;


                Program.frmChinh.MaSo.Text = "Mã: " + txtLogin.Text;
                Program.frmChinh.HoTen.Text = "Họ và Tên: " + Program.mHoten;
                Program.frmChinh.Nhom.Text = "Nhóm: " + Program.mGroup;

            }
            MessageBox.Show("Đăng nhập thành công!", "", MessageBoxButtons.OK);


            this.SetVisibleCore(false);
            Program.frmChinh.Activate();
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.Show();
        }
    }
}
