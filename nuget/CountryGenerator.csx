#! "netcoreapp2.0"
#r "nuget: Newtonsoft.Json, 12.0.1"

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class Country {
	public string Code { get; set; }
	public string Name { get; set; }
	public string Native { get; set; }
	public string Phone { get; set; }
	public string Continent { get; set; }
	public string Capital { get; set; }
	public string Currency { get; set; }
	public IEnumerable<string> Languages { get; set; }

	public Country(string code, string name, string native, string phone, string continent, string capital, string currency, IEnumerable<string> languages) {
		Code = code;
		Name = name;
		Native = native;
		Phone = phone;
		Continent = continent;
		Capital = capital;
		Currency = currency;
		Languages = languages;
	}
}

var rawJson = File.ReadAllText("../src/i18n/countries.json");
IDictionary<string, Country> countries = JsonConvert.DeserializeObject<IDictionary<string, Country>>(rawJson);

StringBuilder buildstring = new StringBuilder();

buildstring.Append(@"using System.Collections.Generic;

namespace OsnI18n
{
	// THANK U RACHEL @ https://www.rachelfrantsen.com (Dotnet represent!!)

	public class Country {
		public string Code { get; set; }
		public string Name { get; set; }
		public string Native { get; set; }
		public string Phone { get; set; }
		public string Continent { get; set; }
		public string Capital { get; set; }
		public string Currency { get; set; }
		public IEnumerable<string> Languages { get; set; }

		public Country(string code, string name, string native, string phone, string continent, string capital, string currency, IEnumerable<string> languages) {
			Code = code;
			Name = name;
			Native = native;
			Phone = phone;
			Continent = continent;
			Capital = capital;
			Currency = currency;
			Languages = languages;
		}
	}

public static class CountryData {
	public static IEnumerable<Country> Countries = new List<Country>()
	{
	");
foreach(string key in countries.Keys) {
	var country = countries[key];
	buildstring.Append(
		$@" new Country(""{key}"", ""{country.Name}"", ""{country.Native}"", ""{country.Phone}"", ""{country.Continent}"", ""{country.Capital}"", ""{country.Currency}"", new List<string>()),
	");
}

buildstring.Append(@"};
	}
}
");

File.WriteAllText(@"./Countries.cs", buildstring.ToString());