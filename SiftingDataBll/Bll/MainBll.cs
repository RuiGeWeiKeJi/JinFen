using System;
using System . Collections . Generic;
using System . Data;

namespace SiftingDataBll . Bll
{
    public class MainBll
    {
        private readonly Dao.MainDao dal=null;

        public MainBll ( )
        {
            dal = new Dao . MainDao ( );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTableView ( string strWhere )
        {
            return dal . getTableView ( strWhere );
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Delete ( DataTable table )
        {
            return dal . Delete ( table );
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="idxList"></param>
        /// <returns></returns>
        public bool Save ( DataTable table ,List<string> idxList )
        {
            return dal . Save ( table ,idxList );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable getTablePartNum ( )
        {
            return dal . getTablePartNum ( );
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        public DataTable getTableInfo ( )
        {
            return dal . getTableInfo ( );
        }


        /// <summary>
        /// 获取打印列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTablePrint ( string strWhere )
        {
            return dal . getTablePrint ( strWhere );
        }

        /// <summary>
        /// 获取服务器系统时间
        /// </summary>
        /// <returns></returns>
        public DateTime getTimeNow ( )
        {
            return dal . getTimeNow ( );
        }
        }
}
