using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace LightManager
{
    //白天 凌晨/黄昏 夜晚
    public enum TimeSlot
    {
        DayTime=0,
        Wee,
        Dusk,
        Evening,
        Other
    }
    public class TimeRange
    {
        public TimeSlot ts;
        public int minuteMin;
        public int minuteMax;
    }
   public class TimeJudge
    {
        List<TimeRange> timeRange = new List<TimeRange>();
        public TimeJudge()
        {
            InitTimeRange();
        }
        private void InitTimeRange()
        {
            int minuteMin = 0;
            int minuteMax = 0;
            TimeRange TR = new TimeRange();
            //凌晨 00:01~6:0点
            minuteMin = 1;
            minuteMax = 6 * 60;
            TR.ts = TimeSlot.Wee;
            TR.minuteMin = minuteMin;
            TR.minuteMax = minuteMax;
            timeRange.Add(TR);
            TimeRange TR1 = new TimeRange();
            //黄昏 18:01~19:00
            minuteMin = 18*60+1;
            minuteMax = 19 * 60;
            TR1.ts = TimeSlot.Dusk;
            TR1.minuteMin = minuteMin;
            TR1.minuteMax = minuteMax;
            timeRange.Add(TR1);
            //白天 6:01~18:0
            TimeRange TR2 = new TimeRange();
            minuteMin = 6 * 60 + 1;
            minuteMax = 18 * 60;
            TR2.ts = TimeSlot.DayTime;
            TR2.minuteMin = minuteMin;
            TR2.minuteMax = minuteMax;
            timeRange.Add(TR2);
            //夜晚 19:01~24:0
            TimeRange TR3 = new TimeRange();
            minuteMin = 19 * 60 + 1;
            minuteMax = 24 * 60;
            TR3.ts = TimeSlot.Evening;
            TR3.minuteMin = minuteMin;
            TR3.minuteMax = minuteMax;
            timeRange.Add(TR3);
        }    
        private DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }
        public void JudgeTheTime(TimeSlot ts,string show)
        {
            var v = GetCurrentTime();
            if (null == v)
                return;
            var rl = JG(v);
            if (rl == TimeSlot.Other)
                return;
            string temp = "";
            if (ts != rl)
            {
                if (ts == TimeSlot.Dusk && rl == TimeSlot.Wee)
                    return;
                if (rl == TimeSlot.DayTime)
                    temp = "白天";
                else if (rl == TimeSlot.Dusk || rl == TimeSlot.Wee)
                    temp = "凌晨/黄昏";
                else if (rl == TimeSlot.Evening)
                    temp = "夜晚";
                MessageBox.Show("当前时间是"+temp+",确定选择"+show+"么");
            }
        }
        private TimeSlot JG(DateTime dt)
        {
            TimeSlot t = TimeSlot.Other;
            if (null == dt)
                return t;
            int currentMinute = dt.Hour * 60 + dt.Minute;
            foreach(var v in timeRange)
            {
                if (v.minuteMin <= currentMinute && currentMinute <= v.minuteMax)
                {
                    t = v.ts;
                    break;
                }
            }
            return t;
        }

    }
}
