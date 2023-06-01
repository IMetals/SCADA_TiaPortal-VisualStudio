using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Motor_Control
{
    public partial class Trends : Form
    {
        public Trends()
        {
            InitializeComponent();
        }

        private void TrendTimer_Tick(object sender, EventArgs e)
        {
            ChartLevel.Series["ChartLevel"].Points.Clear();
            ChartLevel.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd:mm:yyyy'\n' HH:mm:ss";
            for (int i = 0; i < Program.Root.Trends.Count; i++)
            {
                ChartLevel.Series["ChartLevel"].Points.AddXY(Program.Root.Trends[i].TimeStamp, Program.Root.Trends[i].Value);
            }
        }
    }
}
