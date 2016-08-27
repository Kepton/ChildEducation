using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{

    /// <summary>
    /// 基本的DataGird参数
    /// </summary>
    public class BaseGridParam
    {

        /// <summary>
        /// 当前页数
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// 行数
        /// </summary>
        public int rows { get; set; }
        public int total { get; set; }

        public string text { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public string order { get; set; }

        /// <summary>
        /// 升序降序
        /// </summary>
        public string sort { get; set; }
    }
}
