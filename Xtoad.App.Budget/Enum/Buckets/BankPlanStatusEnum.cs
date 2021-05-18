using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xtoad.App.Budget.Enum.Buckets
{
    /// <summary>
    /// 攒钱计划状态
    /// </summary>
    public enum  BankPlanStatusEnum
    {
        /// <summary>
        /// 待完成
        /// </summary>
        [Description("待完成")]
        Wait,
        /// <summary>
        /// 已完成
        /// </summary>
        [Description("已完成")]
        Finish
    }
}
