using Quartz;
using Quartz.Impl;

namespace QuartzScheduler
{
    public class JobScheduler
    {
        public static void Start()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler().Result; //making it an asynchronous call 
            scheduler.Start();

            IJobDetail job = JobBuilder.Create<ExamppleJob>().Build();

            ITrigger trigger = TriggerBuilder.Create()
              .WithDailyTimeIntervalSchedule
                (s =>
                   s.WithIntervalInSeconds(12) //Set a second interval to run Job
                  .OnEveryDay()
                  .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(0, 0))
                )
              .Build();

            IJobDetail job2 = JobBuilder.Create<Example2job>().Build();

            ITrigger trigger2 = TriggerBuilder.Create()
              .WithDailyTimeIntervalSchedule
                (s =>
                   s.WithIntervalInSeconds(5) //Set a second interval to run Job
                  .OnEveryDay()
                  .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(0, 0))
                )
              .Build();



            scheduler.ScheduleJob(job, trigger);
            scheduler.ScheduleJob(job2, trigger2);
        }
    }
}
