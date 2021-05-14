using System;
using System.Collections.Generic;
using System.Text;
using Xtoad.App.Budget.Enum.Bucket;

namespace Xtoad.App.Budget.Models.Bucket
{

    /// <summary>
    /// 心愿基类
    /// 
    /// </summary>
    public abstract class AbstractBucket
    {
        /// <summary>
        /// ID
        /// </summary>
        public Int64 Id { get; set; }
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
        /// 心愿描述
        /// </summary>
        public string Description { get; set; }
    }
}
