namespace AspNetCore.RouteAnalyzer
{
    public class RouteInformation
    {
        public string HttpMethod { get; set; } = "GET";
        public string Area { get; set; } = "";
        public string Path { get; set; } = "";
        public string Invocation { get; set; } = "";

        public override string ToString()
        {
            return $"RouteInformation{{Area:\"{Area}\", HttpMethod: \"{HttpMethod}\", Path:\"{Path}\", Invocation:\"{Invocation}\"}}";
        }
    }
}
