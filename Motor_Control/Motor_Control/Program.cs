using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motor_Control
{
    internal static class Program
    {
        public static SCADA Root = new SCADA();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Device PLC_1 = new Device("127.0.0.1", "PLC_1", "Modbus");
            Root.AddDevice(PLC_1);

            Motor motor = new Motor("Motor_1", 250, Root, "PLC_1");
            Root.AddMotor(motor);
            motor = new Motor("Motor_2", 250, Root, "PLC_1");
            Root.AddMotor(motor);
            motor = new Motor("Motor_3", 250, Root, "PLC_1");
            Root.AddMotor(motor);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
