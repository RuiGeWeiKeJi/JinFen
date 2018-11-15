using System;
using System . Data;
using DevExpress . XtraEditors;
using System . Collections . Generic;
using System . Windows . Forms;
using System . Linq;

namespace SiftingData
{
    public partial class FormMain :FormChild
    {
        SiftingDataBll.Bll.MainBll _bll=null;
        SiftingDataEntity.MainEntity model=null;
        DataTable tableView,partTable;
        string strWhere=string.Empty;
        bool result=false;
        List<string> idxList=new List<string>();
        string dtNow=string.Empty;
        DataRow rows;

        public FormMain ( )
        {
            InitializeComponent ( );

            _bll = new SiftingDataBll . Bll . MainBll ( );
            model = new SiftingDataEntity . MainEntity ( );

            dtNow = _bll . getTimeNow ( ) . ToString ( "yyyyMMdd" );

            barManager1 . Items . Remove ( toolExport );
            gridView1 . OptionsBehavior . Editable = false;

            partTable = _bll . getTablePartNum ( );
            partNum . DataSource = partTable;
            partNum . DisplayMember = "MAI002";
            partNum . ValueMember = "MAI002";

            DataTable table = _bll . getTableInfo ( );
            txtMAI002 . Properties . DataSource = table . DefaultView . ToTable ( true ,"MAI002" );
            txtMAI002 . Properties . DisplayMember = "MAI002";
            txtMAI003 . Properties . DataSource = table . DefaultView . ToTable ( true ,"MAI003" );
            txtMAI003 . Properties . DisplayMember = "MAI003";

            GridViewMoHuSelect . SetFilter ( repositoryItemGridLookUpEdit1View );
        }

        protected override int Query ( )
        {
            strWhere = "1=1";
            if ( !string . IsNullOrEmpty ( txtMAI002 . Text ) )
                strWhere += " AND MAI002='" + txtMAI002 . Text + "'";
            if ( !string . IsNullOrEmpty ( txtMAI003 . Text ) )
                strWhere += " AND MAI003='" + txtMAI003 . Text + "'";
            if ( !string . IsNullOrEmpty ( txtMAI001 . Text ) )
                strWhere += " AND MAI001='" + txtMAI001 . Text + "'";

            tableView = _bll . getTableView ( strWhere );
            gridControl1 . DataSource = tableView;
            gridView1 . OptionsBehavior . Editable = false;
            QueryTool ( );
            toolPrint . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            idxList . Clear ( );

            return base . Query ( );
        }
        protected override int Add ( )
        {
            strWhere = "1=1";
            if ( !string . IsNullOrEmpty ( txtMAI001 . Text ) )
                strWhere += " AND MAI001='" + txtMAI001 . Text + "'";
            else
                strWhere += " AND MAI001='" + dtNow + "'";

            tableView = _bll . getTableView ( strWhere );
            gridControl1 . DataSource = tableView;

            addTool ( );
            gridView1 . OptionsBehavior . Editable = true;

            return base . Add ( );
        }
        protected override int Edit ( )
        {
            editTool ( );
            gridView1 . OptionsBehavior . Editable = true;

            return base . Edit ( );
        }
        protected override int Delete ( )
        {

            if ( XtraMessageBox . Show ( "确认删除?" ,"删除" ,MessageBoxButtons . OKCancel ) != DialogResult . OK )
                return 0;

            gridView1 . CloseEditor ( );
            gridView1 . UpdateCurrentRow ( );

            result = _bll . Delete ( tableView );
            if ( result )
            {
                XtraMessageBox . Show ( "成功删除" );
                gridControl1 . DataSource = null;
                deleteTool ( );
                idxList . Clear ( );
            }
            else
                XtraMessageBox . Show ( "删除失败" );

            return base . Delete ( );
        }
        protected override int Save ( )
        {
            gridView1 . CloseEditor ( );
            gridView1 . UpdateCurrentRow ( );

            if ( check ( ) == false )
                return 0;

            result = _bll . Save ( tableView ,idxList );
            if ( result )
            {
                XtraMessageBox . Show ( "成功保存" );
                idxList . Clear ( );
                Query ( );
                saveTool ( );
                toolPrint . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            }
            else
                XtraMessageBox . Show ( "保存失败" );

            return base . Save ( );
        }
        protected override int Cancel ( )
        {
            cancelTool ( "edit" );
            gridView1 . OptionsBehavior . Editable = false;
            toolPrint . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            idxList . Clear ( );

            return base . Cancel ( );
        }
        protected override int Print ( )
        {
            int[] rows = gridView1 . GetSelectedRows ( );

            if ( rows . Length < 1 )
            {
                XtraMessageBox . Show ( "请选择需要打印的内容" );
                return 0;
            }

            idxList . Clear ( );
            foreach ( int i in rows )
            {
                model . idx = string . IsNullOrEmpty ( gridView1 . GetDataRow ( i ) [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( gridView1 . GetDataRow ( i ) [ "idx" ] . ToString ( ) );
                if ( !idxList . Contains ( model . idx . ToString ( ) ) )
                    idxList . Add ( model . idx . ToString ( ) );
            }

            if ( idxList . Count < 1 )
            {
                XtraMessageBox . Show ( "请选择需要打印的内容" );
                return 0;
            }

            strWhere = "1=1";
            strWhere += " AND A.idx in (" + string . Join ( "," ,idxList ) + ")";

            DataTable tablePrint = _bll . getTablePrint ( strWhere );
            tablePrint . TableName = "TableOne";
            Print ( new DataTable [ ] { tablePrint } ,"二维码.frx" );
            idxList . Clear ( );

            return base . Print ( );
        }

        bool check ( )
        {
            if ( tableView == null || tableView . Rows . Count < 1 )
            {
                XtraMessageBox . Show ( "请录入数据" );
                return false;
            }
            var query = from p in tableView . AsEnumerable ( )
                        group p by new
                        {
                            t1 = p . Field<string> ( "MAI002" )
                        } into m
                        select new
                        {
                            mai002 = m . Key . t1 ,
                            count = m . Count ( )
                        };
            if ( query == null )
                return true;
            foreach ( var qu in query )
            {
                if ( !string . IsNullOrEmpty ( qu . mai002 ) && qu . count > 1 )
                {
                    XtraMessageBox . Show ( "物料代码:" + qu . mai002 + "重复,请核实" );
                    return false;
                }
            }

            var result = tableView . AsEnumerable ( )
                         . Where ( p => p . Field<DateTime> ( "MAI001" ) == null )
                         . Select ( p => new
                         {
                             mai001 = p . Field<DateTime> ( "MAI001" )
                         }
                                );
            if ( result != null )
            {
                foreach ( var s in result )
                {
                    if ( s . mai001 == null )
                    {
                        XtraMessageBox . Show ( "日期不可为空" );
                        return false;
                    }
                }
            }


            return true;
        }

        //基础资料
        private void btnBase_Click ( object sender ,EventArgs e )
        {
            FormBaseInfo form = new FormBaseInfo ( );
            form . ShowDialog ( );

            partTable = _bll . getTablePartNum ( );
            partNum . DataSource = partTable;
            partNum . DisplayMember = "MAI002";
            partNum . ValueMember = "MAI002";
        }
        //清除
        private void btnClear_Click ( object sender ,EventArgs e )
        {
            txtMAI001 . Text = txtMAI002 . Text = txtMAI003 . Text = string . Empty;
        }
        //删除数据
        private void gridControl1_KeyPress ( object sender ,System . Windows . Forms . KeyPressEventArgs e )
        {
            DataRow row = gridView1 . GetFocusedDataRow ( );
            if ( row == null )
                return;
            if ( e . KeyChar == ( char ) Keys . Enter )
            {
                if ( XtraMessageBox . Show ( "确认删除?" ,"提示" ,MessageBoxButtons . OKCancel ) == DialogResult . OK )
                {
                    model . idx = string . IsNullOrEmpty ( row [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( row [ "idx" ] . ToString ( ) );
                    if ( model . idx > 0 && !idxList . Contains ( model . idx . ToString ( ) ) )
                        idxList . Add ( model . idx . ToString ( ) );
                    tableView . Rows . Remove ( row );
                    gridControl1 . RefreshDataSource ( );
                }
            }
        }
        //新增行
        private void gridView1_InitNewRow ( object sender ,DevExpress . XtraGrid . Views . Grid . InitNewRowEventArgs e )
        {
            //DevExpress . XtraGrid . Views . Grid . GridView view = sender as DevExpress . XtraGrid . Views . Grid . GridView;
            //view . SetRowCellValue ( e . RowHandle ,view . Columns [ "MAI001" ] ,dtNow );
        }
        //行变化
        private void partNum_EditValueChanged ( object sender ,EventArgs e )
        {
            DevExpress . XtraEditors . BaseEdit edit = gridView1 . ActiveEditor;
            if ( gridView1 . FocusedColumn . FieldName == "MAI002" && edit . EditValue != null )
            {
                rows = partTable . Select ( "MAI002='" + edit . EditValue + "'" ) [ 0 ];
                gridView1 . SetFocusedRowCellValue ( gridView1 . Columns [ "BAS002" ] ,rows [ "BAS002" ] . ToString ( ) );
                gridView1 . SetFocusedRowCellValue ( gridView1 . Columns [ "BAS004" ] ,rows [ "BAS004" ] . ToString ( ) );
                gridView1 . SetFocusedRowCellValue ( gridView1 . Columns [ "BAS005" ] ,rows [ "BAS005" ] . ToString ( ) );
                gridView1 . SetFocusedRowCellValue ( gridView1 . Columns [ "BAS006" ] ,rows [ "BAS006" ] . ToString ( ) );
                gridView1 . SetFocusedRowCellValue ( gridView1 . Columns [ "BAS007" ] ,rows [ "BAS007" ] . ToString ( ) );
                gridView1 . SetFocusedRowCellValue ( gridView1 . Columns [ "BAS008" ] ,rows [ "BAS008" ] . ToString ( ) );
                gridView1 . SetFocusedRowCellValue ( gridView1 . Columns [ "BAS009" ] ,rows [ "BAS009" ] . ToString ( ) );
            }
        }

    }
}