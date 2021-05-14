using System;
using System.Collections.Generic;
using System.Text;
using Xtoad.App.Budget.Enum.Bucket;

namespace Xtoad.App.Budget.Models.Bucket
{

    /// <summary>
    /// 攒钱心愿基类
    /// 
    /// </summary>
    public abstract class AbstractBucketMoney : AbstractBucket
    {
        /// <summary>
        /// 目标金额
        /// </summary>
        public Decimal Amount { get; set; }
        /// <summary>
        /// 已攒金额
        /// </summary>
        public Decimal Own { get; set; }
        /// <summary>
        /// 攒钱类型
        /// </summary>
        public BucketMoneyTypeEnum BucketMoneyType { get; set; }
        /// <summary>
        /// 金额差距
        /// </summary>
        public Decimal AmountDifference
        {
            get
            {
                return Amount - Own;
            }
        }
        /// <summary>
        /// 已完成的百分比
        /// </summary>
        public int Percent
        {
            get
            {
                return (int)(Own / Amount) * 100;
            }
        }
        /// <summary>
        /// 攒钱周期
        /// </summary>
        public BucketCycleEnum bucketCycle { get; set; }
    }
}
