using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using System.Text.Json;
using System.Diagnostics;
using Microsoft.Win32;
using System.Collections.Specialized;
using System.Web;
using DotRas;
using System.Linq;

namespace NjustSchoolNet
{
    public static class Helpers
    {
        static Dictionary<string, string> headers;
        static Helpers()
        {
            headers = new Dictionary<string, string>();
            headers.Add("Referer", "http://m.njust.edu.cn/portal/index.html");
            headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.198 Safari/537.36");
            headers.Add("Origin", "http://m.njust.edu.cn");
            headers.Add("Content-Type", "application/x-www-form-urlencoded");
        }

        public static Dictionary<string, string> Login_Header => headers;

        public static async Task<string> HttpPostAsync(string url, Dictionary<string, string> header = null, string body = null)
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
            req.Method = "POST";
            if(header != null)
            {
                foreach(var h in header)
                {
                    req.Headers.Add(h.Key, h.Value);
                }
            }
            Stream reqstream = null;
            try
            {
                reqstream = await req.GetRequestStreamAsync();
                if (body is not null && body.Length > 0)
                {
                    StreamWriter sw = new StreamWriter(reqstream);
                    await sw.WriteAsync(body);
                    Debug.WriteLine(body);
                    sw.Close();
                }
            }
            finally
            {
                reqstream?.Close();
            }
            HttpWebResponse res = (HttpWebResponse)await req.GetResponseAsync();
            string rt = null;
            Stream resstream = null;
            try
            {
                resstream = res.GetResponseStream();
                StreamReader sr = new StreamReader(resstream);
                rt = await sr.ReadToEndAsync();
                sr.Close();
            }
            finally
            {
                resstream?.Close();
            }
            return rt;
        }

        public static string Json_GetVal(string json, params string[] keys)
        {
            Dictionary<string, dynamic> dic = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(json);
            for(int i=0;i<keys.Length-1;i++)
            {
                dic = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(dic[keys[i]].ToString());
            }
            return dic[keys[^1]].ToString();
        }

        public static (string Uname, string Pass, string dial, bool dailpass) LoadConfigFromReg()
        {
            RegistryKey SoftwareKey = Registry.LocalMachine.OpenSubKey("Software", true);
            RegistryKey AppNameKey = SoftwareKey.OpenSubKey("NjustSchoolNetLogin", true);
            if (AppNameKey is null)
                SaveConfigToReg("", "", "", false);
            AppNameKey = SoftwareKey.OpenSubKey("NjustSchoolNetLogin", true);
            return (AppNameKey.GetValue("uname").ToString(),
                AppNameKey.GetValue("pass").ToString(),
                AppNameKey.GetValue("dial").ToString(),
                AppNameKey.GetValue("dialpass").Equals("0") ? false : true
                ) ;
        }

        public static void SaveConfigToReg(string uname, string pass, string dial,bool dialpass)
        {
            RegistryKey SoftwareKey = Registry.LocalMachine.OpenSubKey("Software", true);

            RegistryKey AppNameKey = SoftwareKey.CreateSubKey("NjustSchoolNetLogin");

            AppNameKey.SetValue("uname", uname);
            AppNameKey.SetValue("pass", pass);
            AppNameKey.SetValue("dial", dial);
            AppNameKey.SetValue("dialpass", dialpass ? "1" : "0");
        }

        public static int Login(string uname,string pass)
        {
            NameValueCollection outgoingQueryString = HttpUtility.ParseQueryString(String.Empty);
            outgoingQueryString.Add("username", uname);
            outgoingQueryString.Add("password", pass);
            string data = outgoingQueryString.ToString();

            var task = Helpers.HttpPostAsync(Properties.Resources.login_url, Helpers.Login_Header, data);
            task.RunSynchronously();
            string rt = task.Result;
            
            JJsonObject json = new JJsonObject(rt);

            return json["reply_code"].GetValue<int>();
        }

        public static int Logout()
        {
            var task = Helpers.HttpPostAsync(Properties.Resources.logout_url);
            task.RunSynchronously();
            string rt = task.Result;

            JJsonObject json = new JJsonObject(rt);

            return json["reply_code"].GetValue<int>();
        }

        public static int LogAuto()
        {
            var save = LoadConfigFromReg();
            return Login(save.Uname, save.Pass);
        }

        public static int Dial(string entry,string user = null, string pass = null)
        {
            RasDialer dia = new RasDialer();
            if(entry is null)
            {
               (var uuu, var ppp, dia.EntryName, bool dialpass) = Helpers.LoadConfigFromReg();
                if(dialpass)
                {
                    dia.Credentials = new NetworkCredential(uuu, ppp);
                }
            }
            else
            {
                dia.EntryName = entry;
                if(user is not null)
                {
                    dia.Credentials = new NetworkCredential(user, pass);
                }
            }


            RasConnection con = null;
            try
            {
                con = dia.Connect();
            }
            catch
            {
                return 2;
            }
            return con is null ? 1 : 0;
        }

        public static int HangUp(int n)
        {
            var cons = RasConnection.EnumerateConnections();
            if (cons is null || cons.Count() <= 0 || n >= cons.Count())
                return 1;
            var con = cons.ElementAt(n);
            try
            {
                con.Disconnect();
            }
            catch
            {
                return 2;
            }
            
            return 0;
        }

        public static (string value, string unit) NormalizeByte(long val)
        {
            string rt_v = "", rt_u = "B";

            int wei = (int)Math.Log2(val) / 10;          
            var arr = val.ToString().ToCharArray();
            int md = (arr.Length - 1) % 3;

            if (arr.Length > 3 && md > 0)
            {
                
                switch(md)
                {
                    case 1:
                        rt_v += arr[0];
                        rt_v += arr[1];
                        rt_v += '.';
                        rt_v += arr[2];
                        rt_v += arr[3];
                        break;
                    case 2:
                        rt_v += arr[0];
                        rt_v += arr[1];
                        rt_v += arr[2];
                        rt_v += '.';
                        rt_v += arr[3];
                        break;
                }
            }
            else
            {
                int len = Math.Min(arr.Length, 4);
                for(int i = 0; i < len; i++)
                    rt_v += arr[i];
                wei -= 1;
            }

            switch (wei)
            {
                case 0: rt_u = "B"; break;
                case 1: rt_u = "kB"; break;
                case 2: rt_u = "MB"; break;
                case 3: rt_u = "GB"; break;
                case 4: rt_u = "TB"; break;
                case 5: rt_u = "PB"; break;
            }

            return (rt_v, rt_u);
            

        }
    }
}
