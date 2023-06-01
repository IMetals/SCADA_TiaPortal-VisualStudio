namespace Motor_Control
{
    partial class Alarms
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
            this.gbAlarm = new System.Windows.Forms.GroupBox();
            this.dgvAlarm = new System.Windows.Forms.DataGridView();
            this.AlarmTimer = new System.Windows.Forms.Timer(this.components);
            this.gbAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAlarm
            // 
            this.gbAlarm.Controls.Add(this.dgvAlarm);
            this.gbAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlarm.Location = new System.Drawing.Point(0, 0);
            this.gbAlarm.Name = "gbAlarm";
            this.gbAlarm.Size = new System.Drawing.Size(665, 309);
            this.gbAlarm.TabIndex = 1;
            this.gbAlarm.TabStop = false;
            this.gbAlarm.Text = "Cảnh báo mực nước";
            // 
            // dgvAlarm
            // 
            this.dgvAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlarm.Location = new System.Drawing.Point(3, 22);
            this.dgvAlarm.Name = "dgvAlarm";
            this.dgvAlarm.ReadOnly = true;
            this.dgvAlarm.Size = new System.Drawing.Size(659, 284);
            this.dgvAlarm.TabIndex = 0;
            // 
            // AlarmTimer
            // 
            this.AlarmTimer.Enabled = true;
            this.AlarmTimer.Interval = 1000;
            this.AlarmTimer.Tick += new System.EventHandler(this.AlarmTimer_Tick);
            // 
            // Alarms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 309);
            this.Controls.Add(this.gbAlarm);
            this.Name = "Alarms";
            this.Text = "Alarms";
            this.gbAlarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAlarm;
        private System.Windows.Forms.DataGridView dgvAlarm;
        private System.Windows.Forms.Timer AlarmTimer;
    }
}