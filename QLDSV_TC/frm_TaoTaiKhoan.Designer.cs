
namespace QLDSV_TC
{
    partial class frm_TaoTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hO_TENLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTaoTaoKhoan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rbPGV = new System.Windows.Forms.RadioButton();
            this.rbKHOA = new System.Windows.Forms.RadioButton();
            this.rbPKT = new System.Windows.Forms.RadioButton();
            this.dS = new QLDSV_TC.DS();
            this.v_GETDSGVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_GETDSGVTableAdapter = new QLDSV_TC.DSTableAdapters.V_GETDSGVTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.hO_TENComboBox = new System.Windows.Forms.ComboBox();
            mAGVLabel = new System.Windows.Forms.Label();
            hO_TENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_GETDSGVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGVLabel.Location = new System.Drawing.Point(580, 252);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(69, 21);
            mAGVLabel.TabIndex = 16;
            mAGVLabel.Text = "MAGV:";
            mAGVLabel.Click += new System.EventHandler(this.mAGVLabel_Click);
            // 
            // hO_TENLabel
            // 
            hO_TENLabel.AutoSize = true;
            hO_TENLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hO_TENLabel.Location = new System.Drawing.Point(175, 252);
            hO_TENLabel.Name = "hO_TENLabel";
            hO_TENLabel.Size = new System.Drawing.Size(89, 21);
            hO_TENLabel.TabIndex = 17;
            hO_TENLabel.Text = "Giảng viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(175, 114);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(53, 21);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Role";
            // 
            // btnTaoTaoKhoan
            // 
            this.btnTaoTaoKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTaoKhoan.Location = new System.Drawing.Point(246, 357);
            this.btnTaoTaoKhoan.Name = "btnTaoTaoKhoan";
            this.btnTaoTaoKhoan.Size = new System.Drawing.Size(123, 41);
            this.btnTaoTaoKhoan.TabIndex = 5;
            this.btnTaoTaoKhoan.Text = "Tạo tài khoản";
            this.btnTaoTaoKhoan.UseVisualStyleBackColor = true;
            this.btnTaoTaoKhoan.Click += new System.EventHandler(this.btnTaoTaoKhoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(458, 357);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 41);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(300, 111);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(266, 29);
            this.txtLogin.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(300, 182);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(266, 29);
            this.txtPassword.TabIndex = 8;
            // 
            // rbPGV
            // 
            this.rbPGV.AutoSize = true;
            this.rbPGV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPGV.Location = new System.Drawing.Point(300, 313);
            this.rbPGV.Name = "rbPGV";
            this.rbPGV.Size = new System.Drawing.Size(66, 25);
            this.rbPGV.TabIndex = 10;
            this.rbPGV.TabStop = true;
            this.rbPGV.Text = "PGV";
            this.rbPGV.UseVisualStyleBackColor = true;
            // 
            // rbKHOA
            // 
            this.rbKHOA.AutoSize = true;
            this.rbKHOA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKHOA.Location = new System.Drawing.Point(398, 315);
            this.rbKHOA.Name = "rbKHOA";
            this.rbKHOA.Size = new System.Drawing.Size(81, 25);
            this.rbKHOA.TabIndex = 11;
            this.rbKHOA.TabStop = true;
            this.rbKHOA.Text = "KHOA";
            this.rbKHOA.UseVisualStyleBackColor = true;
            // 
            // rbPKT
            // 
            this.rbPKT.AutoSize = true;
            this.rbPKT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPKT.Location = new System.Drawing.Point(517, 313);
            this.rbPKT.Name = "rbPKT";
            this.rbPKT.Size = new System.Drawing.Size(64, 25);
            this.rbPKT.TabIndex = 13;
            this.rbPKT.TabStop = true;
            this.rbPKT.Text = "PKT";
            this.rbPKT.UseVisualStyleBackColor = true;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_GETDSGVBindingSource
            // 
            this.v_GETDSGVBindingSource.DataMember = "V_GETDSGV";
            this.v_GETDSGVBindingSource.DataSource = this.dS;
            // 
            // v_GETDSGVTableAdapter
            // 
            this.v_GETDSGVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_GETDSGVBindingSource, "MAGV", true));
            this.txtMaGV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.Location = new System.Drawing.Point(655, 249);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(100, 29);
            this.txtMaGV.TabIndex = 17;
            this.txtMaGV.TextChanged += new System.EventHandler(this.mAGVTextBox_TextChanged);
            // 
            // hO_TENComboBox
            // 
            this.hO_TENComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_GETDSGVBindingSource, "HO TEN", true));
            this.hO_TENComboBox.DataSource = this.v_GETDSGVBindingSource;
            this.hO_TENComboBox.DisplayMember = "HO TEN";
            this.hO_TENComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hO_TENComboBox.FormattingEnabled = true;
            this.hO_TENComboBox.Location = new System.Drawing.Point(300, 249);
            this.hO_TENComboBox.Name = "hO_TENComboBox";
            this.hO_TENComboBox.Size = new System.Drawing.Size(266, 29);
            this.hO_TENComboBox.TabIndex = 18;
            this.hO_TENComboBox.ValueMember = "MAGV";
            // 
            // frm_TaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(hO_TENLabel);
            this.Controls.Add(this.hO_TENComboBox);
            this.Controls.Add(mAGVLabel);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.rbPKT);
            this.Controls.Add(this.rbKHOA);
            this.Controls.Add(this.rbPGV);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoTaoKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Name = "frm_TaoTaiKhoan";
            this.Text = "frm_TaoTaiKhoan";
            this.Load += new System.EventHandler(this.frm_TaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_GETDSGVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTaoTaoKhoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rbPGV;
        private System.Windows.Forms.RadioButton rbKHOA;
        private System.Windows.Forms.RadioButton rbPKT;
        private DS dS;
        private System.Windows.Forms.BindingSource v_GETDSGVBindingSource;
        private DSTableAdapters.V_GETDSGVTableAdapter v_GETDSGVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.ComboBox hO_TENComboBox;
    }
}