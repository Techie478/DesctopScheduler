using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace DesktopSheduler
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toDoPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.currentWeekDay = new System.Windows.Forms.Label();
            this.currentMnthYear = new System.Windows.Forms.Label();
            this.currentDay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datesTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toDoPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.toDoPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 638);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 395);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 215);
            this.panel4.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(230)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(18, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Edit ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(230)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(18, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete this task";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(230)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(18, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create new";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Actions";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // toDoPanel
            // 
            this.toDoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.toDoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toDoPanel.Controls.Add(this.tableLayoutPanel1);
            this.toDoPanel.Controls.Add(this.label3);
            this.toDoPanel.Location = new System.Drawing.Point(3, 174);
            this.toDoPanel.Name = "toDoPanel";
            this.toDoPanel.Size = new System.Drawing.Size(194, 215);
            this.toDoPanel.TabIndex = 0;
            this.toDoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toDoPanel_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.42424F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(181, 160);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "To Do";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.currentWeekDay);
            this.panel3.Controls.Add(this.currentMnthYear);
            this.panel3.Controls.Add(this.currentDay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 168);
            this.panel3.TabIndex = 0;
            // 
            // currentWeekDay
            // 
            this.currentWeekDay.AutoSize = true;
            this.currentWeekDay.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentWeekDay.ForeColor = System.Drawing.Color.White;
            this.currentWeekDay.Location = new System.Drawing.Point(41, 126);
            this.currentWeekDay.Name = "currentWeekDay";
            this.currentWeekDay.Size = new System.Drawing.Size(126, 18);
            this.currentWeekDay.TabIndex = 2;
            this.currentWeekDay.Text = "понедельник";
            this.currentWeekDay.Click += new System.EventHandler(this.label2_Click);
            // 
            // currentMnthYear
            // 
            this.currentMnthYear.AutoSize = true;
            this.currentMnthYear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentMnthYear.ForeColor = System.Drawing.Color.White;
            this.currentMnthYear.Location = new System.Drawing.Point(39, 108);
            this.currentMnthYear.Name = "currentMnthYear";
            this.currentMnthYear.Size = new System.Drawing.Size(19, 18);
            this.currentMnthYear.TabIndex = 1;
            this.currentMnthYear.Text = "6";
            this.currentMnthYear.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentDay
            // 
            this.currentDay.AutoSize = true;
            this.currentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentDay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currentDay.Location = new System.Drawing.Point(25, 0);
            this.currentDay.Name = "currentDay";
            this.currentDay.Size = new System.Drawing.Size(151, 108);
            this.currentDay.TabIndex = 0;
            this.currentDay.Text = "25";
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.datesTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 638);
            this.panel2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(580, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Sun.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(497, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Sat.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(414, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Fri.";
            this.label9.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(328, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Thu.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(239, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Wed.";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(158, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tue.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(75, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mon.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // datesTable
            // 
            this.datesTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.datesTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.datesTable.ColumnCount = 7;
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.Location = new System.Drawing.Point(54, 113);
            this.datesTable.Name = "datesTable";
            this.datesTable.RowCount = 7;
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.Size = new System.Drawing.Size(580, 502);
            this.datesTable.TabIndex = 5;
            this.datesTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toDoPanel.ResumeLayout(false);
            this.toDoPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
         #endregion


        private void SetCalendarDates() {
            Calendar calendar = CultureInfo.InvariantCulture.Calendar;
           
            for (int i = 0; i < 7; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            Label text = new Label();
                            text.Text = calendar.GetDayOfMonth(DateTime.Today).ToString();
                            datesTable.Controls.Add(text,j,i);
                        }
                    }
         }


        private void SetCurrentDate(Label currentDay, Label currentWeekDay, Label currentMnthYear, DateTime dateTime) {
            currentDay.Text = dateTime.Day.ToString();
            currentMnthYear.Text = dateTime.ToString("MMMM") + " " + dateTime.Year;
            currentWeekDay.Text = dateTime.ToString("dddd");
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label currentDay;
        private System.Windows.Forms.Label currentMnthYear;
        private System.Windows.Forms.Panel toDoPanel;
        private System.Windows.Forms.Label currentWeekDay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel datesTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
       
    }
}

