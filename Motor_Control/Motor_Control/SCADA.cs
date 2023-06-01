using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Control
{
    public class SCADA
    {
        public List<Device> Devices = new List<Device>();
        public List<Motor> Motors = new List<Motor>();
        public short Level; //Just add //short moi dung
        System.Timers.Timer UpdateTimer = null;

        public List<TrendPoint> Trends = new List<TrendPoint>();
        public List<AlarmPoint> Alarms = new List<AlarmPoint>();

        public SCADA()
        {
            UpdateTimer = new System.Timers.Timer(1000);
            UpdateTimer.Elapsed += UpdateTags;
            UpdateTimer.Start();

        }

        string Prev_Type = "";

        private void UpdateTags(object sender, System.Timers.ElapsedEventArgs e)
        {
            Device dev = FindDevice("PLC_1");//SCADA tao truoc, device tao sau, nen can thang nay
            if (dev != null)
            {
                Level = FindDevice("PLC_1").Level;
                //Console.WriteLine($"Level is: {Level}");
                DateTime x = DateTime.Now;
                TrendPoint p = new TrendPoint { TimeStamp = x, Value = Level };//thap ep kieu sang cao hon thi binh thuong
                Trends.Add(p);
                if(Trends.Count > 30)
                {
                    Trends.RemoveAt(0);
                }

                if (Level > 90)
                {
                    if (Prev_Type != "HIHI")
                    {
                        AlarmPoint alarm = new AlarmPoint { TimeStamp = x, Value = Level, Type = "HIHI" };
                        Alarms.Add(alarm);
                        Prev_Type = "HIHI";
                    }
                }
                else if (Level > 80)
                {
                    if (Prev_Type != "HI")
                    {
                        AlarmPoint alarm = new AlarmPoint { TimeStamp = x, Value = Level, Type = "HI" };
                        Alarms.Add(alarm);//alarm van la High nhung van add vao, nen lam buoc duoi;
                        Prev_Type = "HI";
                    }
                }
                else if (Level >= 20)
                {
                    if (Prev_Type != "OK")
                    {
                        AlarmPoint alarm = new AlarmPoint { TimeStamp = x, Value = Level, Type = "OK" };
                        Alarms.Add(alarm);
                        Prev_Type = "OK";
                    }
                }
                else if (Level > 10)
                {
                    if (Prev_Type != "LO")
                    {
                        AlarmPoint alarm = new AlarmPoint { TimeStamp = x, Value = Level, Type = "LO" };
                        Alarms.Add(alarm);
                        Prev_Type = "LO";
                    }
                }
                else
                {
                    if (Prev_Type != "LOLO")
                    {
                        AlarmPoint alarm = new AlarmPoint { TimeStamp = x, Value = Level, Type = "LOLO" };
                        Alarms.Add(alarm);
                        Prev_Type = "LOLO";
                    }
                }
            }    
        }

            public void AddDevice(Device dev)
        {
            Devices.Add(dev);
        }

        public Device FindDevice(string name)
        {
            foreach (Device dev in Devices)
            {
                if(dev.Name == name)
                {
                    return dev;
                }    
            }
            return null;
        }

        public void AddMotor(Motor dev)
        {
            Motors.Add(dev);
        }

        public Motor FindMotor(string name)
        {
            foreach (Motor dev in Motors)
            {
                if (dev.Name == name)
                {
                    return dev;
                }
            }
            return null;
        }
    }

    public class TrendPoint
    {
        public DateTime TimeStamp { get; set; }
        public double Value { get; set; } //graph co san gia tri thuong la double
    }

    public class AlarmPoint
    {
        public DateTime TimeStamp { get; set; }
        public double Value { get; set; }
        public string Type { get; set; }
    }
}
