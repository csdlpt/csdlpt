
namespace QLDSV_TC
{
    partial class frm_Report_BDTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Report_BDTK));
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label kHOAHOCLabel;
            System.Windows.Forms.Label tENKHOALabel;
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnInDS = new System.Windows.Forms.Button();
            this.dS = new QLDSV_TC.DS();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV_TC.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.lOPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lOPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.cmbMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtKhoaHoc = new DevExpress.XtraEditors.TextEdit();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new QLDSV_TC.DSTableAdapters.KHOATableAdapter();
            this.txtTenKhoa = new DevExpress.XtraEditors.TextEdit();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            kHOAHOCLabel = new System.Windows.Forms.Label();
            tENKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingNavigator)).BeginInit();
            this.lOPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Khoa";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(142, 54);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(392, 25);
            this.cmbChiNhanh.TabIndex = 6;
            // 
            // btnInDS
            // 
            this.btnInDS.Location = new System.Drawing.Point(74, 321);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(125, 35);
            this.btnInDS.TabIndex = 8;
            this.btnInDS.Text = "In Danh Sách";
            this.btnInDS.UseVisualStyleBackColor = true;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPBindingNavigator
            // 
            this.lOPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lOPBindingNavigator.BindingSource = this.lOPBindingSource;
            this.lOPBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lOPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lOPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.lOPBindingNavigatorSaveItem});
            this.lOPBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lOPBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lOPBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lOPBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lOPBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lOPBindingNavigator.Name = "lOPBindingNavigator";
            this.lOPBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lOPBindingNavigator.Size = new System.Drawing.Size(1067, 25);
            this.lOPBindingNavigator.TabIndex = 9;
            this.lOPBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // lOPBindingNavigatorSaveItem
            // 
            this.lOPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lOPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lOPBindingNavigatorSaveItem.Image")));
            this.lOPBindingNavigatorSaveItem.Name = "lOPBindingNavigatorSaveItem";
            this.lOPBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lOPBindingNavigatorSaveItem.Text = "Save Data";
            this.lOPBindingNavigatorSaveItem.Click += new System.EventHandler(this.lOPBindingNavigatorSaveItem_Click);
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(31, 112);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(56, 17);
            mALOPLabel.TabIndex = 9;
            mALOPLabel.Text = "Mã Lớp";
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.cmbMaLop.DataSource = this.lOPBindingSource;
            this.cmbMaLop.DisplayMember = "MALOP";
            this.cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(142, 112);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(155, 25);
            this.cmbMaLop.TabIndex = 10;
            this.cmbMaLop.ValueMember = "MALOP";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(31, 169);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(62, 17);
            tENLOPLabel.TabIndex = 10;
            tENLOPLabel.Text = "Tên Lớp:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "TENLOP", true));
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Location = new System.Drawing.Point(142, 168);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(233, 20);
            this.txtTenLop.TabIndex = 11;
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(585, 62);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(64, 17);
            mAKHOALabel.TabIndex = 11;
            mAKHOALabel.Text = "Mã Khoa";
            // 
            // cmbMaKhoa
            // 
            this.cmbMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "MAKHOA", true));
            this.cmbMaKhoa.Enabled = false;
            this.cmbMaKhoa.Location = new System.Drawing.Point(670, 59);
            this.cmbMaKhoa.Name = "cmbMaKhoa";
            this.cmbMaKhoa.Size = new System.Drawing.Size(100, 20);
            this.cmbMaKhoa.TabIndex = 12;
            // 
            // kHOAHOCLabel
            // 
            kHOAHOCLabel.AutoSize = true;
            kHOAHOCLabel.Location = new System.Drawing.Point(31, 216);
            kHOAHOCLabel.Name = "kHOAHOCLabel";
            kHOAHOCLabel.Size = new System.Drawing.Size(69, 17);
            kHOAHOCLabel.TabIndex = 12;
            kHOAHOCLabel.Text = "Khóa Học";
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "KHOAHOC", true));
            this.txtKhoaHoc.Enabled = false;
            this.txtKhoaHoc.Location = new System.Drawing.Point(142, 213);
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(155, 20);
            this.txtKhoaHoc.TabIndex = 13;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dS;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tENKHOALabel
            // 
            tENKHOALabel.AutoSize = true;
            tENKHOALabel.Location = new System.Drawing.Point(580, 114);
            tENKHOALabel.Name = "tENKHOALabel";
            tENKHOALabel.Size = new System.Drawing.Size(62, 17);
            tENKHOALabel.TabIndex = 13;
            tENKHOALabel.Text = "TenKhoa";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHOABindingSource, "TENKHOA", true));
            this.txtTenKhoa.Location = new System.Drawing.Point(670, 111);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtTenKhoa.Size = new System.Drawing.Size(227, 24);
            this.txtTenKhoa.TabIndex = 14;
            // 
            // frm_Report_BDTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(tENKHOALabel);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(kHOAHOCLabel);
            this.Controls.Add(this.txtKhoaHoc);
            this.Controls.Add(mAKHOALabel);
            this.Controls.Add(this.cmbMaKhoa);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.cmbMaLop);
            this.Controls.Add(this.lOPBindingNavigator);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChiNhanh);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Report_BDTK";
            this.Text = "frm_Report_BDTK";
            this.Load += new System.EventHandler(this.frm_Report_BDTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingNavigator)).EndInit();
            this.lOPBindingNavigator.ResumeLayout(false);
            this.lOPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Button btnInDS;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lOPBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton lOPBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.TextEdit cmbMaKhoa;
        private DevExpress.XtraEditors.TextEdit txtKhoaHoc;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DevExpress.XtraEditors.TextEdit txtTenKhoa;
    }
}