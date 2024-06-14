namespace Wifi_Xfree
{
    partial class WifiXFree
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WifiXFree));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.switch_wifi = new Guna.UI2.WinForms.Guna2Panel();
            this.name_wf_connect = new System.Windows.Forms.Label();
            this.connect_label = new System.Windows.Forms.Label();
            this.switchWifi = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.status_wifi = new System.Windows.Forms.Label();
            this.btn_scanWifi = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_password = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_uploadfile = new Guna.UI2.WinForms.Guna2Button();
            this.listview_password = new System.Windows.Forms.ListView();
            this.btn_savepass = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addpass = new Guna.UI2.WinForms.Guna2Button();
            this.tb_addpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.IP_network = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            this.switch_wifi.SuspendLayout();
            this.panel_password.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 10;
            this.guna2GradientPanel1.Controls.Add(this.listBox1);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(4, 73);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(525, 391);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(472, 368);
            this.listBox1.TabIndex = 0;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BorderRadius = 5;
            this.guna2VScrollBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2VScrollBar1.HoverState.Parent = null;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(306, 91);
            this.guna2VScrollBar1.MouseWheelBarPartitions = 10;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.PressedState.Parent = this.guna2VScrollBar1;
            this.guna2VScrollBar1.ScrollbarSize = 16;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 324);
            this.guna2VScrollBar1.TabIndex = 1;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            // 
            // switch_wifi
            // 
            this.switch_wifi.BackColor = System.Drawing.Color.Transparent;
            this.switch_wifi.BorderColor = System.Drawing.Color.Black;
            this.switch_wifi.BorderRadius = 10;
            this.switch_wifi.BorderThickness = 1;
            this.switch_wifi.Controls.Add(this.guna2Button1);
            this.switch_wifi.Controls.Add(this.IP_network);
            this.switch_wifi.Controls.Add(this.name_wf_connect);
            this.switch_wifi.Controls.Add(this.connect_label);
            this.switch_wifi.Controls.Add(this.switchWifi);
            this.switch_wifi.Controls.Add(this.status_wifi);
            this.switch_wifi.Controls.Add(this.btn_scanWifi);
            this.switch_wifi.Controls.Add(this.button1);
            this.switch_wifi.CustomBorderThickness = new System.Windows.Forms.Padding(-1);
            this.switch_wifi.Location = new System.Drawing.Point(4, 0);
            this.switch_wifi.Name = "switch_wifi";
            this.switch_wifi.ShadowDecoration.Parent = this.switch_wifi;
            this.switch_wifi.Size = new System.Drawing.Size(940, 67);
            this.switch_wifi.TabIndex = 2;
            // 
            // name_wf_connect
            // 
            this.name_wf_connect.AutoSize = true;
            this.name_wf_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_wf_connect.Location = new System.Drawing.Point(148, 35);
            this.name_wf_connect.Name = "name_wf_connect";
            this.name_wf_connect.Size = new System.Drawing.Size(93, 20);
            this.name_wf_connect.TabIndex = 8;
            this.name_wf_connect.Text = "NameWifiCt";
            // 
            // connect_label
            // 
            this.connect_label.AutoSize = true;
            this.connect_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_label.Location = new System.Drawing.Point(35, 37);
            this.connect_label.Name = "connect_label";
            this.connect_label.Size = new System.Drawing.Size(96, 20);
            this.connect_label.TabIndex = 7;
            this.connect_label.Text = "Connected";
            // 
            // switchWifi
            // 
            this.switchWifi.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchWifi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchWifi.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchWifi.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchWifi.CheckedState.Parent = this.switchWifi;
            this.switchWifi.Location = new System.Drawing.Point(178, 12);
            this.switchWifi.Name = "switchWifi";
            this.switchWifi.ShadowDecoration.Parent = this.switchWifi;
            this.switchWifi.Size = new System.Drawing.Size(35, 20);
            this.switchWifi.TabIndex = 5;
            this.switchWifi.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchWifi.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchWifi.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchWifi.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchWifi.UncheckedState.Parent = this.switchWifi;
            this.switchWifi.CheckedChanged += new System.EventHandler(this.switchWifi_CheckedChanged);
            // 
            // status_wifi
            // 
            this.status_wifi.AutoSize = true;
            this.status_wifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_wifi.Location = new System.Drawing.Point(35, 12);
            this.status_wifi.Name = "status_wifi";
            this.status_wifi.Size = new System.Drawing.Size(97, 20);
            this.status_wifi.TabIndex = 2;
            this.status_wifi.Text = "Status Wifi";
            // 
            // btn_scanWifi
            // 
            this.btn_scanWifi.BorderColor = System.Drawing.Color.Red;
            this.btn_scanWifi.BorderRadius = 10;
            this.btn_scanWifi.BorderThickness = 1;
            this.btn_scanWifi.CheckedState.Parent = this.btn_scanWifi;
            this.btn_scanWifi.CustomImages.Parent = this.btn_scanWifi;
            this.btn_scanWifi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_scanWifi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scanWifi.ForeColor = System.Drawing.Color.White;
            this.btn_scanWifi.HoverState.Parent = this.btn_scanWifi;
            this.btn_scanWifi.Location = new System.Drawing.Point(370, 10);
            this.btn_scanWifi.Name = "btn_scanWifi";
            this.btn_scanWifi.ShadowDecoration.Parent = this.btn_scanWifi;
            this.btn_scanWifi.Size = new System.Drawing.Size(130, 45);
            this.btn_scanWifi.TabIndex = 1;
            this.btn_scanWifi.Text = "Scan Wifi";
            this.btn_scanWifi.Click += new System.EventHandler(this.btnScanWifi_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Wifi_Xfree.Properties.Resources.Info;
            this.button1.Location = new System.Drawing.Point(875, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 45);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel_password
            // 
            this.panel_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_password.Controls.Add(this.guna2VScrollBar1);
            this.panel_password.Controls.Add(this.btn_uploadfile);
            this.panel_password.Controls.Add(this.listview_password);
            this.panel_password.Controls.Add(this.btn_savepass);
            this.panel_password.Controls.Add(this.btn_addpass);
            this.panel_password.Controls.Add(this.tb_addpassword);
            this.panel_password.FillColor = System.Drawing.Color.Transparent;
            this.panel_password.Location = new System.Drawing.Point(566, 93);
            this.panel_password.Name = "panel_password";
            this.panel_password.ShadowDecoration.Parent = this.panel_password;
            this.panel_password.Size = new System.Drawing.Size(351, 504);
            this.panel_password.TabIndex = 3;
            // 
            // btn_uploadfile
            // 
            this.btn_uploadfile.BorderRadius = 7;
            this.btn_uploadfile.BorderThickness = 1;
            this.btn_uploadfile.CheckedState.Parent = this.btn_uploadfile;
            this.btn_uploadfile.CustomImages.Parent = this.btn_uploadfile;
            this.btn_uploadfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_uploadfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_uploadfile.ForeColor = System.Drawing.Color.White;
            this.btn_uploadfile.HoverState.Parent = this.btn_uploadfile;
            this.btn_uploadfile.Location = new System.Drawing.Point(26, 433);
            this.btn_uploadfile.Name = "btn_uploadfile";
            this.btn_uploadfile.ShadowDecoration.Parent = this.btn_uploadfile;
            this.btn_uploadfile.Size = new System.Drawing.Size(75, 36);
            this.btn_uploadfile.TabIndex = 9;
            this.btn_uploadfile.Text = "Upload";
            this.btn_uploadfile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // listview_password
            // 
            this.listview_password.HideSelection = false;
            this.listview_password.Location = new System.Drawing.Point(26, 91);
            this.listview_password.Name = "listview_password";
            this.listview_password.Size = new System.Drawing.Size(298, 324);
            this.listview_password.TabIndex = 8;
            this.listview_password.UseCompatibleStateImageBehavior = false;
            this.listview_password.View = System.Windows.Forms.View.List;
            // 
            // btn_savepass
            // 
            this.btn_savepass.BorderRadius = 7;
            this.btn_savepass.BorderThickness = 1;
            this.btn_savepass.CheckedState.Parent = this.btn_savepass;
            this.btn_savepass.CustomImages.Parent = this.btn_savepass;
            this.btn_savepass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_savepass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_savepass.ForeColor = System.Drawing.Color.White;
            this.btn_savepass.HoverState.Parent = this.btn_savepass;
            this.btn_savepass.Location = new System.Drawing.Point(249, 433);
            this.btn_savepass.Name = "btn_savepass";
            this.btn_savepass.ShadowDecoration.Parent = this.btn_savepass;
            this.btn_savepass.Size = new System.Drawing.Size(75, 36);
            this.btn_savepass.TabIndex = 7;
            this.btn_savepass.Text = "Save";
            this.btn_savepass.Click += new System.EventHandler(this.btnSavePasswords_Click);
            // 
            // btn_addpass
            // 
            this.btn_addpass.BorderRadius = 7;
            this.btn_addpass.BorderThickness = 1;
            this.btn_addpass.CheckedState.Parent = this.btn_addpass;
            this.btn_addpass.CustomImages.Parent = this.btn_addpass;
            this.btn_addpass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_addpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addpass.ForeColor = System.Drawing.Color.White;
            this.btn_addpass.HoverState.Parent = this.btn_addpass;
            this.btn_addpass.Location = new System.Drawing.Point(249, 27);
            this.btn_addpass.Name = "btn_addpass";
            this.btn_addpass.ShadowDecoration.Parent = this.btn_addpass;
            this.btn_addpass.Size = new System.Drawing.Size(75, 36);
            this.btn_addpass.TabIndex = 6;
            this.btn_addpass.Text = "Add";
            this.btn_addpass.Click += new System.EventHandler(this.btnAddPassword_Click);
            // 
            // tb_addpassword
            // 
            this.tb_addpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tb_addpassword.BorderRadius = 7;
            this.tb_addpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_addpassword.DefaultText = "";
            this.tb_addpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_addpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_addpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_addpassword.DisabledState.Parent = this.tb_addpassword;
            this.tb_addpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_addpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_addpassword.FocusedState.Parent = this.tb_addpassword;
            this.tb_addpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_addpassword.HoverState.Parent = this.tb_addpassword;
            this.tb_addpassword.Location = new System.Drawing.Point(26, 27);
            this.tb_addpassword.Name = "tb_addpassword";
            this.tb_addpassword.PasswordChar = '\0';
            this.tb_addpassword.PlaceholderText = "";
            this.tb_addpassword.SelectedText = "";
            this.tb_addpassword.ShadowDecoration.Parent = this.tb_addpassword;
            this.tb_addpassword.Size = new System.Drawing.Size(200, 36);
            this.tb_addpassword.TabIndex = 5;
            this.tb_addpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_addpass_KeyPress);
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(197, 526);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(300, 30);
            this.guna2ProgressBar1.TabIndex = 4;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.panel_password;
            // 
            // IP_network
            // 
            this.IP_network.AutoSize = true;
            this.IP_network.Location = new System.Drawing.Point(525, 28);
            this.IP_network.Name = "IP_network";
            this.IP_network.Size = new System.Drawing.Size(35, 13);
            this.IP_network.TabIndex = 9;
            this.IP_network.Text = "label1";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Red;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(634, 10);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(130, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "Test";
            this.guna2Button1.Click += new System.EventHandler(this.btnRunSpeedTest_Click);
            // 
            // WifiXFree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(946, 671);
            this.Controls.Add(this.guna2ProgressBar1);
            this.Controls.Add(this.panel_password);
            this.Controls.Add(this.switch_wifi);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WifiXFree";
            this.Text = "Wifi XFree V1.0";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.switch_wifi.ResumeLayout(false);
            this.switch_wifi.PerformLayout();
            this.panel_password.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel switch_wifi;
        private Guna.UI2.WinForms.Guna2Panel panel_password;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label status_wifi;
        private Guna.UI2.WinForms.Guna2Button btn_scanWifi;
        private System.Windows.Forms.Label name_wf_connect;
        private System.Windows.Forms.Label connect_label;
        private Guna.UI2.WinForms.Guna2ToggleSwitch switchWifi;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Guna.UI2.WinForms.Guna2TextBox tb_addpassword;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2Button btn_savepass;
        private Guna.UI2.WinForms.Guna2Button btn_addpass;
        private Guna.UI2.WinForms.Guna2Button btn_uploadfile;
        private System.Windows.Forms.ListView listview_password;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label IP_network;
    }
}

