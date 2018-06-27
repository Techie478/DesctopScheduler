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
    
            arrayList.Add(eventItem);
            MemoryStream msObj = new MemoryStream();
            try
            {
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
            try {
                StreamReader sr = new StreamReader(filePath);
                string json = sr.ReadToEnd();

                MemoryStream msObj = new MemoryStream(Encoding.UTF8.GetBytes(json));
                arrayList = jsonSerializer.ReadObject(msObj) as List<EventItem>;
                msObj.Close();
                sr.Close();

                if (arrayList == null)
                    arrayList = new List<EventItem>();
            }
            catch(Exception e) {
                arrayList = new List<EventItem>();
            }

            return arrayList;
          }
       
    }
}
