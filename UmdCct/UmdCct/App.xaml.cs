using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace UmdCct
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private NotifyIconWrapper notifyIcon;

        /// <summary>
        /// System.Windows.Application.Startup イベント を発生させます。
        /// </summary>
        /// <param name="e">イベントデータ を格納している StartupEventArgs</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            this.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            this.notifyIcon = new NotifyIconWrapper();
        }
    }
}
