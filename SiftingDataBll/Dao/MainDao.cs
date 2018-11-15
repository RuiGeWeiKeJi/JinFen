using System . Data;
using System . Text;
using StudentMgr;
using System . Collections;
using System;
using System . Data . SqlClient;
using System . Collections . Generic;
using System . Linq;

namespace SiftingDataBll . Dao
{
    public class MainDao
    {
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTableView ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT A.idx,MAI001,MAI002,MAI003,MAI004,BAS002,BAS004,BAS005,BAS006,BAS007,BAS008,BAS009 FROM JIFMAI A INNER JOIN JIFBAS B ON A.MAI002=B.BAS003 WHERE {0}" ,strWhere );
            
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
            SiftingDataEntity . MainEntity model = new SiftingDataEntity . MainEntity ( );
            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                model . idx = string . IsNullOrEmpty ( table . Rows [ i ] [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "idx" ] . ToString ( ) );
                if ( model . idx > 0 )
                    Delete ( SQLString ,strSql ,model );
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        void Delete ( ArrayList SQLString ,StringBuilder strSql ,SiftingDataEntity . MainEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM JIFMAI WHERE idx={0}" ,model . idx );
            SQLString . Add ( strSql );
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
            SiftingDataEntity . MainEntity model = new SiftingDataEntity . MainEntity ( );
            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                model . idx = string . IsNullOrEmpty ( table . Rows [ i ] [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "idx" ] . ToString ( ) );
                model . MAI001 = string . IsNullOrEmpty ( table . Rows [ i ] [ "MAI001" ] . ToString ( ) ) == true ? DateTime . Now : Convert . ToDateTime ( table . Rows [ i ] [ "MAI001" ] . ToString ( ) );
                model . MAI002 = table . Rows [ i ] [ "MAI002" ] . ToString ( );
                model . MAI003 = table . Rows [ i ] [ "MAI003" ] . ToString ( );
                model . MAI004 = string . IsNullOrEmpty ( table . Rows [ i ] [ "MAI004" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "MAI004" ] . ToString ( ) );
                //model . MAI005 = table . Rows [ i ] [ "MAI005" ] . ToString ( );
                if ( model . idx < 1 )
                {
                    if ( Exists ( model . MAI002 ) )
                        Edit ( SQLString ,strSql ,model );
                    else
                        Add ( SQLString ,strSql ,model );
                }
                else
                    Edits ( SQLString ,strSql ,model );
            }

            if ( idxList . Count > 0 )
            {
                foreach( string i in idxList )
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
            strSql . AppendFormat ( "SELECT COUNT(1) FROM JIFMAI WHERE MAI002='{0}'" ,partNum );

            return SqlHelper . Exists ( strSql . ToString ( ) );
        }

        void Add ( Hashtable SQLString ,StringBuilder strSql ,SiftingDataEntity . MainEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "insert into JIFMAI(" );
            strSql . Append ( "MAI001,MAI002,MAI003,MAI004)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@MAI001,@MAI002,@MAI003,@MAI004)" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@MAI001", SqlDbType.Date,3),
                    new SqlParameter("@MAI002", SqlDbType.NVarChar,50),
                    new SqlParameter("@MAI003", SqlDbType.NVarChar,50),
                    new SqlParameter("@MAI004", SqlDbType.Int,4)//,
                    //new SqlParameter("@MAI005", SqlDbType.NVarChar,200)
            };
            parameters [ 0 ] . Value = model . MAI001;
            parameters [ 1 ] . Value = model . MAI002;
            parameters [ 2 ] . Value = model . MAI003;
            parameters [ 3 ] . Value = model . MAI004;
            //parameters [ 4 ] . Value = model . MAI005;

            SQLString . Add ( strSql ,parameters );
        }

        void Edit ( Hashtable SQLString ,StringBuilder strSql ,SiftingDataEntity . MainEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "update JIFMAI set " );
            strSql . Append ( "MAI001=@MAI001," );
            strSql . Append ( "MAI003=@MAI003," );
            strSql . Append ( "MAI004=@MAI004 " );
            //strSql . Append ( "MAI005=@MAI005 " );
            strSql . Append ( " where MAI002=@MAI002" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@MAI001", SqlDbType.Date,3),
                    new SqlParameter("@MAI002", SqlDbType.NVarChar,50),
                    new SqlParameter("@MAI003", SqlDbType.NVarChar,50),
                    new SqlParameter("@MAI004", SqlDbType.Int,4)//,
                    //new SqlParameter("@MAI005", SqlDbType.NVarChar,200)
            };
            parameters [ 0 ] . Value = model . MAI001;
            parameters [ 1 ] . Value = model . MAI002;
            parameters [ 2 ] . Value = model . MAI003;
            parameters [ 3 ] . Value = model . MAI004;
            //parameters [ 4 ] . Value = model . MAI005;

            SQLString . Add ( strSql ,parameters );
        }

        void Edits ( Hashtable SQLString ,StringBuilder strSql ,SiftingDataEntity . MainEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "update JIFMAI set " );
            strSql . Append ( "MAI001=@MAI001," );
            strSql . Append ( "MAI002=@MAI002," );
            strSql . Append ( "MAI003=@MAI003," );
            strSql . Append ( "MAI004=@MAI004 " );
            //strSql . Append ( "MAI005=@MAI005 " );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@MAI001", SqlDbType.Date,3),
                    new SqlParameter("@MAI002", SqlDbType.NVarChar,50),
                    new SqlParameter("@MAI003", SqlDbType.NVarChar,50),
                    new SqlParameter("@MAI004", SqlDbType.Int,4),
                    //new SqlParameter("@MAI005", SqlDbType.NVarChar,200),
                    new SqlParameter("@idx", SqlDbType.Int,4)
            };
            parameters [ 0 ] . Value = model . MAI001;
            parameters [ 1 ] . Value = model . MAI002;
            parameters [ 2 ] . Value = model . MAI003;
            parameters [ 3 ] . Value = model . MAI004;
            //parameters [ 4 ] . Value = model . MAI005;
            parameters [ 4 ] . Value = model . idx;
            SQLString . Add ( strSql ,parameters );
        }

        void Delete ( Hashtable SQLString ,StringBuilder strSql ,SiftingDataEntity . MainEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "delete from JIFMAI " );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@idx", SqlDbType.Int,4)
            };
            parameters [ 0 ] . Value = model.idx;
            SQLString . Add ( strSql ,parameters );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable getTablePartNum ( )
        {
            StringBuilder strSql = new StringBuilder ( );//WHERE BAS003 NOT IN (SELECT MAI002 FROM JIFMAI)
            strSql . Append ( "SELECT idx,BAS002,BAS003 MAI002,BAS004,BAS005,BAS006,BAS007,BAS008,BAS009 FROM JIFBAS " );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        public DataTable getTableInfo ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT MAI002,MAI003 FROM JIFMAI" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取打印列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTablePrint ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT MAI001,MAI002,BAS002,MAI003,MAI004,BAS006,BAS002+MAI002+BAS004+BAS005+BAS006+MAI003+BAS007+BAS008+BAS009+CONVERT(VARCHAR,MAI004) MAI FROM JIFMAI A INNER JOIN JIFBAS B ON A.MAI002=B.BAS003 WHERE {0}" ,strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
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

    }
}
