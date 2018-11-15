using System;
using System . Collections . Generic;
using System . Data;
using System . Windows . Forms;
using DevExpress . XtraEditors;

namespace SiftingData
{
    public partial class FormBaseInfo :FormChild
    {
        SiftingDataBll.Bll.BaseInfoBll _bll=null;
        SiftingDataEntity.BaseInfoEntity model=null;
        DataTable tableView,tableOnly;
        bool result=false;
        string strWhere="1=1";
        List<string> idxList=new List<string>();
        DateTime dtNow;
        
        public FormBaseInfo ( )
        {
            InitializeComponent ( );

            _bll = new SiftingDataBll . Bll . BaseInfoBll ( );

            barManager1 . Items . Remove ( toolExport );
            barManager1 . Items . Remove ( toolPrint );
            //barMenu . ItemLinks . RemoveAt ( toolExport . Id );
            //barMenu . ItemLinks . RemoveAt ( toolPrint . Id );

            gridView1 . OptionsBehavior . Editable = false;
            dtNow = _bll . getTimeNow ( );
            txtTime . Text = dtNow . ToString ( "yyyyMMdd" );

            tableOnly = _bll . getTableOnlyColumn ( );
            txtBAS003 . Properties . DataSource = tableOnly . DefaultView . ToTable ( true ,"BAS003" );
            txtBAS003 . Properties . DisplayMember = "BAS003";
            txtBAS003 . Properties . ValueMember = "BAS003";
            txtBAS006 . Properties . DataSource = tableOnly . DefaultView . ToTable ( true ,"BAS006" );
            txtBAS006 . Properties . DisplayMember = "BAS006";
            txtBAS006 . Properties . ValueMember = "BAS006";
        }

        protected override int Query ( )
        {
            strWhere = "1=1";
            if ( !string . IsNullOrEmpty ( txtTime . Text ) )
                strWhere += " AND BAS001='" + txtTime . Text + "'";
            if ( !string . IsNullOrEmpty ( txtBAS003 . Text ) )
                strWhere += " AND BAS003='" + txtBAS003 . Text + "'";
            if ( !string . IsNullOrEmpty ( txtBAS006 . Text ) )
                strWhere += " AND BAS006='" + txtBAS006 . Text + "'";

            tableView = _bll . getTableView ( strWhere );
            gridControl1 . DataSource = tableView;

            return base . Query ( );
        }
        protected override int Add ( )
        {
            if ( string . IsNullOrEmpty ( txtTime . Text ) )
            {
                XtraMessageBox . Show ( "请选择日期" );
                return 0;
            }
            strWhere = "1=1";
            if ( !string . IsNullOrEmpty ( txtTime . Text ) )
                strWhere += " AND BAS001='" + txtTime . Text + "'";

            tableView = _bll . getTableView ( strWhere );
            gridControl1 . DataSource = tableView;

            gridView1 . OptionsBehavior . Editable = true;
            addTool ( );

            return base . Add ( );
        }
        protected override int Edit ( )
        {
            gridView1 . OptionsBehavior . Editable = true;
            editTool ( );

            return base . Edit ( );
        }
        protected override int Delete ( )
        {
            if ( XtraMessageBox . Show ( "确认删除全部?" ,"删除" ,MessageBoxButtons . OKCancel ) != DialogResult . OK )
                return 0;

            gridView1 . CloseEditor ( );
            gridView1 . UpdateCurrentRow ( );

            result = _bll . Delete ( tableView );
            if ( result )
            {
                XtraMessageBox . Show ( "成功删除" );
                deleteTool ( );
                gridView1 . OptionsBehavior . Editable = false;
                gridControl1 . DataSource = null;
            }
            else
                XtraMessageBox . Show ( "删除失败" );

            return base . Delete ( );
        }
        protected override int Save ( )
        {
            gridView1 . CloseEditor ( );
            gridView1 . UpdateCurrentRow ( );

            result = _bll . Save ( tableView ,idxList );
            if ( result )
            {
                XtraMessageBox . Show ( "保存成功" );
                saveTool ( );
                gridView1 . OptionsBehavior . Editable = false;

                tableOnly = _bll . getTableOnlyColumn ( );
                txtBAS003 . Properties . DataSource = tableOnly . DefaultView . ToTable ( true ,"BAS003" );
                txtBAS003 . Properties . DisplayMember = "BAS003";
                txtBAS003 . Properties . ValueMember = "BAS003";
                txtBAS006 . Properties . DataSource = tableOnly . DefaultView . ToTable ( true ,"BAS006" );
                txtBAS006 . Properties . DisplayMember = "BAS006";
                txtBAS006 . Properties . ValueMember = "BAS006";
            }
            else
                XtraMessageBox . Show ( "保存失败" );

            return base . Save ( );
        }
        protected override int Cancel ( )
        {
            cancelTool ( "edit" );
            gridView1 . OptionsBehavior . Editable = false;

            return base . Cancel ( );
        }

        private void gridView1_InitNewRow ( object sender ,DevExpress . XtraGrid . Views . Grid . InitNewRowEventArgs e )
        {
            DevExpress . XtraGrid . Views . Grid . GridView view = sender as DevExpress . XtraGrid . Views . Grid . GridView;
            view . SetRowCellValue ( e . RowHandle ,view . Columns [ "BAS001" ] ,dtNow . ToString ( "yyyyMMdd" ) );
            view . SetRowCellValue ( e . RowHandle ,view . Columns [ "BAS002" ] ,"MC*" );
            view . SetRowCellValue ( e . RowHandle ,view . Columns [ "BAS004" ] ,"*DN" );
            view . SetRowCellValue ( e . RowHandle ,view . Columns [ "BAS005" ] ,"*DV*" );
            view . SetRowCellValue ( e . RowHandle ,view . Columns [ "BAS007" ] ,"*MF403" );
            view . SetRowCellValue ( e . RowHandle ,view . Columns [ "BAS008" ] ,"*AG403" );
            view . SetRowCellValue ( e . RowHandle ,view . Columns [ "BAS009" ] ,"*DC" );
        }

        private void gridControl1_KeyPress ( object sender ,KeyPressEventArgs e )
        {
            DataRow row = gridView1 . GetFocusedDataRow ( );
            if ( row == null )
                return;
            if ( e . KeyChar == ( char ) Keys . Delete )
            {
                model . idx = string . IsNullOrEmpty ( row [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( row [ "idx" ] . ToString ( ) );
                if ( model . idx > 0 && !idxList . Contains ( model . idx . ToString ( ) ) )
                    idxList . Add ( model . idx . ToString ( ) );
                tableView . Rows . Remove ( row );
                gridControl1 . RefreshDataSource ( );
            }
        }

        private void btnClear_Click ( object sender ,EventArgs e )
        {
            txtTime . Text = txtBAS003 . Text = txtBAS006 . Text = string . Empty;
        }

    }
}