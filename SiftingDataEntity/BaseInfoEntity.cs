using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace SiftingDataEntity
{
    public class BaseInfoEntity
    {
        private int _idx;
        private string _bas001;
        private string _bas002;
        private string _bas003;
        private string _bas004;
        private string _bas005;
        private string _bas006;
        private string _bas007;
        private string _bas008;
        private string _bas009;
        private string _bas010;
        /// <summary>
        /// 
        /// </summary>
        public int idx
        {
            set
            {
                _idx = value;
            }
            get
            {
                return _idx;
            }
        }
        /// <summary>
        /// 日期
        /// </summary>
        public string BAS001
        {
            set
            {
                _bas001 = value;
            }
            get
            {
                return _bas001;
            }
        }
        /// <summary>
        /// 前缀1
        /// </summary>
        public string BAS002
        {
            set
            {
                _bas002 = value;
            }
            get
            {
                return _bas002;
            }
        }
        /// <summary>
        /// 物料代码
        /// </summary>
        public string BAS003
        {
            set
            {
                _bas003 = value;
            }
            get
            {
                return _bas003;
            }
        }
        /// <summary>
        /// 后缀1_1
        /// </summary>
        public string BAS004
        {
            set
            {
                _bas004 = value;
            }
            get
            {
                return _bas004;
            }
        }
        /// <summary>
        /// 后缀1_2
        /// </summary>
        public string BAS005
        {
            set
            {
                _bas005 = value;
            }
            get
            {
                return _bas005;
            }
        }
        /// <summary>
        /// 物料描述
        /// </summary>
        public string BAS006
        {
            set
            {
                _bas006 = value;
            }
            get
            {
                return _bas006;
            }
        }
        /// <summary>
        /// 后缀2_1
        /// </summary>
        public string BAS007
        {
            set
            {
                _bas007 = value;
            }
            get
            {
                return _bas007;
            }
        }
        /// <summary>
        /// 后缀2_2
        /// </summary>
        public string BAS008
        {
            set
            {
                _bas008 = value;
            }
            get
            {
                return _bas008;
            }
        }
        /// <summary>
        /// 后缀2_3
        /// </summary>
        public string BAS009
        {
            set
            {
                _bas009 = value;
            }
            get
            {
                return _bas009;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BAS010
        {
            set
            {
                _bas010 = value;
            }
            get
            {
                return _bas010;
            }
        }
    }
}
