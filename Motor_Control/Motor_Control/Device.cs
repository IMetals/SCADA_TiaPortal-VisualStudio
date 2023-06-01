using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using S7.Net;

namespace Motor_Control
{
    public class Device
    {
        public short Level;
        public bool HI;
        public bool LO;
        public string IP;
        public string Name;
        public string TYPE;
        public Plc thePLC = null;
        public ModbusClient modbusPLC = null;

        public Motor_Data Motor_1_Data = new Motor_Data();
        public Motor_Data Motor_2_Data = new Motor_Data();
        public Motor_Data Motor_3_Data = new Motor_Data();

        System.Timers.Timer UpdateTimer = null;

        public Device(string ip, string name, string typeplc)
        {
            TYPE = typeplc;
            IP = ip;
            Name = name;
            if (TYPE == "TCPIP")
            {
                thePLC = new Plc(CpuType.S71500, IP, 0, 1);

                try
                {
                    thePLC.Open();
                    Console.WriteLine($"Connect to the PLC {Name} {IP} successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Can not connect to the PLC {IP}:{ex.Message}");
                }
            }

            if (TYPE == "Modbus")
            {
                modbusPLC = new ModbusClient();
                modbusPLC.IPAddress = IP;
                modbusPLC.Port = Convert.ToInt32(502);
                modbusPLC.Connect();
                if (modbusPLC.Connected == true)
                    Console.WriteLine("Schneider connected");
            }
            UpdateTimer = new System.Timers.Timer(500);
            UpdateTimer.Elapsed += UpdateTags;
            UpdateTimer.Start();
        }

        private void UpdateTags(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (TYPE == "TCPIP")
            {
                object ob1 = thePLC.Read("DB6.DBX0.2");
                HI = Convert.ToBoolean(ob1);
                object ob2 = thePLC.Read("DB6.DBX0.3");
                LO = Convert.ToBoolean(ob2);
                thePLC.ReadClass(Motor_1_Data, 1);
                thePLC.ReadClass(Motor_2_Data, 2);
                thePLC.ReadClass(Motor_3_Data, 3);
                object ob = thePLC.Read("MW100");
                Level = ((ushort)ob).ConvertToShort();
            }
            if (TYPE == "Modbus")
            {
                int[] temp = modbusPLC.ReadHoldingRegisters(114, 1);
                Level = (short)temp[0];
                int[] temp1 = modbusPLC.ReadHoldingRegisters(113, 1);
                HI = Convert.ToBoolean(temp1[0] & 1);
                LO = Convert.ToBoolean(temp1[0] & 256);
                ModbusReadClass(Motor_1_Data, 100);
                ModbusReadClass(Motor_2_Data, 104);
                ModbusReadClass(Motor_3_Data, 108);

            }    
        }

        public void Write(object value, string tagname)
        {
            string[] s = tagname.Split('.');
            if (TYPE == "TCPIP")
            {
                switch (s[0])
                {
                    case "Motor_1":
                        switch (s[1])
                        {
                            case "Mode":
                                thePLC.Write("DB1.DBW0", value);
                                break;
                            case "Start":
                                thePLC.Write("DB1.DBX2.0", value);
                                break;
                            case "Stop":
                                thePLC.Write("DB1.DBX2.1", value);
                                break;
                            case "Reset":
                                thePLC.Write("DB1.DBX2.5", value);
                                break;
                        }
                        break;
                    case "Motor_2":
                        switch (s[1])
                        {
                            case "Mode":
                                thePLC.Write("DB2.DBW0", value);
                                break;
                            case "Start":
                                thePLC.Write("DB2.DBX2.0", value);
                                break;
                            case "Stop":
                                thePLC.Write("DB2.DBX2.1", value);
                                break;
                            case "Reset":
                                thePLC.Write("DB2.DBX2.5", value);
                                break;
                        }
                        break;
                    case "Motor_3":
                        switch (s[1])
                        {
                            case "Mode":
                                thePLC.Write("DB3.DBW0", value);
                                break;
                            case "Start":
                                thePLC.Write("DB3.DBX2.0", value);
                                break;
                            case "Stop":
                                thePLC.Write("DB3.DBX2.1", value);
                                break;
                            case "Reset":
                                thePLC.Write("DB3.DBX2.5", value);
                                break;
                        }
                        break;
                }
            }

            else if (TYPE == "Modbus")
            {
                switch (s[0])
                {
                    case "Motor_1":
                        switch (s[1])
                        {
                            case "Mode":
                                modbusPLC.WriteSingleRegister(100, Convert.ToInt32(value));
                                break;
                            case "Start":
                                modbusPLC.WriteSingleRegister(101, Convert.ToInt32(value));
                                break;
                            case "Stop":
                                modbusPLC.WriteSingleRegister(101, Convert.ToInt32(value) << 8);
                                break;
                            case "Reset":
                                modbusPLC.WriteSingleRegister(102, Convert.ToInt32(value) << 8);
                                break;
                        }
                        break;
                    case "Motor_2":
                        switch (s[1])
                        {
                            case "Mode":
                                modbusPLC.WriteSingleRegister(104, Convert.ToInt32(value));
                                break;
                            case "Start":
                                modbusPLC.WriteSingleRegister(105, Convert.ToInt32(value));
                                break;
                            case "Stop":
                                modbusPLC.WriteSingleRegister(105, Convert.ToInt32(value) << 8);
                                break;
                            case "Reset":
                                modbusPLC.WriteSingleRegister(106, Convert.ToInt32(value) << 8);
                                break;
                        }
                        break;
                    case "Motor_3":
                        switch (s[1])
                        {
                            case "Mode":
                                modbusPLC.WriteSingleRegister(108, Convert.ToInt32(value));
                                break;
                            case "Start":
                                modbusPLC.WriteSingleRegister(109, Convert.ToInt32(value));
                                break;
                            case "Stop":
                                modbusPLC.WriteSingleRegister(109, Convert.ToInt32(value) << 8);
                                break;
                            case "Reset":
                                modbusPLC.WriteSingleRegister(110, Convert.ToInt32(value) << 8);
                                break;
                        }
                        break;
                }
            }    
        }

        void ModbusReadClass(Motor_Data motor_block, int addr)
        {
            int[] value = modbusPLC.ReadHoldingRegisters(addr, 4);
            motor_block.Mode = (ushort)value[0];
            motor_block.Start = Convert.ToBoolean(value[1] & 0x1);
            motor_block.Stop = Convert.ToBoolean(value[1] >> 8 & 0x1);
            motor_block.Runfeedback = Convert.ToBoolean(value[2] & 0x1);
            motor_block.Reset = Convert.ToBoolean(value[2] >> 8 & 0x1);
            motor_block.Fault = Convert.ToBoolean(value[3]);
            Console.WriteLine(Motor_1_Data.Start);
        }
    }

    public class Motor_Data
    {
        public ushort Mode { get; set; }
        public bool Start { get; set; }
        public bool Stop { get; set; }
        public bool RunCondition { get; set; }
        public bool StopCondition { get; set; }
        public bool Runfeedback { get; set; }
        public bool Reset { get; set; }
        public byte Output { get; set; }
        public bool Cmd { get; set; }
        public bool Fault { get; set; }
    }
}
