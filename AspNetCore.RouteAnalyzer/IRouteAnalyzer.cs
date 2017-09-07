using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.RouteAnalyzer
{
    public interface IRouteAnalyzer
    {
        IEnumerable<RouteInformation> GetAllRouteInformations();
    }
}
