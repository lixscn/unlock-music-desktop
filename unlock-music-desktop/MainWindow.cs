using Microsoft.Win32;
using NetDimension.NanUI;
using NetDimension.NanUI.Browser;
using NetDimension.NanUI.HostWindow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unlock_music_desktop
{
    public class MainWindow : Formium
    {
        

        // 设置窗体样式类型
        public override HostWindowType WindowType => HostWindowType.System;
        // 指定启动 Url
        public override string StartUrl => "http://archive.app.local/index.html";

        public MainWindow()
        {
            Title = "Unlock Music";

            Subtitle = "音乐解锁";

            // 在此处设置窗口样式
            Size = new System.Drawing.Size(1024, 768);
            Mask.BackColor = Color.White;
            Mask.Image = Properties.Resources.logo;
            Icon = Tools.ConvertToIcon(Properties.Resources.logo);

            //关闭窗口事件
            BeforeClose += MainWindow_BeforeClose;
            //关机事件
            SystemEvents.SessionEnding += new SessionEndingEventHandler(SystemEvents_SessionEnding);
        }

        //关机事件
        private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            //e.Cancel = true;
        }

        //关闭窗口事件
        private void MainWindow_BeforeClose(object sender, FormiumCloseEventArgs e)
        {
            //Console.WriteLine("MainWindow_BeforeClose:{0}:{1}",sender.ToString(),e.ToString());
            
        }

        protected override void OnReady()
        {
            // 在此处进行浏览器相关操作
            //ShowDevTools();
            //ExecuteJavaScript("alert('Hello NanUI')");

        }

       


    }
}
