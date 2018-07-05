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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            SetCurrentDate(DateTime.Today);
            
            this.datesButtonList = SetCalendarDates(DateTime.Today);
        }

        

        private void CreateNewTask(object sender, EventArgs e)
        {
            TaskInputBox inputBox = new TaskInputBox();
            inputBox.ShowDialog();
            EventTask task = inputBox.newTask;

            if (task != null)
                UpdateDay(task);
        }

        private void DeleteTask(object sender, EventArgs e)
        {

        }

        private void EditTask(object sender, EventArgs e)
        {

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
    }
}
