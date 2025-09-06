using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace YandexBlock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer").SetValue("DisallowRun", 1);
                Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun").SetValue("1", "Yandex.exe");
                Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun").SetValue("2", "yandex.exe");
                Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun").SetValue("3", "browser.exe");
                MessageBox.Show("Заблокировано");
                Process.Start("ShutDown", "/r /t 5");
            }
            catch
            {
                MessageBox.Show("Error");
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer").SetValue("DisallowRun", 0);
            MessageBox.Show("Разблокировано");
            Process.Start("ShutDown", "/r /t 5");
        }

        
        private void linkLabel2_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/Dimon1757");
            }
            catch
            {
                MessageBox.Show("https://github.com/Dimon1757");
            }
        }
        
    }
}
