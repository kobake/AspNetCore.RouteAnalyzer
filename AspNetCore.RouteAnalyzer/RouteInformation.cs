using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.RouteAnalyzer
{
    public class RouteInformation
    {
        public string Area { get; set; } = "";
        public string Path { get; set; } = "";
        public string Invocation { get; set; } = "";

        public override string ToString()
        {
            return $"RouteInformation{{Area:\"{Area}\", Path:\"{Path}\", Invocation:\"{Invocation}\"}}";
        }
    }
}
