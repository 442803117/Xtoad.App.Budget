using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xtoad.App.Budget.Enum.Buckets
{
    /// <summary>
    /// 攒钱心愿类型
    /// </summary>
    public enum BucketMoneyTypeEnum
    {
        /// <summary>
        /// 房子
        /// </summary>
        [Description("房子")]
        House,
        /// <summary>
        /// 车
        /// </summary>
        [Description("车")]
        Car,
        /// <summary>
        /// 数码
        /// </summary>
        [Description("数码")]
        DigitalProduction,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other
    }
}
