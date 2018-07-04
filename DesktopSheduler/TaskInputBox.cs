using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopSheduler
{
    public partial class TaskInputBox : Form
    {
        public EventTask newTask { get; set; }

        public TaskInputBox()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_creation(object sender, EventArgs e)
        {
            this.newTask = null;
            this.Close();
        }

        private void Submit_form(object sender, EventArgs e) {
            alarmTime.Value = new DateTime(date.Value.Year, date.Value.Month, date.Value.Day, 
                                            alarmTime.Value.Hour, alarmTime.Value.Minute, alarmTime.Value.Second);

            this.newTask = new EventTask(this.taskDesc.Text,false,alarmTime.Value, this.isAlaramOn.Checked);
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
