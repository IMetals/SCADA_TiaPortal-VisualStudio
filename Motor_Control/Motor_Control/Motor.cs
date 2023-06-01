using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Motor_Control
{
    public class Motor
    {
        public string Name;
        public string DeviceName;
        public int Period;
        System.Timers.Timer UpdateTimer = null;
        System.Timers.Timer MonitorTimer = null;//Dung debug

        public ushort Mode;
        public bool Start;
        public bool Stop;
        public bool Runfeedback;
        public bool Reset;
        public bool Fault;

        public SCADA Parent;

        public Motor(string name, int period, SCADA parent, string devname)
        {
            Name = name;
            Period = period;
            Parent = parent;
            DeviceName = devname;

            UpdateTimer = new System.Timers.Timer(Period);
            UpdateTimer.Elapsed += UpdateTags;
            UpdateTimer.Start();

            MonitorTimer = new System.Timers.Timer(Period);
            MonitorTimer.Elapsed += MonitorTags;
            MonitorTimer.Start();

        }
        //Doc du lieu tu PLC xuong
        private void UpdateTags(object sender, System.Timers.ElapsedEventArgs e)
        {
            Device device = Parent.FindDevice(DeviceName);
            if (device != null)
            {
                switch (Name)
                {
                    case "Motor_1":
                        Mode = device.Motor_1_Data.Mode;
                        Runfeedback = device.Motor_1_Data.Runfeedback;
                        Fault = device.Motor_1_Data.Fault;
                        Reset = device.Motor_1_Data.Reset;
                        break;
                    case "Motor_2":
                        Mode = device.Motor_2_Data.Mode;
                        Runfeedback = device.Motor_2_Data.Runfeedback;
                        Fault = device.Motor_2_Data.Fault;
                        Reset = device.Motor_2_Data.Reset;
                        break;
                    case "Motor_3":
                        Mode = device.Motor_3_Data.Mode;
                        Runfeedback = device.Motor_3_Data.Runfeedback;
                        Fault = device.Motor_3_Data.Fault;
                        Reset = device.Motor_3_Data.Reset;
                        break;
                }
            }

        }
        // Ghi du lieu len PLC
        public void Write(object value, string tagname) //"Motor_1.Mode" phan biet truoc sau dau .
        {

            switch (tagname)
            {
                case "Mode":
                    Device dev = Parent.FindDevice(DeviceName);
                    dev.Write(value, $"{Name}.Mode");
                    break;
                case "Start":
                    dev = Parent.FindDevice(DeviceName);
                    dev.Write(value, $"{Name}.Start");
                    break;
                case "Stop":
                    dev = Parent.FindDevice(DeviceName);
                    dev.Write(value, $"{Name}.Stop");
                    break;
                case "Reset":
                    dev = Parent.FindDevice(DeviceName);
                    dev.Write(value, $"{Name}.Reset");
                    break;
            }
        }

        private void MonitorTags(object sender, System.Timers.ElapsedEventArgs e)
        {
            //Console.WriteLine($"Name = {Name} Mode = {Mode} Status = {Runfeedback} Fault = {Fault}");
            //Console.WriteLine("===================================================================");
        }
    }
}
