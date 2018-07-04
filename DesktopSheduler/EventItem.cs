using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DesktopSheduler
{
    [DataContract]
    public class EventItem
    {
        [DataMember]
        public DateTime date { get; set; }

        [DataMember]
        public List<EventTask> taskList { get; set; }

        public EventItem(DateTime date, List<EventTask> taskList)
        {
            this.date = date;
            this.taskList = taskList;
        }

        public EventItem()
        {
        
        }

        public void addTask(EventTask task) {
            taskList.Add(task);
        }

        public void deleteTask(EventTask task) {
            taskList.Remove(task);
        }

        public void clearAllTask() {
            taskList.RemoveRange(0, taskList.Count);
        }
    }
}
