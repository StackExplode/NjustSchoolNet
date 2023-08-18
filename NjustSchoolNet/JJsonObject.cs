using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace NjustSchoolNet
{
    public class JJsonObject
    {
        string json;
        public JJsonObject(string json)
        {
            this.json = json;
        }

        public T GetValue<T>()
        {
            return (T)Convert.ChangeType(json, typeof(T));
        }

        public string Value => json;
        public override string ToString()
        {
            return json;
        }

        public JJsonObject this[string key]
        {
            get
            {
                Dictionary<string, dynamic> dic = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(json);
                return new JJsonObject(dic[key].ToString());
            }
        }

        public JJsonObject this[int key]
        {
            get
            {
                dynamic[] arr = JsonSerializer.Deserialize<dynamic[]>(json);
                return new JJsonObject(arr[key].ToString());
            }
        }

        public JJsonObject this[string key, params int[] indexes]
        {
            get
            {
                dynamic[] arr = JsonSerializer.Deserialize<dynamic[]>(json);
                for(int i=0;i<indexes.Length-1;i++)
                {
                    arr = JsonSerializer.Deserialize<dynamic[]>(arr[i].ToString);
                }
                return new JJsonObject(arr[^1].ToString());
            }
        }
    }
}
