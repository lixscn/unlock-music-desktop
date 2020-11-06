using NetDimension.NanUI;
using NetDimension.NanUI.ZippedResource;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unlock_music_desktop
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            WinFormium.CreateRuntimeBuilder(env =>
            {

                env.CustomCefSettings(settings =>
                {
                    // 在此处设置 CEF 的相关参数
                });

                env.CustomCefCommandLineArguments(commandLine =>
                {
                    // 在此处指定 CEF 命令行参数
                });

            }, app =>
            {
                //注册嵌入ZIP程序集资源处理器
                app.UseZippedResource("http", "archive.app.local", () => new MemoryStream(Properties.Resources.dist));
                // 指定启动窗体
                app.UseMainWindow(context => new MainWindow());
            })
            .Build()
            .Run();
        }
    }
}
