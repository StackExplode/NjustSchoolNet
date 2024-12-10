using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

using DotRas;

namespace NjustSchoolNet
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            var ver = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text += $"{ver.Major}.{ver.Minor}";

            string chk_tooltip = """
                If checked dialing will use username and password above.
                Otherwise, dialing will use credential stored in system.
                """;
            toolTip1.SetToolTip(checkBox2, chk_tooltip);

            toolTip1.SetToolTip(lbl_help, "If you can't see any RAS entries, please add a PPPoE connection via Windows setting.");

        }


        void OnOffControls(bool en)
        {
            txt_pass.Enabled = txt_uname.Enabled = button1.Enabled = button2.Enabled = linkLabel1.Enabled = en;
            button3.Enabled = button4.Enabled = cmb_ras.Enabled = en;
            checkBox1.Enabled = checkBox2.Enabled = en;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            OnOffControls(false);
            string rt = await Helpers.HttpPostAsync(Properties.Resources.logout_url, null, "{\"domain\":\"default\"}");
            OnOffControls(true);
            JJsonObject json = new JJsonObject(rt);
            if (json["reply_code"].GetValue<int>() != 0)
                lbl_info.Text = json["reply_msg"].Value;
            else
                lbl_info.Text = "Success!";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Helpers.SaveConfigToReg(txt_uname.Text, txt_pass.Text, cmb_ras.SelectedItem.ToString(), checkBox2.Checked);

            OnOffControls(false);
            string uname = txt_uname.Text;
            string pass = txt_pass.Text;
            //             NameValueCollection outgoingQueryString = HttpUtility.ParseQueryString(String.Empty);
            //             outgoingQueryString.Add("username", uname);
            //             outgoingQueryString.Add("password", pass);
            //             string data = outgoingQueryString.ToString();

            string data = $"{{\"domain\":\"default\",\"username\":\"{uname}\",\"password\":\"{pass}\"}}: ";

            string rt = await Helpers.HttpPostAsync(Properties.Resources.login_url, Helpers.Login_Header, data);


            JJsonObject json = new JJsonObject(rt);
            if (json["reply_code"].GetValue<int>() != 0)
                lbl_info.Text = json["reply_msg"].Value;
            else
                lbl_info.Text = "Success!";
            if (json["reply_code"].GetValue<int>() != 0)
            {
                OnOffControls(true);
                return;
            }


            await Task.Delay(3000);

            linkLabel1_LinkClicked(null, null);
            OnOffControls(true);
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnOffControls(false);
            string rt0 = await Helpers.HttpGetAsync(Properties.Resources.userinfo_url);
            string rt = await Helpers.HttpGetAsync(Properties.Resources.setinfo_url + $"{DateTime.Now.ToString("yyyyMM")}");
            OnOffControls(true);
            textBox1.Text = rt;
            JJsonObject json = new JJsonObject(rt);

            if (json["reply_code"].GetValue<int>() != 0)
            {
                lbl_time.Text = json["reply_msg"].Value;
                lbl_up.Text = string.Empty;
                lbl_down.Text = string.Empty;

            }
            else
            {
                var row = json["results"]["rows"][0];
                int time = row["total_time"].GetValue<int>();
                TimeSpan ts = new TimeSpan(0, 0, time);
                lbl_time.Text = $"{(int)ts.TotalHours}h {ts.Minutes}m";
                var up = Helpers.NormalizeByte(row["total_input_octets_ipv4"].GetValue<long>());
                var down = Helpers.NormalizeByte(row["total_output_octets_ipv4"].GetValue<long>());
                lbl_up.Text = up.value + " " + up.unit;
                lbl_down.Text = down.value + " " + down.unit;
            }



            JJsonObject json00 = new JJsonObject(rt0);

            if (json00["reply_code"].GetValue<int>() != 0)
            {
                lbl_balance.Text = string.Empty;
                lbl_acc.Text = json00["reply_msg"].Value;
                lbl_info.Text = "Refresh Data Failed!";
            }
            else
            {
                JJsonObject json0 = new JJsonObject(json00["results"]["rows"][0].ToString());
                lbl_acc.Text = json0["fullname"].Value;
                lbl_balance.Text = (json0["balance"].GetValue<int>() / 100.0).ToString() + " yuan";
                lbl_info.Text = "Refresh Data Success!";
            }


        }

        private async void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            OnOffControls(false);
            string rt = await Helpers.HttpGetAsync(Properties.Resources.account_url);
            OnOffControls(true);

            JJsonObject json = new JJsonObject(rt);

            if (json["reply_code"].GetValue<int>() != 0)
            {
                sb.Append(json["reply_msg"].Value);
            }
            else
            {
                int len = json["results"]["total"].GetValue<int>();
                for(int i = 0; i< len;i++)
                {
                    var row = json["results"]["rows"][i];
                    sb.Append($"{row["sub_account_name"]} : {(row["balance"].GetValue<int>() / 1000.0)} yuan");
                    sb.Append(Environment.NewLine);
                }
            }
            MessageBox.Show(sb.ToString(),"Query Balance");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var save = Helpers.LoadConfigFromReg();
            if (save.Uname.Length > 0)
            {
                txt_uname.Text = save.Uname;
                txt_pass.Text = save.Pass;
                checkBox1.Checked = true;
            }

            RasHelper.EnumEntries(out var rrr, out _);
            foreach (var r in rrr)
            {
                cmb_ras.Items.Add(r);
            }
            RasHelper.GetDefaultEntry(out string defent, out _);
            if (defent is not null)
                cmb_ras.SelectedItem = defent;
            else if (cmb_ras.Items.Count > 0)
                cmb_ras.SelectedIndex = 0;

            if (save.dial is not null && save.dial.Length > 0)
                cmb_ras.SelectedItem = save.dial;
            if (save.dailpass)
                checkBox2.Checked = true;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                Helpers.SaveConfigToReg("", "", "", false);
        }

        RasConnection ras_con = null;
        private async void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Helpers.SaveConfigToReg(txt_uname.Text, txt_pass.Text, cmb_ras.SelectedItem.ToString(), checkBox2.Checked);

            RasDialer dia = new RasDialer();
            dia.EntryName = cmb_ras.SelectedItem.ToString();
            if (checkBox2.Checked)
            {
                dia.Credentials = new System.Net.NetworkCredential(txt_uname.Text, txt_pass.Text);
            }
            dia.Error += (_, e) => { this.Invoke(() => lbl_info.Text = "Dial error: " + e.GetException().Message); };
            dia.StateChanged += (_, e) => { this.Invoke(() => lbl_info.Text = "Dial state: " + e.State.ToString()); };
            this.Invoke(() => lbl_info.Text = "Connecting to PPPoE...");
            OnOffControls(false);
            try
            {
                ras_con = await dia.ConnectAsync();
            }
            catch (Exception ex)
            {
                this.Invoke(() => lbl_info.Text = "Dial error: " + ex.Message);
            }
            finally
            {
                OnOffControls(true);
            }

        }


        private async void button4_Click(object sender, EventArgs e)
        {

            if (ras_con is not null)
            {
                this.Invoke(() => lbl_info.Text = "Disconnecting PPPoE...");
                OnOffControls(false);
                await ras_con.DisconnectAsync();
                ras_con = null;
                OnOffControls(true);
                this.Invoke(() => lbl_info.Text = "Disconnect Finished!");
            }
            else
            {
                var cons = RasConnection.EnumerateConnections();
                if (cons is null || cons.Count() <= 0)
                {
                    lbl_info.Text = "No PPPoE connection to close!";
                    return;
                }
                else
                {
                    var con = cons.ElementAt(0);
                    this.Invoke(() => lbl_info.Text = "Disconnecting PPPoE...");
                    OnOffControls(false);
                    await con.DisconnectAsync();
                    OnOffControls(true);
                    this.Invoke(() => lbl_info.Text = "Disconnect Finished!");
                }
            }

        }

        
    }
}
