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
    public partial class frm_TaoTaiKhoan : Form
    {
        public frm_TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
            else return;
        }

        private void frm_TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_GETDSGV' table. You can move, or remove it, as needed.
            this.v_GETDSGVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_GETDSGVTableAdapter.Fill(this.dS.V_GETDSGV);
            if(Program.mGroup == "PGV") {
                rbPKT.Enabled = false;
            }
            if(Program.mGroup == "KHOA")
            {
                rbPKT.Enabled = rbPGV.Enabled = false;
            }
            if(Program.mGroup == "PKT")
            {
                rbKHOA.Enabled = rbPGV.Enabled = false;
            }

        }

        private void mAGVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mAGVLabel_Click(object sender, EventArgs e)
        {

        }

        private void hO_TENTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTaoTaoKhoan_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Login name không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nLogin = txtLogin.Text.Trim();
            string nPassword = txtPassword.Text.Trim();
            string nUser = txtMaGV.Text.Trim();
            string role = "";
            if (rbPGV.Checked == true)
            {
                role = "PGV";
            }
            else if (rbKHOA.Checked == true)
            {
                role = "KHOA";
            }
            else if (rbPKT.Checked == true)
            {
                role = "PKT";
            }
            if (rbPGV.Checked == false && rbKHOA.Checked == false && rbPKT.Checked == false)
            {
                MessageBox.Show("Chưa chọn role", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                string strLenh = " declare @res int " +
                    "EXEC @res = SP_TaoTaiKhoan '" + nLogin + "','" + nPassword + "','"+ nUser + "','" + role + "'"+
                    " select KETQUA = @res";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
            } catch(Exception ex)
            {
                if (ex.Message.Contains("server principal"))
                {
                    MessageBox.Show("Login name bị trùng. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else if (ex.Message.Contains("User, group, or role"))
                {
                    MessageBox.Show("Giảng viên này đã được tạo login. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

        }
    }
}
