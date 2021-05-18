using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xtoad.App.Budget.Enum.Buckets
{
    /// <summary>
    /// 心愿周期枚举
    /// </summary>
    public enum BucketCycleEnum
    {
        /// <summary>
        /// 每天
        /// </summary>
        [Description("每天")]
        Day,
        /// <summary>
        /// 每周
        /// </summary>
        [Description("每周")]
        Week,
        /// <summary>
        /// 每月
        /// </summary>
        [Description("每月")]
        Month,
        /// <summary>
        /// 每季度
        /// </summary>
        [Description("每季度")]
        Quarter,
        /// <summary>
        /// 不定期
        /// </summary>
        [Description("不定期")]
        Other
    }
}
