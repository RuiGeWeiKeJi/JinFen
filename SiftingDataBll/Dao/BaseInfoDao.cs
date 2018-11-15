using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using System . Threading . Tasks;
using StudentMgr;
using System . Collections;
using System . Data . SqlClient;

namespace SiftingDataBll . Dao
{
    public class BaseInfoDao
    {
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTableView ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT idx,BAS001,BAS002,BAS003,BAS004,BAS005,BAS006,BAS007,BAS008,BAS009 FROM JIFBAS " );
            if ( !string . IsNullOrEmpty ( strWhere ) )
                strSql . AppendFormat ( "WHERE {0}" ,strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Delete ( DataTable table )
        {
            ArrayList SQLString = new ArrayList ( );
            StringBuilder strSql = new StringBuilder ( );
            SiftingDataEntity . BaseInfoEntity model = new SiftingDataEntity . BaseInfoEntity ( );
            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                model . idx = string . IsNullOrEmpty ( table . Rows [ i ] [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "idx" ] . ToString ( ) );
                Delete ( SQLString ,strSql ,model );
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        void Delete ( ArrayList SQLString ,StringBuilder strSql ,SiftingDataEntity . BaseInfoEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM JIFBAS WHERE idx={0}" ,model . idx );

            SQLString . Add ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="idxList"></param>
        /// <returns></returns>
        public bool Save ( DataTable table ,List<string> idxList )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );
            SiftingDataEntity . BaseInfoEntity model = new SiftingDataEntity . BaseInfoEntity ( );
            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                model . BAS001 = table . Rows [ i ] [ "BAS001" ] . ToString ( );
                model . BAS002 = table . Rows [ i ] [ "BAS002" ] . ToString ( );
                model . BAS003 = table . Rows [ i ] [ "BAS003" ] . ToString ( );
                model . BAS004 = table . Rows [ i ] [ "BAS004" ] . ToString ( );
                model . BAS005 = table . Rows [ i ] [ "BAS005" ] . ToString ( );
                model . BAS006 = table . Rows [ i ] [ "BAS006" ] . ToString ( );
                model . BAS007 = table . Rows [ i ] [ "BAS007" ] . ToString ( );
                model . BAS008 = table . Rows [ i ] [ "BAS008" ] . ToString ( );
                model . BAS009 = table . Rows [ i ] [ "BAS009" ] . ToString ( );
                model . idx = string . IsNullOrEmpty ( table . Rows [ i ] [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "idx" ] . ToString ( ) );
                if ( model . idx > 0 )
                    Edit ( SQLString ,strSql ,model );
                else
                {
                    if ( Exists ( model . BAS003 ) )
                        Edits ( SQLString ,strSql ,model );
                    else
                        Add ( SQLString ,strSql ,model );
                }
            }

            if ( idxList . Count > 0 )
            {
                foreach ( string i in idxList )
                {
                    model . idx = Convert . ToInt32 ( i );
                    if ( model . idx > 0 )
                        Delete ( SQLString ,strSql ,model );
                }
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        bool Exists ( string partNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT COUNT(1) FROM JIFBAS WHERE BAS003='{0}'" ,partNum );

            return SqlHelper . Exists ( strSql . ToString ( ) );
        }

        void Add ( Hashtable SQLString ,StringBuilder strSql ,SiftingDataEntity . BaseInfoEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "insert into JIFBAS(" );
            strSql . Append ( "BAS001,BAS002,BAS003,BAS004,BAS005,BAS006,BAS007,BAS008,BAS009)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@BAS001,@BAS002,@BAS003,@BAS004,@BAS005,@BAS006,@BAS007,@BAS008,@BAS009)" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@BAS001", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS002", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS003", SqlDbType.NVarChar,50),
                    new SqlParameter("@BAS004", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS005", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS006", SqlDbType.NVarChar,100),
                    new SqlParameter("@BAS007", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS008", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS009", SqlDbType.NVarChar,20)
            };
            parameters [ 0 ] . Value = model . BAS001;
            parameters [ 1 ] . Value = model . BAS002;
            parameters [ 2 ] . Value = model . BAS003;
            parameters [ 3 ] . Value = model . BAS004;
            parameters [ 4 ] . Value = model . BAS005;
            parameters [ 5 ] . Value = model . BAS006;
            parameters [ 6 ] . Value = model . BAS007;
            parameters [ 7 ] . Value = model . BAS008;
            parameters [ 8 ] . Value = model . BAS009;

            SQLString . Add ( strSql ,parameters );
        }

        void Edit ( Hashtable SQLString ,StringBuilder strSql ,SiftingDataEntity . BaseInfoEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "update JIFBAS set " );
            strSql . Append ( "BAS001=@BAS001," );
            strSql . Append ( "BAS002=@BAS002," );
            strSql . Append ( "BAS003=@BAS003," );
            strSql . Append ( "BAS004=@BAS004," );
            strSql . Append ( "BAS005=@BAS005," );
            strSql . Append ( "BAS006=@BAS006," );
            strSql . Append ( "BAS007=@BAS007," );
            strSql . Append ( "BAS008=@BAS008," );
            strSql . Append ( "BAS009=@BAS009 " );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@BAS001", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS002", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS003", SqlDbType.NVarChar,50),
                    new SqlParameter("@BAS004", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS005", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS006", SqlDbType.NVarChar,100),
                    new SqlParameter("@BAS007", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS008", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS009", SqlDbType.NVarChar,20),
                    new SqlParameter("@idx", SqlDbType.Int,4)
            };
            parameters [ 0 ] . Value = model . BAS001;
            parameters [ 1 ] . Value = model . BAS002;
            parameters [ 2 ] . Value = model . BAS003;
            parameters [ 3 ] . Value = model . BAS004;
            parameters [ 4 ] . Value = model . BAS005;
            parameters [ 5 ] . Value = model . BAS006;
            parameters [ 6 ] . Value = model . BAS007;
            parameters [ 7 ] . Value = model . BAS008;
            parameters [ 8 ] . Value = model . BAS009;
            parameters [ 9 ] . Value = model . idx;
            SQLString . Add ( strSql ,parameters );
        }

        void Edits ( Hashtable SQLString ,StringBuilder strSql ,SiftingDataEntity . BaseInfoEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "update JIFBAS set " );
            strSql . Append ( "BAS001=@BAS001," );
            strSql . Append ( "BAS002=@BAS002," );
            strSql . Append ( "BAS004=@BAS004," );
            strSql . Append ( "BAS005=@BAS005," );
            strSql . Append ( "BAS006=@BAS006," );
            strSql . Append ( "BAS007=@BAS007," );
            strSql . Append ( "BAS008=@BAS008," );
            strSql . Append ( "BAS009=@BAS009 " );
            strSql . Append ( "WHERE BAS003=@BAS003" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@BAS001", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS002", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS003", SqlDbType.NVarChar,50),
                    new SqlParameter("@BAS004", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS005", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS006", SqlDbType.NVarChar,100),
                    new SqlParameter("@BAS007", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS008", SqlDbType.NVarChar,20),
                    new SqlParameter("@BAS009", SqlDbType.NVarChar,20)
            };
            parameters [ 0 ] . Value = model . BAS001;
            parameters [ 1 ] . Value = model . BAS002;
            parameters [ 2 ] . Value = model . BAS003;
            parameters [ 3 ] . Value = model . BAS004;
            parameters [ 4 ] . Value = model . BAS005;
            parameters [ 5 ] . Value = model . BAS006;
            parameters [ 6 ] . Value = model . BAS007;
            parameters [ 7 ] . Value = model . BAS008;
            parameters [ 8 ] . Value = model . BAS009;

            SQLString . Add ( strSql ,parameters );
        }

        void Delete ( Hashtable SQLString ,StringBuilder strSql ,SiftingDataEntity . BaseInfoEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "delete from JIFBAS " );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@idx", SqlDbType.Int,4)
            };
            parameters [ 0 ] . Value = model . idx;

            SQLString . Add ( strSql ,parameters );
        }

        /// <summary>
        /// 获取服务器系统时间
        /// </summary>
        /// <returns></returns>
        public DateTime getTimeNow ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT GETDATE() t;" );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
                return string . IsNullOrEmpty ( dt . Rows [ 0 ] [ "t" ] . ToString ( ) ) == true ? DateTime . Now : Convert . ToDateTime ( dt . Rows [ 0 ] [ "t" ] . ToString ( ) );
            else
                return DateTime . Now;
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable getTableOnlyColumn ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT DISTINCT BAS003,BAS006 FROM JIFBAS" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
