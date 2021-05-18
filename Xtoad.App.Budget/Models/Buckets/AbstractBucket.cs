using System;
using System.Collections.Generic;
using System.Text;
using Xtoad.App.Budget.Enum.Buckets;

namespace Xtoad.App.Budget.Models.Buckets
{

    /// <summary>
    /// 心愿基类
    /// 
    /// </summary>
    public abstract class AbstractBucket : BaseModel
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 封面
        /// </summary>
        public string Cover { get; set; }
        /// <summary>
        /// 心愿类型
        /// </summary>
        public BucketTypeEnum BucketType { get; set; }
        /// <summary>
        /// 心愿开始日期
        /// </summary>
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 心愿结束日期
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 心愿描述
        /// </summary>
        public string Description { get; set; }
    }
}
