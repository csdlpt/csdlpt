
namespace QLDSV_TC
{
    partial class frmDky_LopTinChi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuyDangKy = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnInDS = new System.Windows.Forms.Button();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcDSMH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sP_LAY_DS_MONHOC_NKHKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_TC.DS();
            this.sP_LAY_DS_MONHOC_NKHKTableAdapter = new QLDSV_TC.DSTableAdapters.SP_LAY_DS_MONHOC_NKHKTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_LAY_DS_MONHOC_DADKY_NKHKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYDANGKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_LAY_DS_MONHOC_DADKY_NKHKTableAdapter = new QLDSV_TC.DSTableAdapters.SP_LAY_DS_MONHOC_DADKY_NKHKTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.mASVToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mASVToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nIENKHOAToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nIENKHOAToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.hOCKYToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.hOCKYToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DS_MONHOC_NKHKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DS_MONHOC_DADKY_NKHKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuyDangKy);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Controls.Add(this.btnInDS);
            this.panel1.Controls.Add(this.cmbHocKy);
            this.panel1.Controls.Add(this.cmbNienKhoa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.txtMasv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.Location = new System.Drawing.Point(1246, 13);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(112, 27);
            this.btnHuyDangKy.TabIndex = 6;
            this.btnHuyDangKy.Text = "Hủy Đăng Ký";
            this.btnHuyDangKy.UseVisualStyleBackColor = true;
            this.btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(1134, 13);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(87, 27);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnInDS
            // 
            this.btnInDS.Location = new System.Drawing.Point(955, 12);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(145, 28);
            this.btnInDS.TabIndex = 4;
            this.btnInDS.Text = "In danh sách môn học";
            this.btnInDS.UseVisualStyleBackColor = true;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbHocKy.Location = new System.Drawing.Point(850, 12);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(68, 25);
            this.cmbHocKy.TabIndex = 3;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.Location = new System.Drawing.Point(659, 13);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNienKhoa.Properties.Appearance.Options.UseFont = true;
            this.cmbNienKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNienKhoa.Properties.Items.AddRange(new object[] {
            "2021-2022",
            "2022-2023",
            "2023-2024",
            "2024-2025",
            "2025-2026",
            "2026-2027",
            "2027-2028",
            "2028-2029"});
            this.cmbNienKhoa.Size = new System.Drawing.Size(100, 24);
            this.cmbNienKhoa.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(789, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Học Kỳ";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Niên Khóa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(355, 12);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(199, 25);
            this.txtHoTen.TabIndex = 0;
            // 
            // txtMasv
            // 
            this.txtMasv.Enabled = false;
            this.txtMasv.Location = new System.Drawing.Point(107, 13);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(160, 25);
            this.txtMasv.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.gcDSMH);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 62);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1370, 207);
            this.panelControl1.TabIndex = 1;
            // 
            // gcDSMH
            // 
            this.gcDSMH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDSMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcDSMH.Location = new System.Drawing.Point(2, 2);
            this.gcDSMH.MainView = this.gridView1;
            this.gcDSMH.Name = "gcDSMH";
            this.gcDSMH.Size = new System.Drawing.Size(1366, 200);
            this.gcDSMH.TabIndex = 0;
            this.gcDSMH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcDSMH;
            this.gridView1.Name = "gridView1";
            // 
            // sP_LAY_DS_MONHOC_NKHKBindingSource
            // 
            this.sP_LAY_DS_MONHOC_NKHKBindingSource.DataMember = "SP_LAY_DS_MONHOC_NKHK";
            this.sP_LAY_DS_MONHOC_NKHKBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_LAY_DS_MONHOC_NKHKTableAdapter
            // 
            this.sP_LAY_DS_MONHOC_NKHKTableAdapter.ClearBeforeFill = true;
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
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 269);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1370, 27);
            this.panelControl2.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.label6);
            this.panelControl3.Controls.Add(this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 296);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1370, 366);
            this.panelControl3.TabIndex = 3;
            // 
            // sP_LAY_DS_MONHOC_DADKY_NKHKGridControl
            // 
            this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl.DataSource = this.sP_LAY_DS_MONHOC_DADKY_NKHKBindingSource;
            this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl.Location = new System.Drawing.Point(2, 2);
            this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl.MainView = this.gridView2;
            this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl.Name = "sP_LAY_DS_MONHOC_DADKY_NKHKGridControl";
            this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl.Size = new System.Drawing.Size(1366, 300);
            this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl.TabIndex = 0;
            this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // sP_LAY_DS_MONHOC_DADKY_NKHKBindingSource
            // 
            this.sP_LAY_DS_MONHOC_DADKY_NKHKBindingSource.DataMember = "SP_LAY_DS_MONHOC_DADKY_NKHK";
            this.sP_LAY_DS_MONHOC_DADKY_NKHKBindingSource.DataSource = this.dS;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colMAMH,
            this.colTENMH,
            this.colTENGV,
            this.colNHOM,
            this.colHUYDANGKY});
            this.gridView2.GridControl = this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMALTC
            // 
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.OptionsColumn.ReadOnly = true;
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 4;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.ReadOnly = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.ReadOnly = true;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colTENGV
            // 
            this.colTENGV.FieldName = "TENGV";
            this.colTENGV.Name = "colTENGV";
            this.colTENGV.OptionsColumn.ReadOnly = true;
            this.colTENGV.Visible = true;
            this.colTENGV.VisibleIndex = 2;
            // 
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.OptionsColumn.ReadOnly = true;
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 3;
            // 
            // colHUYDANGKY
            // 
            this.colHUYDANGKY.FieldName = "HUYDANGKY";
            this.colHUYDANGKY.Name = "colHUYDANGKY";
            this.colHUYDANGKY.OptionsColumn.ReadOnly = true;
            // 
            // sP_LAY_DS_MONHOC_DADKY_NKHKTableAdapter
            // 
            this.sP_LAY_DS_MONHOC_DADKY_NKHKTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mASVToolStripLabel,
            this.mASVToolStripTextBox,
            this.nIENKHOAToolStripLabel,
            this.nIENKHOAToolStripTextBox,
            this.hOCKYToolStripLabel,
            this.hOCKYToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 662);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1370, 25);
            this.fillToolStrip.TabIndex = 4;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // mASVToolStripLabel
            // 
            this.mASVToolStripLabel.Name = "mASVToolStripLabel";
            this.mASVToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.mASVToolStripLabel.Text = "MASV:";
            // 
            // mASVToolStripTextBox
            // 
            this.mASVToolStripTextBox.Name = "mASVToolStripTextBox";
            this.mASVToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // nIENKHOAToolStripLabel
            // 
            this.nIENKHOAToolStripLabel.Name = "nIENKHOAToolStripLabel";
            this.nIENKHOAToolStripLabel.Size = new System.Drawing.Size(70, 22);
            this.nIENKHOAToolStripLabel.Text = "NIENKHOA:";
            // 
            // nIENKHOAToolStripTextBox
            // 
            this.nIENKHOAToolStripTextBox.Name = "nIENKHOAToolStripTextBox";
            this.nIENKHOAToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // hOCKYToolStripLabel
            // 
            this.hOCKYToolStripLabel.Name = "hOCKYToolStripLabel";
            this.hOCKYToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.hOCKYToolStripLabel.Text = "HOCKY:";
            // 
            // hOCKYToolStripTextBox
            // 
            this.hOCKYToolStripTextBox.Name = "hOCKYToolStripTextBox";
            this.hOCKYToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Danh Sách Môn Học Mở Trong Học Kỳ ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Danh Sách Môn Học Đã Đăng Ký";
            // 
            // frmDky_LopTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 610);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDky_LopTinChi";
            this.Text = "frmDky_LopTinChi";
            this.Load += new System.EventHandler(this.frmDky_LopTinChi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DS_MONHOC_NKHKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DS_MONHOC_DADKY_NKHKGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DS_MONHOC_DADKY_NKHKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private DevExpress.XtraEditors.ComboBoxEdit cmbNienKhoa;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DS dS;
        private System.Windows.Forms.BindingSource sP_LAY_DS_MONHOC_NKHKBindingSource;
        private DSTableAdapters.SP_LAY_DS_MONHOC_NKHKTableAdapter sP_LAY_DS_MONHOC_NKHKTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDSMH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.BindingSource sP_LAY_DS_MONHOC_DADKY_NKHKBindingSource;
        private DSTableAdapters.SP_LAY_DS_MONHOC_DADKY_NKHKTableAdapter sP_LAY_DS_MONHOC_DADKY_NKHKTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel mASVToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox mASVToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nIENKHOAToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nIENKHOAToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel hOCKYToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox hOCKYToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuyDangKy;
        private DevExpress.XtraGrid.GridControl sP_LAY_DS_MONHOC_DADKY_NKHKGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENGV;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYDANGKY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}