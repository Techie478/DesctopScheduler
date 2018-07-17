using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopSheduler
{
    public partial class Form1 : Form
    {
        private DateTime currentMonth = DateTime.Today;

        public Form1()
        {
            InitializeComponent();
            SetCurrentDate(currentMonth);
            ChangeMonth(DateTime.Today);
        }

        private void ChangeMonth(DateTime time) {
           this.datesButtonList = SetCalendarDates(time);
        }

        private void CreateNewTask(object sender, EventArgs e)
        {
            TaskInputBox inputBox = new TaskInputBox();
            inputBox.ShowDialog();
            EventTask task = inputBox.newTask;

            if (task != null)
                AddTaskToDay(task);
        }

        private void DeleteTask(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you realy want to delete this task?.", "Delete", MessageBoxButtons.YesNo,
             MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
               foreach (DataGridViewRow row in this.toDoListGrid.SelectedRows)
                 {
                    DeleteTaskOfDay(row.DataBoundItem as EventTask);                  
                 }
            }
          
        }

        private void SaveChange(object sender, EventArgs e)
        {
            SaveAllEventItem();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toDoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void setPrevMonth(object sender, EventArgs e)
        {
            currentMonth = new DateTime(currentMonth.Year, currentMonth.Month - 1, 1);
            ChangeMonth(currentMonth);
        }
        private void setNextMonth(object sender, EventArgs e)
        {
            currentMonth = new DateTime(currentMonth.Year, currentMonth.Month + 1, 1);
            ChangeMonth(currentMonth);
        }
        private void setCurrentMonth(object sender, EventArgs e)
        {
            currentMonth = DateTime.Today;
            ChangeMonth(currentMonth);
        }
    }
}
