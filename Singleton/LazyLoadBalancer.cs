// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LazyLoadBalancer.cs" company="">
//   
// </copyright>
// //  <summary>
//   LazyLoadBalancer.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Singleton
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The load balancer.
    /// </summary>
    public class LazyLoadBalancer
    {
        /// <summary>
        ///     The random.
        /// </summary>
        private readonly Random _random = new Random();

        /// <summary>
        ///     The servers.
        /// </summary>
        private readonly IList<Server> _servers;

        /// <summary>
        ///     Prevents a default instance of the <see cref="LazyLoadBalancer" /> class from being created.
        ///     Initializes a new instance of the <see cref="LoadBalancer" /> class.
        /// </summary>
        private LazyLoadBalancer()
        {
            // Load list of available servers
            this._servers = new List<Server>
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
        public Server NextServer
        {
            get
            {
                return this._servers[this._random.Next(this._servers.Count)];
            }
        }

        /// <summary>
        ///     Gets the instance.
        /// </summary>
        private static LazyLoadBalancer Instance => Nested.LazyInstance;

        /// <summary>
        ///     The get load balancer.
        /// </summary>
        /// <returns>
        ///     The <see cref="LoadBalancer" />.
        /// </returns>
        public static LazyLoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        /// <summary>
        ///     The nested.
        /// </summary>
        private class Nested
        {
            /// <summary>
            ///     The instance.
            /// </summary>
            internal static readonly LazyLoadBalancer LazyInstance = new LazyLoadBalancer();

            /// <summary>
            ///     Initializes static members of the <see cref="Nested" /> class.
            ///     Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
            /// </summary>
            static Nested()
            {
            }
        }
    }
}