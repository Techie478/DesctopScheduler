namespace DesktopSheduler
{
    partial class TaskInputBox
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
            this.taskDesc = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.isAlaramOn = new System.Windows.Forms.CheckBox();
            this.alarmTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskDesc
            // 
            this.taskDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskDesc.Location = new System.Drawing.Point(30, 105);
            this.taskDesc.Multiline = true;
            this.taskDesc.Name = "taskDesc";
            this.taskDesc.Size = new System.Drawing.Size(417, 151);
            this.taskDesc.TabIndex = 0;
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Yu Gothic", 13.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.date.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.date.Checked = false;
            this.date.Font = new System.Drawing.Font("Tahoma", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(99, 12);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(281, 34);
            this.date.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(181, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task Description";
            // 
            // isAlaramOn
            // 
            this.isAlaramOn.AutoSize = true;
            this.isAlaramOn.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isAlaramOn.Location = new System.Drawing.Point(65, 278);
            this.isAlaramOn.Name = "isAlaramOn";
            this.isAlaramOn.Size = new System.Drawing.Size(121, 23);
            this.isAlaramOn.TabIndex = 4;
            this.isAlaramOn.Text = "Remind you?";
            this.isAlaramOn.UseVisualStyleBackColor = true;
            // 
            // alarmTime
            // 
            this.alarmTime.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.alarmTime.Location = new System.Drawing.Point(313, 276);
            this.alarmTime.Name = "alarmTime";
            this.alarmTime.ShowUpDown = true;
            this.alarmTime.Size = new System.Drawing.Size(67, 27);
            this.alarmTime.TabIndex = 5;
            this.alarmTime.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(246, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time : ";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(65, 320);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(162, 47);
            this.submit.TabIndex = 7;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(233, 320);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(162, 47);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // TaskInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(473, 379);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alarmTime);
            this.Controls.Add(this.isAlaramOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.taskDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskInputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TaskInputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EventTask newTask;
        private System.Windows.Forms.TextBox taskDesc;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isAlaramOn;
        private System.Windows.Forms.DateTimePicker alarmTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
    }
}