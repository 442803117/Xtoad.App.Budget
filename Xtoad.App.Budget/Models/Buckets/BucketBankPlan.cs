using System;
using System.Collections.Generic;
using System.Text;
using Xtoad.App.Budget.Enum.Buckets;

namespace Xtoad.App.Budget.Models.Buckets
{
    /// <summary>
    /// 攒钱明细记录
    /// </summary>
    public class BucketBankPlan : BaseModel
    {
        /// <summary>
        /// 攒钱记录ID
        /// </summary>
        public string MainId { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public Decimal Amount { get; set; }
        /// <summary>
        /// 存入时间
        /// </summary>
        public DateTime BankTime { get; set; }
        public BankPlanStatusEnum BankStatus  { get; set;}
    }
}
