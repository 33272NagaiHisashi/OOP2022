using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Exercise1 {
	class Program {
		static void Main(string[] args) {
			var file = "sample.xml";
			Exercise1_1(file);
			Console.WriteLine();
			Exercise1_2(file);
			Console.WriteLine();
			Exercise1_3(file);
			Console.WriteLine();

			var newfile = "sports.xml";
			Exercise1_4(file, newfile);
		}

		private static void Exercise1_1(string file) {
			var xdoc = XDocument.Load(file);
			var sports = xdoc.Root.Elements().Select(x => new {
													Name = (string)x.Element("name"),
													TeamMembers = (int)x.Element("teammembers")
			});
			foreach(var sport in sports) {
				Console.WriteLine("{0} {1}",sport.Name,sport.TeamMembers);
			}
		}

		private static void Exercise1_2(string file) {
			var xdoc = XDocument.Load(file);
			var sports = xdoc.Root.Elements().Select(x => new {
													name = (string)x.Element("name").Attribute("kanji"),
													firstplayed = (int)x.Element("firstplayed")})
											 .OrderBy(x => x.firstplayed);
			foreach (var sport in sports) {
				Console.WriteLine("{0}({1})", sport.name,sport.firstplayed);
			}
		}

		private static void Exercise1_3(string file) {
			var xdoc = XDocument.Load(file);
			var sports = xdoc.Root.Elements().Select(x => new { 
													name = (string)x.Element("name"),
													teammembers = (int)x.Element("teammembers")})
											 .OrderByDescending(x => x.teammembers)
											 .FirstOrDefault();
			Console.WriteLine("{0} {1}人", sports.name,sports.teammembers);
			
		}

		private static void Exercise1_4(string file, string newfile) {
			var element = new XElement("ballsport",
							new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
							new XElement("teammembers", "11"),
							new XElement("firstplayed", "1863")
							);
			var xdoc = XDocument.Load(file);
			xdoc.Root.Add(element);
			xdoc.Save(newfile);
			var sports = xdoc.Root.Elements().Select(x => new {
				name = (string)x.Element("name"),
				kanji = (string)x.Element("name").Attribute("kanji"),
				teammembers = (int)x.Element("teammembers"),
				firstplayed = (int)x.Element("firstplayed"),
			});
			foreach (var sport in sports) {
				Console.WriteLine("{0} {1} {2} {3}", sport.name,sport.kanji,sport.teammembers,sport.firstplayed);
			}
		}
	}
}
