namespace NjustSchoolNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txt_uname = new System.Windows.Forms.TextBox();
            txt_pass = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            checkBox1 = new System.Windows.Forms.CheckBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            lbl_down = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            lbl_up = new System.Windows.Forms.Label();
            lbl_acc = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lbl_time = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lbl_balance = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            lbl_info = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            cmb_ras = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            checkBox2 = new System.Windows.Forms.CheckBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            lbl_help = new System.Windows.Forms.Label();
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(14, 187);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(110, 30);
            button1.TabIndex = 0;
            button1.Text = "&Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 16);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 17);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 51);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 17);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txt_uname
            // 
            txt_uname.Location = new System.Drawing.Point(85, 12);
            txt_uname.Margin = new System.Windows.Forms.Padding(4);
            txt_uname.Name = "txt_uname";
            txt_uname.Size = new System.Drawing.Size(170, 23);
            txt_uname.TabIndex = 2;
            // 
            // txt_pass
            // 
            txt_pass.Location = new System.Drawing.Point(83, 47);
            txt_pass.Margin = new System.Windows.Forms.Padding(4);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new System.Drawing.Size(172, 23);
            txt_pass.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(146, 187);
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(110, 30);
            button2.TabIndex = 0;
            button2.Text = "Log&out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(14, 118);
            checkBox1.Margin = new System.Windows.Forms.Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(114, 21);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(lbl_down);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lbl_up);
            groupBox1.Controls.Add(lbl_acc);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lbl_time);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lbl_balance);
            groupBox1.Location = new System.Drawing.Point(288, 16);
            groupBox1.Margin = new System.Windows.Forms.Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4);
            groupBox1.Size = new System.Drawing.Size(205, 241);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Info";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(148, 22);
            linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(52, 17);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "&Refresh";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lbl_down
            // 
            lbl_down.AutoSize = true;
            lbl_down.Location = new System.Drawing.Point(113, 200);
            lbl_down.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_down.Name = "lbl_down";
            lbl_down.Size = new System.Drawing.Size(39, 17);
            lbl_down.TabIndex = 1;
            lbl_down.Text = "0 MB";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(7, 200);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(103, 17);
            label11.TabIndex = 2;
            label11.Text = "Total Download:";
            // 
            // lbl_up
            // 
            lbl_up.AutoSize = true;
            lbl_up.Location = new System.Drawing.Point(97, 161);
            lbl_up.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_up.Name = "lbl_up";
            lbl_up.Size = new System.Drawing.Size(39, 17);
            lbl_up.TabIndex = 1;
            lbl_up.Text = "0 MB";
            // 
            // lbl_acc
            // 
            lbl_acc.AutoSize = true;
            lbl_acc.Location = new System.Drawing.Point(58, 43);
            lbl_acc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_acc.Name = "lbl_acc";
            lbl_acc.Size = new System.Drawing.Size(31, 17);
            lbl_acc.TabIndex = 1;
            lbl_acc.Text = "N/A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(7, 161);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(87, 17);
            label8.TabIndex = 2;
            label8.Text = "Total Upload:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(7, 43);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(46, 17);
            label7.TabIndex = 0;
            label7.Text = "Name:";
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Location = new System.Drawing.Point(84, 122);
            lbl_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new System.Drawing.Size(63, 17);
            lbl_time.TabIndex = 1;
            lbl_time.Text = "0d 0h 0m";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 122);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(72, 17);
            label5.TabIndex = 2;
            label5.Text = "Total Time:";
            // 
            // lbl_balance
            // 
            lbl_balance.AutoSize = true;
            lbl_balance.Location = new System.Drawing.Point(70, 82);
            lbl_balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_balance.Name = "lbl_balance";
            lbl_balance.Size = new System.Drawing.Size(15, 17);
            lbl_balance.TabIndex = 1;
            lbl_balance.Text = "0";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(14, 314);
            textBox1.Margin = new System.Windows.Forms.Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(440, 260);
            textBox1.TabIndex = 6;
            textBox1.TabStop = false;
            textBox1.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 144);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 17);
            label4.TabIndex = 7;
            label4.Text = "Info:";
            // 
            // lbl_info
            // 
            lbl_info.ForeColor = System.Drawing.Color.Red;
            lbl_info.Location = new System.Drawing.Point(57, 144);
            lbl_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new System.Drawing.Size(214, 39);
            lbl_info.TabIndex = 8;
            lbl_info.Text = "Last info shows here";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(14, 86);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(31, 17);
            label6.TabIndex = 1;
            label6.Text = "RAS";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(14, 226);
            button3.Margin = new System.Windows.Forms.Padding(4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(110, 30);
            button3.TabIndex = 9;
            button3.Text = "R&as Dial";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(146, 226);
            button4.Margin = new System.Windows.Forms.Padding(4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(110, 30);
            button4.TabIndex = 9;
            button4.Text = "&Hang up";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // cmb_ras
            // 
            cmb_ras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb_ras.FormattingEnabled = true;
            cmb_ras.Location = new System.Drawing.Point(52, 82);
            cmb_ras.Margin = new System.Windows.Forms.Padding(4);
            cmb_ras.Name = "cmb_ras";
            cmb_ras.Size = new System.Drawing.Size(180, 25);
            cmb_ras.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.DimGray;
            label9.Location = new System.Drawing.Point(1, 261);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(502, 17);
            label9.TabIndex = 11;
            label9.Text = "Copyleft with GPLv3 by Jennings all rigthts reversed! Commercial usage is forbidden!";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(131, 118);
            checkBox2.Margin = new System.Windows.Forms.Padding(4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(154, 21);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Specify dial credential";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 250;
            toolTip1.IsBalloon = true;
            toolTip1.ReshowDelay = 100;
            toolTip1.ToolTipTitle = "Tips";
            // 
            // lbl_help
            // 
            lbl_help.AutoSize = true;
            lbl_help.Cursor = System.Windows.Forms.Cursors.Hand;
            lbl_help.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lbl_help.ForeColor = System.Drawing.Color.Blue;
            lbl_help.Location = new System.Drawing.Point(240, 84);
            lbl_help.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_help.Name = "lbl_help";
            lbl_help.Size = new System.Drawing.Size(13, 16);
            lbl_help.TabIndex = 12;
            lbl_help.Text = "?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new System.Drawing.Point(7, 82);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(56, 17);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Balance:";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(507, 281);
            Controls.Add(lbl_help);
            Controls.Add(label9);
            Controls.Add(cmb_ras);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(lbl_info);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(txt_pass);
            Controls.Add(txt_uname);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Njust School Net Login v";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_up;
        private System.Windows.Forms.Label lbl_acc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_down;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmb_ras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

