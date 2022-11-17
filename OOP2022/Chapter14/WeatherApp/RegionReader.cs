using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp {
	class RegionReader {
		private IEnumerable<Region> _regions;

		public RegionReader(string filePath) {
			_regions = ReadRegions(filePath);
		}

		/*public IDictionary<string,string> keyValuePairs() {
			var dict = new Dictionary<string,string>();
			foreach(var region in _regions) {
				return region.AreaCode;
			}
		}*/

		public static IEnumerable<Region> ReadRegions(string filepath) {
			List<Region> regions = new List<Region>();
			string[] lines = File.ReadAllLines(filepath);
			foreach (var line in lines) {
				string[] items = line.Split(',');
				Region region = new Region {
					State = items[0],
					AreaCode = items[1]
				};
				regions.Add(region);
			}
			return regions;
		}
	}
}
