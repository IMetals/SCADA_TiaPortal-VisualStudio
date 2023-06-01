using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motor_Control
{
    public partial class Main : Form
    {
        public static SCADA Root = new SCADA();
        Image pump_grey = Image.FromFile(@"image\pump_side_grey.gif");
        Image pump_green = Image.FromFile(@"image\pump_side_green.gif");
        Image light_white = Image.FromFile(@"image\White_light.wmf");
        Image light_green = Image.FromFile(@"image\Green_light.wmf");
        Device PLC_1;
        public Main()
        {
            PLC_1 = new Device("127.0.0.1", "PLC_1", "Modbus");
            Root.AddDevice(PLC_1);//khong nen//nen tao khoi ctrl panel
            InitializeComponent();
        }

        private void pbMotor1_Click(object sender, EventArgs e)
        {
            Motor_FacePlate fpl = new Motor_FacePlate(Program.Root.FindMotor("Motor_1"));
            fpl.Show();
        }

        private void pbMotor2_Click(object sender, EventArgs e)
        {
            Motor_FacePlate fpl = new Motor_FacePlate(Program.Root.FindMotor("Motor_2"));
            fpl.Show();
        }

        private void pbMotor3_Click(object sender, EventArgs e)
        {
            Motor_FacePlate fpl = new Motor_FacePlate(Program.Root.FindMotor("Motor_3"));
            fpl.Show();
        }
        
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (!PLC_1.Motor_1_Data.Runfeedback)
            {
                pbMotor1.BackgroundImage = pump_grey;
            }
            else
            {
                pbMotor1.BackgroundImage = pump_green;
            }

            if (!PLC_1.Motor_2_Data.Runfeedback)
            {
                pbMotor2.BackgroundImage = pump_grey;
            }
            else

            {
                pbMotor2.BackgroundImage = pump_green;
            }
            if (!PLC_1.Motor_3_Data.Runfeedback)
            {
                pbMotor3.BackgroundImage = pump_grey;
            }
            else
            {
                pbMotor3.BackgroundImage = pump_green;
            }

            if (!PLC_1.HI)
            {
                pbHI.BackgroundImage = light_white;
            }
            else
            {
                pbHI.BackgroundImage = light_green;
            }

            if (!PLC_1.LO)
            {
                pbLO.BackgroundImage = light_white;
            }
            else
            {
                pbLO.BackgroundImage = light_green;
            }

            VPBarLevel.Value = PLC_1.Level;
        }

        private void btStart_MouseDown(object sender, MouseEventArgs e)
        {
            PLC_1.thePLC.Write("DB6.DBX0.0", true);
        }

        private void btStart_MouseUp(object sender, MouseEventArgs e)
        {
            PLC_1.thePLC.Write("DB6.DBX0.0", false);
        }

        private void btStop_MouseDown(object sender, MouseEventArgs e)
        {
            PLC_1.thePLC.Write("DB6.DBX0.1", true);
        }

        private void btStop_MouseUp(object sender, MouseEventArgs e)
        {
            PLC_1.thePLC.Write("DB6.DBX0.1", false);
        }

        private void TrendTimer_Tick(object sender, EventArgs e)
        {
            /* Console.Clear();
             for(int i = 0; i < Program.Root.Trends.Count; i++)
             {
                 Console.WriteLine($"Timestamp = {Program.Root.Trends[i].TimeStamp}" +
                                   $"Level = {Program.Root.Trends[i].Value}");
             }*/
            Console.Clear();
            for (int i = 0; i < Program.Root.Alarms.Count; i++)
            {
                Console.WriteLine($"Timestamp = {Program.Root.Alarms[i].TimeStamp}" +
                                  $"Level = {Program.Root.Alarms[i].Value}" +
                                  $"Type = {Program.Root.Alarms[i].Type}");
            }
        }

        private void btTrend_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trends dothi = new Trends();
            dothi.ShowDialog();
            dothi = null;
            this.Show();
        }

        private void btAlarm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarms alarm = new Alarms();
            alarm.ShowDialog();
            alarm = null;
            this.Show();
        }
    }
}
