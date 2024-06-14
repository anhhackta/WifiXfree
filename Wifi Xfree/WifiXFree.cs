using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Wifi_Xfree
{
    public partial class WifiXFree : Form
    {
        private PasswordManager passwordManager;
        private List<string> passwords;

        public WifiXFree()
        {
            InitializeComponent();
            SetPasswordFilePath();
            passwordManager = new PasswordManager(passwordFilePath);
            LoadPasswordsFromFile();
            CheckWifiSupport();
            LoadWifiStatus();
            LoadIPAddress();
        }
        //start password
        private string passwordFilePath;

        private void SetPasswordFilePath()
        {
            passwordFilePath = Path.Combine(Application.StartupPath, "password.txt");
        }

        private void LoadPasswordsFromFile()
        {
            try
            {
                passwords = passwordManager.LoadPasswordsFromFile();
                listview_password.Items.Clear();
                foreach (var password in passwords)
                {
                    listview_password.Items.Add(new ListViewItem(password));
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddPassword_Click(object sender, EventArgs e)
        {
            var newPassword = tb_addpassword.Text.Trim();
            if (passwordManager.IsValidPassword(newPassword))
            {
                if (!passwordManager.IsDuplicatePassword(newPassword, passwords))
                {
                    passwords.Add(newPassword);
                    listview_password.Items.Add(new ListViewItem(newPassword));
                    tb_addpassword.Clear();
                }
                else
                {
                    MessageBox.Show("Mật khẩu đã tồn tại.");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu phải trên 8 ký tự và không chứa dấu \".");
            }
        }

        private void btnSavePasswords_Click(object sender, EventArgs e)
        {
            passwordManager.SavePasswordsToFile(passwords);
            MessageBox.Show("Đã lưu danh sách mật khẩu.");
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    passwordFilePath = openFileDialog.FileName;
                    passwordManager = new PasswordManager(passwordFilePath);
                    LoadPasswordsFromFile();
                }
            }
        }

        private void btn_addpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnAddPassword_Click(this,new KeyPressEventArgs((char)13));
        }
        //end password



        //start onoffowifi

        private void CheckWifiSupport()
        {
            if (!IsWifiSupported())
            {
                MessageBox.Show("Máy tính của bạn không hỗ trợ WiFi.");
                Application.Exit();
            }
        }

        private bool IsWifiSupported()
        {
            return NetworkInterface.GetAllNetworkInterfaces()
                .Any(nic => nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211);
        }
        private void LoadWifiStatus()
        {
            string wifiStatus = GetWifiStatus();
            name_wf_connect.Text = wifiStatus;
        }
        private string GetWifiStatus()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = "wlan show interfaces",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            var ssidLine = output.Split('\n').FirstOrDefault(line => line.Trim().StartsWith("SSID"));
            return ssidLine?.Split(':')[1].Trim() ?? "Không kết nối";
        }

        private void LoadIPAddress()
        {
            string ipAddress = GetLocalIPAddress();
            IP_network.Text = $"Địa chỉ IP: {ipAddress}";
        }
        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void switchWifi_CheckedChanged(object sender, EventArgs e)
        {
            ToggleWifi();
            LoadWifiStatus();
        }
        private void ToggleWifi()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = IsWifiEnabled() ? "interface set interface \"Wi-Fi\" disable" : "interface set interface \"Wi-Fi\" enable",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            process.Start();
            process.WaitForExit();
        }
        private bool IsWifiEnabled()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = "interface show interface",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return output.Contains("Wi-Fi") && output.Contains("Enabled");
        }


        private void btnScanWifi_Click(object sender, EventArgs e)
        {
            ScanWifiNetworks();
        }
        private void ScanWifiNetworks()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = "wlan show networks",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            listBox1.Items.Clear();
            var lines = output.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                if (line.Trim().StartsWith("SSID"))
                {
                    var ssid = line.Split(':')[1].Trim();
                    listBox1.Items.Add(ssid);
                }
            }
        }

        private void btnRunSpeedTest_Click(object sender, EventArgs e)
        {
            RunSpeedTest();
        }

        private void RunSpeedTest()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = Path.Combine(Application.StartupPath, "Speedtest", "speedtest.exe"),
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            MessageBox.Show(output, "Speed Test Result");
        }

        //end onofffwifi
    }
}
