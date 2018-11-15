namespace SiftingData
{
    partial class FormBaseInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components . Dispose ( );
            }
            base . Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtTime = new DevExpress.XtraEditors.DateEdit();
            this.txtBAS003 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtBAS006 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BAS001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAS002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAS003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.U0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAS004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAS005 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAS006 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAS007 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAS008 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAS009 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBAS003.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBAS006.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 24);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1232, 413);
            this.splitContainerControl1.SplitterPosition = 44;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtTime);
            this.layoutControl1.Controls.Add(this.txtBAS003);
            this.layoutControl1.Controls.Add(this.txtBAS006);
            this.layoutControl1.Controls.Add(this.btnClear);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1232, 44);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtTime
            // 
            this.txtTime.EditValue = null;
            this.txtTime.Location = new System.Drawing.Point(71, 12);
            this.txtTime.MenuManager = this.barManager1;
            this.txtTime.Name = "txtTime";
            this.txtTime.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txtTime.Properties.Appearance.Options.UseFont = true;
            this.txtTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTime.Properties.DisplayFormat.FormatString = "yyyyMMdd";
            this.txtTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTime.Properties.EditFormat.FormatString = "yyyyMMdd";
            this.txtTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTime.Properties.Mask.EditMask = "yyyyMMdd";
            this.txtTime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTime.Size = new System.Drawing.Size(116, 20);
            this.txtTime.StyleController = this.layoutControl1;
            this.txtTime.TabIndex = 4;
            // 
            // txtBAS003
            // 
            this.txtBAS003.Location = new System.Drawing.Point(250, 12);
            this.txtBAS003.MenuManager = this.barManager1;
            this.txtBAS003.Name = "txtBAS003";
            this.txtBAS003.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txtBAS003.Properties.Appearance.Options.UseFont = true;
            this.txtBAS003.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtBAS003.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBAS003.Properties.ImmediatePopup = true;
            this.txtBAS003.Properties.NullText = "";
            this.txtBAS003.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtBAS003.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtBAS003.Properties.View = this.gridLookUpEdit1View;
            this.txtBAS003.Size = new System.Drawing.Size(332, 20);
            this.txtBAS003.StyleController = this.layoutControl1;
            this.txtBAS003.TabIndex = 5;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "物料代码";
            this.gridColumn1.FieldName = "BAS003";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // txtBAS006
            // 
            this.txtBAS006.Location = new System.Drawing.Point(645, 12);
            this.txtBAS006.MenuManager = this.barManager1;
            this.txtBAS006.Name = "txtBAS006";
            this.txtBAS006.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txtBAS006.Properties.Appearance.Options.UseFont = true;
            this.txtBAS006.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtBAS006.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBAS006.Properties.ImmediatePopup = true;
            this.txtBAS006.Properties.NullText = "";
            this.txtBAS006.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtBAS006.Properties.PopupSizeable = false;
            this.txtBAS006.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtBAS006.Properties.View = this.gridView2;
            this.txtBAS006.Size = new System.Drawing.Size(413, 20);
            this.txtBAS006.StyleController = this.layoutControl1;
            this.txtBAS006.TabIndex = 6;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "物料描述";
            this.gridColumn2.FieldName = "BAS006";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1215, 46);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtTime;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(179, 26);
            this.layoutControlItem1.Text = "日期";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(56, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtBAS003;
            this.layoutControlItem2.Location = new System.Drawing.Point(179, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(395, 26);
            this.layoutControlItem2.Text = "物料代码";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(56, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("宋体", 10.5F);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.txtBAS006;
            this.layoutControlItem3.Location = new System.Drawing.Point(574, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(476, 26);
            this.layoutControlItem3.Text = "物料描述";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(56, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(1050, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(29, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1232, 364);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControl1_KeyPress);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BAS001,
            this.BAS002,
            this.BAS003,
            this.U0,
            this.BAS004,
            this.BAS005,
            this.BAS006,
            this.BAS007,
            this.BAS008,
            this.BAS009,
            this.idx});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // BAS001
            // 
            this.BAS001.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS001.AppearanceCell.Options.UseFont = true;
            this.BAS001.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS001.AppearanceHeader.Options.UseFont = true;
            this.BAS001.Caption = "日期";
            this.BAS001.FieldName = "BAS001";
            this.BAS001.Name = "BAS001";
            this.BAS001.OptionsColumn.AllowEdit = false;
            this.BAS001.Visible = true;
            this.BAS001.VisibleIndex = 0;
            this.BAS001.Width = 84;
            // 
            // BAS002
            // 
            this.BAS002.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS002.AppearanceCell.Options.UseFont = true;
            this.BAS002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS002.AppearanceHeader.Options.UseFont = true;
            this.BAS002.Caption = "前缀1";
            this.BAS002.FieldName = "BAS002";
            this.BAS002.Name = "BAS002";
            this.BAS002.Visible = true;
            this.BAS002.VisibleIndex = 1;
            this.BAS002.Width = 60;
            // 
            // BAS003
            // 
            this.BAS003.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS003.AppearanceCell.Options.UseFont = true;
            this.BAS003.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS003.AppearanceHeader.Options.UseFont = true;
            this.BAS003.Caption = "物料代码";
            this.BAS003.FieldName = "BAS003";
            this.BAS003.Name = "BAS003";
            this.BAS003.Visible = true;
            this.BAS003.VisibleIndex = 2;
            this.BAS003.Width = 123;
            // 
            // U0
            // 
            this.U0.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.U0.AppearanceCell.Options.UseFont = true;
            this.U0.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.U0.AppearanceHeader.Options.UseFont = true;
            this.U0.Caption = "物料代码合并";
            this.U0.FieldName = "U0";
            this.U0.Name = "U0";
            this.U0.OptionsColumn.AllowEdit = false;
            this.U0.ToolTip = "[前缀1] + [物料代码]";
            this.U0.UnboundExpression = "[BAS002] + [BAS003]";
            this.U0.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.U0.Visible = true;
            this.U0.VisibleIndex = 3;
            this.U0.Width = 121;
            // 
            // BAS004
            // 
            this.BAS004.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS004.AppearanceCell.Options.UseFont = true;
            this.BAS004.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS004.AppearanceHeader.Options.UseFont = true;
            this.BAS004.Caption = "后缀1_1";
            this.BAS004.FieldName = "BAS004";
            this.BAS004.Name = "BAS004";
            this.BAS004.Visible = true;
            this.BAS004.VisibleIndex = 4;
            this.BAS004.Width = 70;
            // 
            // BAS005
            // 
            this.BAS005.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS005.AppearanceCell.Options.UseFont = true;
            this.BAS005.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS005.AppearanceHeader.Options.UseFont = true;
            this.BAS005.Caption = "后缀1_2";
            this.BAS005.FieldName = "BAS005";
            this.BAS005.Name = "BAS005";
            this.BAS005.Visible = true;
            this.BAS005.VisibleIndex = 5;
            this.BAS005.Width = 62;
            // 
            // BAS006
            // 
            this.BAS006.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS006.AppearanceCell.Options.UseFont = true;
            this.BAS006.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS006.AppearanceHeader.Options.UseFont = true;
            this.BAS006.Caption = "物料描述";
            this.BAS006.FieldName = "BAS006";
            this.BAS006.Name = "BAS006";
            this.BAS006.Visible = true;
            this.BAS006.VisibleIndex = 6;
            this.BAS006.Width = 291;
            // 
            // BAS007
            // 
            this.BAS007.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS007.AppearanceCell.Options.UseFont = true;
            this.BAS007.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS007.AppearanceHeader.Options.UseFont = true;
            this.BAS007.Caption = "后缀2_1";
            this.BAS007.FieldName = "BAS007";
            this.BAS007.Name = "BAS007";
            this.BAS007.Visible = true;
            this.BAS007.VisibleIndex = 7;
            this.BAS007.Width = 96;
            // 
            // BAS008
            // 
            this.BAS008.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS008.AppearanceCell.Options.UseFont = true;
            this.BAS008.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS008.AppearanceHeader.Options.UseFont = true;
            this.BAS008.Caption = "后缀2_2";
            this.BAS008.FieldName = "BAS008";
            this.BAS008.Name = "BAS008";
            this.BAS008.Visible = true;
            this.BAS008.VisibleIndex = 8;
            this.BAS008.Width = 82;
            // 
            // BAS009
            // 
            this.BAS009.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS009.AppearanceCell.Options.UseFont = true;
            this.BAS009.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BAS009.AppearanceHeader.Options.UseFont = true;
            this.BAS009.Caption = "后缀2_3";
            this.BAS009.FieldName = "BAS009";
            this.BAS009.Name = "BAS009";
            this.BAS009.Visible = true;
            this.BAS009.VisibleIndex = 9;
            this.BAS009.Width = 89;
            // 
            // idx
            // 
            this.idx.Caption = "编号";
            this.idx.FieldName = "idx";
            this.idx.Name = "idx";
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(1091, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 22);
            this.btnClear.StyleController = this.layoutControl1;
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnClear;
            this.layoutControlItem4.Location = new System.Drawing.Point(1079, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(58, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(1137, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(58, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormBaseInfo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 437);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormBaseInfo";
            this.Text = "基础资料";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBAS003.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBAS006.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress . XtraEditors . SplitContainerControl splitContainerControl1;
        private DevExpress . XtraGrid . GridControl gridControl1;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView1;
        private DevExpress . XtraLayout . LayoutControl layoutControl1;
        private DevExpress . XtraLayout . LayoutControlGroup layoutControlGroup1;
        private DevExpress . XtraLayout . LayoutControlItem layoutControlItem1;
        private DevExpress . XtraLayout . EmptySpaceItem emptySpaceItem1;
        private DevExpress . XtraEditors . DateEdit txtTime;
        private DevExpress . XtraGrid . Columns . GridColumn BAS002;
        private DevExpress . XtraGrid . Columns . GridColumn BAS003;
        private DevExpress . XtraGrid . Columns . GridColumn U0;
        private DevExpress . XtraGrid . Columns . GridColumn BAS004;
        private DevExpress . XtraGrid . Columns . GridColumn BAS005;
        private DevExpress . XtraGrid . Columns . GridColumn BAS006;
        private DevExpress . XtraGrid . Columns . GridColumn BAS007;
        private DevExpress . XtraGrid . Columns . GridColumn BAS008;
        private DevExpress . XtraGrid . Columns . GridColumn BAS009;
        private DevExpress . XtraGrid . Columns . GridColumn idx;
        private DevExpress . XtraGrid . Columns . GridColumn BAS001;
        private DevExpress . XtraLayout . LayoutControlItem layoutControlItem2;
        private DevExpress . XtraEditors . GridLookUpEdit txtBAS003;
        private DevExpress . XtraGrid . Views . Grid . GridView gridLookUpEdit1View;
        private DevExpress . XtraLayout . LayoutControlItem layoutControlItem3;
        private DevExpress . XtraEditors . GridLookUpEdit txtBAS006;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView2;
        private DevExpress . XtraGrid . Columns . GridColumn gridColumn1;
        private DevExpress . XtraGrid . Columns . GridColumn gridColumn2;
        private DevExpress . XtraEditors . SimpleButton btnClear;
        private DevExpress . XtraLayout . LayoutControlItem layoutControlItem4;
        private DevExpress . XtraLayout . EmptySpaceItem emptySpaceItem2;
    }
}