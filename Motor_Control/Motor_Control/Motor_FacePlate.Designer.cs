namespace Motor_Control
{
    partial class Motor_FacePlate
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
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.pbRunfeedback = new System.Windows.Forms.PictureBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.btReset = new System.Windows.Forms.Button();
            this.pbFault = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunfeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFault)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MODE";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(28, 64);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(81, 32);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btStart_MouseDown);
            this.btStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btStart_MouseUp);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(28, 111);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(81, 32);
            this.btStop.TabIndex = 3;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btStop_MouseDown);
            this.btStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btStop_MouseUp);
            // 
            // pbRunfeedback
            // 
            this.pbRunfeedback.Location = new System.Drawing.Point(28, 165);
            this.pbRunfeedback.Name = "pbRunfeedback";
            this.pbRunfeedback.Size = new System.Drawing.Size(59, 59);
            this.pbRunfeedback.TabIndex = 4;
            this.pbRunfeedback.TabStop = false;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 250;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // cbMode
            // 
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "MAN",
            "AUTO"});
            this.cbMode.Location = new System.Drawing.Point(92, 24);
            this.cbMode.MaxDropDownItems = 2;
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(100, 21);
            this.cbMode.TabIndex = 6;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(28, 245);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(81, 32);
            this.btReset.TabIndex = 7;
            this.btReset.Text = "RESET";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btReset_MouseDown);
            this.btReset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btReset_MouseUp);
            // 
            // pbFault
            // 
            this.pbFault.BackColor = System.Drawing.Color.Transparent;
            this.pbFault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFault.Location = new System.Drawing.Point(92, 198);
            this.pbFault.Name = "pbFault";
            this.pbFault.Size = new System.Drawing.Size(26, 26);
            this.pbFault.TabIndex = 8;
            this.pbFault.TabStop = false;
            // 
            // Motor_FacePlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 322);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.cbMode);
            this.Controls.Add(this.pbRunfeedback);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbFault);
            this.Name = "Motor_FacePlate";
            this.Text = "Motor_FacePlate";
            ((System.ComponentModel.ISupportInitialize)(this.pbRunfeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFault)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.PictureBox pbRunfeedback;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.PictureBox pbFault;
    }
}