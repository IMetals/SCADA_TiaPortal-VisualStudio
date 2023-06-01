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
    public partial class Motor_FacePlate : Form
    {
        Image light_white = Image.FromFile(@"image\White_light.wmf");
        Image light_green = Image.FromFile(@"image\Green_light.wmf");
        Image light_red = Image.FromFile(@"image\Red_light.wmf");
        ushort count = 0;
        public Motor Parent = null;
        public Motor_FacePlate(Motor parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        private void btStart_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.Write(true, "Start");
        }

        private void btStart_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.Write(false, "Start");
        }

        private void btStop_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.Write(true, "Stop");
        }

        private void btStop_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.Write(false, "Stop");
        }

        private void btReset_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.Write(true, "Reset");
        }

        private void btReset_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.Write(false, "Reset");
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (!Parent.Runfeedback)
            {
                pbRunfeedback.BackgroundImage = light_white;
                pbRunfeedback.BackColor = Color.Transparent;
                pbRunfeedback.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbRunfeedback.BackgroundImage = light_green;
                pbRunfeedback.BackColor = Color.Transparent;
                pbRunfeedback.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (!Parent.Fault)
                pbFault.BackgroundImage = light_white;
            else
            {
                if (count < 2)
                    pbFault.BackgroundImage = light_red;
                else
                    pbFault.BackgroundImage = light_white;
            }
            count++;
            if (count == 4)
                count = 0;

        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMode.SelectedIndex.ToString();
            ushort temp;
            bool ret = ushort.TryParse(cbMode.SelectedIndex.ToString(), out temp);
            temp++;
            if (ret)
                Parent.Write(temp, "Mode");
        }
    }
}
