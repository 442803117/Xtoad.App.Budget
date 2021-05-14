using System;
using System.Collections.Generic;
using System.Text;

namespace Xtoad.App.Budget.Models.Bucket
{
    /// <summary>
    /// 攒钱心愿-买房子
    /// </summary>
    public class BucketMoneyHouse : AbstractBucketMoney
    {
        /// <summary>
        /// 房子所在城市
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 房子面积
        /// </summary>
        public Decimal Area { get; set; }

    }
}
