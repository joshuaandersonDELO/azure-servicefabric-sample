﻿using Quartz;
using System;
using System.Reflection;

namespace TimeTriggerService
{
    [JobInfo(CronExpression = "0 0/1 * 1/1 * ? *", Name = "SampleJob1")]
    public class SampleJob1 : IJob
    {
        private ILogger logger;
        public SampleJob1(ILogger loggerParam)
        {
            this.logger = loggerParam;
        }
        public void Execute(IJobExecutionContext context)
        {
            this.logger.WriteLine($"SampleJob1 executed from {Assembly.GetExecutingAssembly().FullName} : {DateTime.Now} .....");
        }
    }
}
