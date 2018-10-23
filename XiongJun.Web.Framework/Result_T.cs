﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XiongJun.Web.Framework
{
    public class Result<T> : Result
    {
        public Result()
        {
        }
        public Result(ResultStatus status)
            : base(status)
        {
        }
        public Result(ResultStatus status, T data)
            : base(status)
        {
            this.Data = data;
        }
        public T Data { get; set; }
    }
}
