namespace Motor_Control
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pbMotor1 = new System.Windows.Forms.PictureBox();
            this.pbMotor2 = new System.Windows.Forms.PictureBox();
            this.pbMotor3 = new System.Windows.Forms.PictureBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbHI = new System.Windows.Forms.PictureBox();
            this.pbLO = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrendTimer = new System.Windows.Forms.Timer(this.components);
            this.btTrend = new System.Windows.Forms.Button();
            this.VPBarLevel = new Motor_Control.VerticalProgressBar();
            this.btAlarm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLO)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMotor1
            // 
            this.pbMotor1.BackColor = System.Drawing.Color.Transparent;
            this.pbMotor1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMotor1.BackgroundImage")));
            this.pbMotor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMotor1.Location = new System.Drawing.Point(123, 319);
            this.pbMotor1.Name = "pbMotor1";
            this.pbMotor1.Size = new System.Drawing.Size(91, 67);
            this.pbMotor1.TabIndex = 3;
            this.pbMotor1.TabStop = false;
            this.pbMotor1.Click += new System.EventHandler(this.pbMotor1_Click);
            // 
            // pbMotor2
            // 
            this.pbMotor2.BackColor = System.Drawing.Color.Transparent;
            this.pbMotor2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMotor2.BackgroundImage")));
            this.pbMotor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMotor2.Location = new System.Drawing.Point(123, 112);
            this.pbMotor2.Name = "pbMotor2";
            this.pbMotor2.Size = new System.Drawing.Size(91, 67);
            this.pbMotor2.TabIndex = 4;
            this.pbMotor2.TabStop = false;
            this.pbMotor2.Click += new System.EventHandler(this.pbMotor2_Click);
            // 
            // pbMotor3
            // 
            this.pbMotor3.BackColor = System.Drawing.Color.Transparent;
            this.pbMotor3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMotor3.BackgroundImage")));
            this.pbMotor3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMotor3.Location = new System.Drawing.Point(424, 271);
            this.pbMotor3.Name = "pbMotor3";
            this.pbMotor3.Size = new System.Drawing.Size(91, 67);
            this.pbMotor3.TabIndex = 5;
            this.pbMotor3.TabStop = false;
            this.pbMotor3.Click += new System.EventHandler(this.pbMotor3_Click);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 250;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(509, 79);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 30);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btStart_MouseDown);
            this.btStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btStart_MouseUp);
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStop.Location = new System.Drawing.Point(509, 135);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 30);
            this.btStop.TabIndex = 7;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btStop_MouseDown);
            this.btStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btStop_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(256, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 356);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(210, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 22);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(210, 351);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 22);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(372, 301);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 22);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pbHI
            // 
            this.pbHI.BackColor = System.Drawing.Color.Transparent;
            this.pbHI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHI.Location = new System.Drawing.Point(388, 123);
            this.pbHI.Name = "pbHI";
            this.pbHI.Size = new System.Drawing.Size(27, 28);
            this.pbHI.TabIndex = 14;
            this.pbHI.TabStop = false;
            // 
            // pbLO
            // 
            this.pbLO.BackColor = System.Drawing.Color.Transparent;
            this.pbLO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLO.Location = new System.Drawing.Point(388, 358);
            this.pbLO.Name = "pbLO";
            this.pbLO.Size = new System.Drawing.Size(27, 28);
            this.pbLO.TabIndex = 15;
            this.pbLO.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "INTERGRATION MOTOR CONTROL AND SCADA";
            // 
            // TrendTimer
            // 
            this.TrendTimer.Enabled = true;
            this.TrendTimer.Interval = 1000;
            this.TrendTimer.Tick += new System.EventHandler(this.TrendTimer_Tick);
            // 
            // btTrend
            // 
            this.btTrend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrend.Location = new System.Drawing.Point(509, 363);
            this.btTrend.Name = "btTrend";
            this.btTrend.Size = new System.Drawing.Size(75, 23);
            this.btTrend.TabIndex = 17;
            this.btTrend.Text = "TRENDS";
            this.btTrend.UseVisualStyleBackColor = true;
            this.btTrend.Click += new System.EventHandler(this.btTrend_Click);
            // 
            // VPBarLevel
            // 
            this.VPBarLevel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VPBarLevel.Location = new System.Drawing.Point(288, 123);
            this.VPBarLevel.Name = "VPBarLevel";
            this.VPBarLevel.Size = new System.Drawing.Size(57, 250);
            this.VPBarLevel.Step = 1;
            this.VPBarLevel.TabIndex = 13;
            this.VPBarLevel.Value = 50;
            // 
            // btAlarm
            // 
            this.btAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlarm.Location = new System.Drawing.Point(509, 392);
            this.btAlarm.Name = "btAlarm";
            this.btAlarm.Size = new System.Drawing.Size(75, 23);
            this.btAlarm.TabIndex = 18;
            this.btAlarm.Text = "ALARM";
            this.btAlarm.UseVisualStyleBackColor = true;
            this.btAlarm.Click += new System.EventHandler(this.btAlarm_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.btAlarm);
            this.Controls.Add(this.btTrend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLO);
            this.Controls.Add(this.pbHI);
            this.Controls.Add(this.VPBarLevel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.pbMotor3);
            this.Controls.Add(this.pbMotor2);
            this.Controls.Add(this.pbMotor1);
            this.Name = "Main";
            this.Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbMotor1;
        private System.Windows.Forms.PictureBox pbMotor2;
        private System.Windows.Forms.PictureBox pbMotor3;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private VerticalProgressBar VPBarLevel;
        private System.Windows.Forms.PictureBox pbHI;
        private System.Windows.Forms.PictureBox pbLO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TrendTimer;
        private System.Windows.Forms.Button btTrend;
        private System.Windows.Forms.Button btAlarm;
    }
}

