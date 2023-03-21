using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Clock
    {

        DateTime alarmTime = DateTime.Now;

        public delegate void AlarmHandler(object sender, DateTime args);
        public delegate void TickHanlder(object sender, DateTime args);

        public event AlarmHandler OnAlarm;
        public event TickHanlder OnTick;
        public void PrintTime(object sender, DateTime time)
        {
            Console.Write(time);
            Console.WriteLine();
        }
        public void Alarm(object sender, DateTime time)
        {
            Console.Write("闹钟响，现在的时间为：");
        }

        public void Tick(object sender, DateTime time)
        {
            Console.Write("嘀嗒，现在的时间为：");
        }
        public Clock()
        {
            OnAlarm += Alarm;
            OnAlarm += PrintTime;
            OnTick += Tick;
            OnTick += PrintTime;
        }
        public void ClockStart()
        {
            Console.WriteLine("闹钟开始工作");
            while (true)
            {
                DateTime nowtime = DateTime.Now;
                OnTick(this, nowtime);
                if (nowtime.ToString() == alarmTime.ToString()) 
                {
                    OnAlarm(this, alarmTime);
                    break;
                }
                System.Threading.Thread.Sleep(1000);
            }
        }
        public void SetalarmTime(DateTime alarmtime)
        {
            Console.WriteLine("所设的闹钟时间为："+alarmtime);
            alarmTime = alarmtime;
        }
    }
    class Project2
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            DateTime alarmtime = new DateTime();
            alarmtime = DateTime.Now.AddSeconds(7);
            clock.SetalarmTime(alarmtime);
            clock.ClockStart();
        }
    }
}
