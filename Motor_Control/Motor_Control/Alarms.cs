using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motor_Control
{
    public partial class Alarms : Form
    {
        public Alarms()
        {
            InitializeComponent();
        }

        private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            dgvAlarm.DataSource = null;
            dgvAlarm.DataSource = Program.Root.Alarms;
        }
    }
}
