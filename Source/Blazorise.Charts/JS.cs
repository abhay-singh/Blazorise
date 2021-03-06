using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazorise.Charts
{
    public static class JS
    {
        public static Task<bool> SetChartData( string id, ChartType type, object data, object options )
        {
            return JSRuntime.Current.InvokeAsync<bool>( "blazoriseCharts.setChartData", id, ToChartTypeString( type ), data, options );
        }

        public static string ToChartTypeString( ChartType type )
        {
            switch ( type )
            {
                case ChartType.Bar:
                    return "bar";
                case ChartType.Pie:
                    return "pie";
                case ChartType.Doughnut:
                    return "doughnut";
                case ChartType.Radar:
                    return "radar";
                case ChartType.PolarArea:
                    return "polarArea";
                case ChartType.Line:
                default:
                    return "line";
            }
        }
    }
}
