using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class TableServers
    {
        private static readonly TableServers _instace = new TableServers();
        private List<string> servers = new List<string>();
        private int nextServer = 0;

        private TableServers()
        {
            servers.Add("Tim");
            servers.Add("Sue");
            servers.Add("Mary");
            servers.Add("Bob");
        }

        public static TableServers GetTableServers()
        {
            return _instace;
        }

        public string GetNextServer()
        {
            var output = servers[nextServer];
            nextServer += 1;
            if (nextServer >= servers.Count)
                nextServer = 0;

            return output;
        }
    }
}
