﻿
using System.Collections.Generic;
using System.Text;
using MicroServiceCore.Registry;

namespace MicroServiceCore.Cluster {
    /// <summary>
    /// 服务负载均衡
    /// </summary>
    public interface ILoadBalance {
        /// <summary>
        /// 服务选择
        /// </summary>
        /// <param name="serviceUrls"></param>
        /// <returns></returns>
        ServiceUrl Select (IList<ServiceUrl> serviceUrls);
    }
}