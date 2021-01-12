using System;
using System.Collections.Generic;

namespace Singleton
{
    sealed class LoadBalancer
    {
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        static readonly LoadBalancer instance = new LoadBalancer();

        // Type-safe generic list of servers
        List<Server> servers;
        Random random = new Random();

        // Note: constructor is 'private'
        private LoadBalancer()
        {
            // Load list of available servers
            servers = new List<Server>
            {
                new Server{ Name = "ServerI", IP = "120.14.220.18" },
                new Server{ Name = "ServerII", IP = "120.14.220.19" },
                new Server{ Name = "ServerIII", IP = "120.14.220.20" },
                new Server{ Name = "ServerIV", IP = "120.14.220.21" },
                new Server{ Name = "ServerV", IP = "120.14.220.22" },
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return instance;
        }

        // Simple, but effective load balancer
        public Server NextServer
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r];
            }
        }
    }
}