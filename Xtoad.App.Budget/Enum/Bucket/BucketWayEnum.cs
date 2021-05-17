using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xtoad.App.Budget.Enum.Bucket
{
    /// <summary>
    /// 攒钱方式枚举
    /// </summary>
    public enum BucketWayEnum
    {
        /// <summary>
        /// 定额
        /// </summary>
        [Description("定额")]
        Fixed,
        /// <summary>
        /// 递增
        /// </summary>
        [Description("递增")]
        Incremented,
        /// <summary>
        /// 随机
        /// </summary>
        [Description("随机")]
        Random
    }
}
