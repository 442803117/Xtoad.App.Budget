using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xtoad.App.Budget.Enum.Buckets
{
    public enum BucketTypeEnum
    {
        /// <summary>
        /// 攒钱
        /// </summary>
        [Description("攒钱")]
        Money,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other
    }
}
