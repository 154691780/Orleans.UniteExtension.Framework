using Microsoft.Owin.Hosting;
using Orleans.Providers;
using Orleans.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.Orleans
{
    /// <summary>
    /// Orleans引导Owin程序
    /// </summary>
    public class OrleansBootstrapOwinProvider : IBootstrapProvider
    {
        private IDisposable OwinHost { get; set; }
        private Logger g_Logger;

        public string Name { get; private set; }

        public Task Close()
        {
            this.OwinHost.Dispose();
            return Task.CompletedTask;
        }

        public Task Init(string name, IProviderRuntime providerRuntime, IProviderConfiguration config)
        {
            this.g_Logger = providerRuntime.GetLogger(name);
            this.Name = name;

            var m_StartOptions = new StartOptions
            {
                ServerFactory = "Nowin",
                Port = config.Properties.ContainsKey("Port") ? int.Parse(config.Properties["Port"]) : 9186,
            };

            this.OwinHost = WebApp.Start(m_StartOptions, app => new OwinServiceStartup(null).Configure(app));

            return Task.CompletedTask;
        }
    }
}
