#! "netcoreapp2.0"
#r "nuget: Newtonsoft.Json, 12.0.1"

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

var rawJson = File.ReadAllText("../src/i18n/countries.json");
var countries = JObject.Parse(rawJson);

StringBuilder buildstring = new StringBuilder();

buildstring.Append(@"
namespace osni18n
{

    public static class CountryData");

buildstring.Append(JsonConvert.DeserializeObject<dynamic>(rawJson));

buildstring.Append(@";
}
");

File.WriteAllText(@"./Countries.cs", buildstring.ToString());