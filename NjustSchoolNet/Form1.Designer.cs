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
            label3 = new System.Windows.Forms.Label();
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 143);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 23);
            button1.TabIndex = 0;
            button1.Text = "&Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 13);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 13);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txt_uname
            // 
            txt_uname.Location = new System.Drawing.Point(73, 9);
            txt_uname.Name = "txt_uname";
            txt_uname.Size = new System.Drawing.Size(146, 21);
            txt_uname.TabIndex = 2;
            // 
            // txt_pass
            // 
            txt_pass.Location = new System.Drawing.Point(71, 36);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new System.Drawing.Size(148, 21);
            txt_pass.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(125, 143);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 23);
            button2.TabIndex = 0;
            button2.Text = "Log&out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(12, 90);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(94, 17);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox1
            // 
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
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new System.Drawing.Point(247, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(176, 184);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Info";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(127, 17);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(45, 13);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "&Refresh";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lbl_down
            // 
            lbl_down.AutoSize = true;
            lbl_down.Location = new System.Drawing.Point(97, 153);
            lbl_down.Name = "lbl_down";
            lbl_down.Size = new System.Drawing.Size(30, 13);
            lbl_down.TabIndex = 1;
            lbl_down.Text = "0 MB";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(6, 153);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(85, 13);
            label11.TabIndex = 2;
            label11.Text = "Total Download:";
            // 
            // lbl_up
            // 
            lbl_up.AutoSize = true;
            lbl_up.Location = new System.Drawing.Point(83, 123);
            lbl_up.Name = "lbl_up";
            lbl_up.Size = new System.Drawing.Size(30, 13);
            lbl_up.TabIndex = 1;
            lbl_up.Text = "0 MB";
            // 
            // lbl_acc
            // 
            lbl_acc.AutoSize = true;
            lbl_acc.Location = new System.Drawing.Point(50, 33);
            lbl_acc.Name = "lbl_acc";
            lbl_acc.Size = new System.Drawing.Size(25, 13);
            lbl_acc.TabIndex = 1;
            lbl_acc.Text = "N/A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 123);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(71, 13);
            label8.TabIndex = 2;
            label8.Text = "Total Upload:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 33);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(38, 13);
            label7.TabIndex = 0;
            label7.Text = "Name:";
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Location = new System.Drawing.Point(72, 93);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new System.Drawing.Size(51, 13);
            lbl_time.TabIndex = 1;
            lbl_time.Text = "0d 0h 0m";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 93);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 13);
            label5.TabIndex = 2;
            label5.Text = "Total Time:";
            // 
            // lbl_balance
            // 
            lbl_balance.AutoSize = true;
            lbl_balance.Location = new System.Drawing.Point(60, 63);
            lbl_balance.Name = "lbl_balance";
            lbl_balance.Size = new System.Drawing.Size(13, 13);
            lbl_balance.TabIndex = 1;
            lbl_balance.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 63);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 13);
            label3.TabIndex = 0;
            label3.Text = "Balance:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 240);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(378, 200);
            textBox1.TabIndex = 6;
            textBox1.TabStop = false;
            textBox1.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 110);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(31, 13);
            label4.TabIndex = 7;
            label4.Text = "Info:";
            // 
            // lbl_info
            // 
            lbl_info.ForeColor = System.Drawing.Color.Red;
            lbl_info.Location = new System.Drawing.Point(49, 110);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new System.Drawing.Size(183, 30);
            lbl_info.TabIndex = 8;
            lbl_info.Text = "Last info shows here";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 66);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(27, 13);
            label6.TabIndex = 1;
            label6.Text = "RAS";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(12, 173);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(94, 23);
            button3.TabIndex = 9;
            button3.Text = "R&as Dial";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(125, 173);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(94, 23);
            button4.TabIndex = 9;
            button4.Text = "&Hang up";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // cmb_ras
            // 
            cmb_ras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb_ras.FormattingEnabled = true;
            cmb_ras.Location = new System.Drawing.Point(45, 63);
            cmb_ras.Name = "cmb_ras";
            cmb_ras.Size = new System.Drawing.Size(155, 21);
            cmb_ras.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.DimGray;
            label9.Location = new System.Drawing.Point(12, 199);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(413, 13);
            label9.TabIndex = 11;
            label9.Text = "Copyleft with GPLv3 by Jennings all rigthts reversed! Commercial usage is forbidden!";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(112, 90);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(130, 17);
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
            lbl_help.Location = new System.Drawing.Point(206, 64);
            lbl_help.Name = "lbl_help";
            lbl_help.Size = new System.Drawing.Size(13, 16);
            lbl_help.TabIndex = 12;
            lbl_help.Text = "?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(435, 215);
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
        private System.Windows.Forms.Label label3;
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
    }
}

