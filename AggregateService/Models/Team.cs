﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AggregateService.Models
{
    /// <summary>
    /// 团队模型
    /// </summary>
    public class Team
    {
        /// <summary>
        /// 团队主键
        /// </summary>
        public int Id { set; get; }
        /// <summary>
        /// 团队名称
        /// </summary>
        public string Name { set; get; }

        public IList<Member> Members { set; get; }
       
    }
}
