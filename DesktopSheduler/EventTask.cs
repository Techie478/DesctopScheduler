using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DesktopSheduler
{
    [DataContract]
    class EventTask
    {
        [DataMember]
        string taskDescription { get; set; }

        [DataMember]
        bool isDone { get; set; }

        [DataMember]
        DateTime alarmTime { get; set; }

        [DataMember]
        bool isAlarmOn { get; set; }

        public EventTask(string taskDescription, bool isDone, DateTime alarmTime, bool isAlarmOn)
        {
            this.taskDescription = taskDescription;
            this.isDone = isDone;
            this.alarmTime = alarmTime;
            this.isAlarmOn = isAlarmOn;
        }
    }
}
