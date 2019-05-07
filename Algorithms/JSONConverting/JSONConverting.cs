using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Algorithms.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Algorithms.JSONConverting
{
    [DisplayInfo("JSON", "JSON converting", typeof(List<int>))]
    public class JSONConverting
    {
        public List<int> Go()
        {
            string file = Environment.CurrentDirectory + "/test_file.json";
            var json = File.ReadAllText(file);
            var json_serializer = new JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(json);

            List<MetricDataResponse> metricsResponses = new List<MetricDataResponse>();

            foreach (var o in routes_list)
            {

                var values = (IDictionary<string, object>) o.Value;
                foreach (var v in values)
                {   
                    var internalValues = (IDictionary<string, object>)v.Value;
                    MetricDataResponse mdr = new MetricDataResponse();
                    List<GraphDataPoint> lg = new List<GraphDataPoint>();
                    foreach (var internalValue in internalValues)
                    {   
                       
                        if (internalValue.Key == "Data")
                        {
                            var data = (object[]) internalValue.Value;
                            foreach (var point in data)
                            {
                                var pointArr = (IDictionary<string, object>)point;
                                var date = (string)pointArr["Date"];
                                long ticks = long.Parse(date.Replace("/Date(", "").Replace(")/", ""));
                                var value = double.Parse(pointArr["Value"].ToString());
                                lg.Add(new GraphDataPoint(new DateTime(ticks), value));
                            }
                        }
                        else
                        {
                            if (internalValue.Key == "AccountName")
                            {
                                mdr.AccountName = internalValue.Value.ToString();
                            }
                            else if (internalValue.Key == "MetricName")
                            {
                                mdr.MetricName = internalValue.Value.ToString();
                            }
                            else
                            {
                                mdr.MetricNamespace = internalValue.Value.ToString();
                            }
                        }
                    }

                    mdr.Data = lg;
                    metricsResponses.Add(mdr);
                }
            }

            return new List<int>();
        }
    }

    public class MetricDataResponse
    {
        public string AccountName { get; set; }

        public string MetricNamespace { get; set; }

        public string MetricName { get; set; }

        public IEnumerable<GraphDataPoint> Data { get; set; }
    }

    public class GraphDataPoint
    {
        public GraphDataPoint(DateTime date, double? value)
        {
            this.Date = date;
            this.Value = value.HasValue ? Math.Round(value.Value, 2) : value;
        }

        public DateTime Date { get; set; }

        public double? Value { get; set; }
    }
}
