//  *****************************************************************************
//  <copyright file="LoadBalancer.cs" company="mainul098@gmail.com">
//      Copyright ©  2017
//  </copyright>
//  <summary>LoadBalancer.cs</summary>
//  *****************************************************************************
namespace Singleton
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The load balancer.
    /// </summary>
    public class LoadBalancer
    {
        /// <summary>
        ///     Gets the instance.
        /// </summary>
        private static readonly LoadBalancer Instance = new LoadBalancer();

        /// <summary>
        ///     The random.
        /// </summary>
        private readonly Random random = new Random();

        /// <summary>
        ///     The servers.
        /// </summary>
        private readonly IList<Server> servers;

        /// <summary>
        ///     Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
        ///     Initializes static members of the <see cref="LoadBalancer" /> class.
        /// </summary>
        static LoadBalancer()
        {
        }

        /// <summary>
        ///     Prevents a default instance of the <see cref="LoadBalancer" /> class from being created.
        ///     Initializes a new instance of the <see cref="LoadBalancer" /> class.
        /// </summary>
        private LoadBalancer()
        {
            // Load list of available servers
            this.servers = new List<Server>
                               {
                                   new Server { Name = "ServerI", IpAddress = "120.14.220.18" },
                                   new Server { Name = "ServerII", IpAddress = "120.14.220.19" },
                                   new Server { Name = "ServerIII", IpAddress = "120.14.220.20" },
                                   new Server { Name = "ServerIV", IpAddress = "120.14.220.21" },
                                   new Server { Name = "ServerV", IpAddress = "120.14.220.22" },
                               };
        }

        /// <summary>
        ///     Gets the next server.
        /// </summary>
        public Server NextServer => this.servers[this.random.Next(this.servers.Count)];
        /// <summary>
        ///     The get load balancer.
        /// </summary>
        /// <returns>
        ///     The <see cref="LoadBalancer" />.
        /// </returns>
        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }
    }
}