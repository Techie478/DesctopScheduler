using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;

namespace DesktopSheduler
{

    class JSONLoader
    {
        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<EventItem>));
        string filePath = "eventList.json";


        public void Write(EventItem eventItem) {
          
            List<EventItem> arrayList = Read();
            var evnt = arrayList.Find(x => x.date.Date == eventItem.date.Date);
            if (evnt != null)
            {
                arrayList.Remove(evnt);
                arrayList.Add(eventItem);
               // evnt = eventItem;
            }
            else
            {
                arrayList.Add(eventItem);
            }
     
            MemoryStream msObj = new MemoryStream();
            try
            {
                File.WriteAllText(filePath,String.Empty);
                jsonSerializer.WriteObject(msObj, arrayList);
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);              
                msObj.WriteTo(fs);
             
                fs.Flush();
                fs.Close();
            }
            catch(Exception e) {
                MessageBox.Show("Не удается найти указаный файл " + e.Message);
               
            }   
        }

        public List<EventItem> Read() {
            List<EventItem> arrayList;
            MemoryStream msObj = null;
            StreamReader sr = null;
            try {
                 sr = new StreamReader(filePath);
                string json = sr.ReadToEnd();

                msObj = new MemoryStream(Encoding.UTF8.GetBytes(json));
                arrayList = jsonSerializer.ReadObject(msObj) as List<EventItem>;
              
                if (arrayList == null)
                    arrayList = new List<EventItem>();
            }
            catch(Exception e) {
                arrayList = new List<EventItem>();
            }

            if (msObj != null && sr != null)
            {
                msObj.Close();
                sr.Close();
            }

            return arrayList;
          }
       
    }
}
