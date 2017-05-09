//  *****************************************************************************
//  <copyright file="Program.cs" company="mainul098@gmail.com">
//      Copyright ©  2017
//  </copyright>
//  <summary>Program.cs</summary>
//  *****************************************************************************
namespace Singleton
{
    using System;

    /// <summary>
    ///     The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        ///     The main.
        /// </summary>
        /// <param name="args">
        ///     The args.
        /// </param>
        public static void Main(string[] args)
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests
            var balancer = LoadBalancer.GetLoadBalancer();
            for (var i = 0;
                 i < 15;
                 i++)
            {
                var server = balancer.NextServer;
                Console.WriteLine("Dispatch Request to: " + server.Name);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}