﻿using System;
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
			var sports = xdoc.Root.Elements().OrderBy(x => (int)(x.Element("firstplayed")));
			foreach (var sport in sports) {
				var name = sport.Element("name").Attribute("kanji");
				var firstplayed = (int)sport.Element("firstplayed");
				Console.WriteLine("{0}({1})",name.Value,firstplayed);
			}
		}

		private static void Exercise1_3(string file) {
			var xdoc = XDocument.Load(file);
			var sports = xdoc.Root.Elements().OrderByDescending(x => (int)(x.Element("teammembers"))).FirstOrDefault();
			var name = sports.Element("name");
			Console.WriteLine(name.Value);
		}

		private static void Exercise1_4(string file, string newfile) {
			var element = new XElement("ballsport",
							new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
							new XElement("teammembers", "11"),
							new XElement("firstplayed", "1863")
							);
			var xdoc = XDocument.Load(file);
			xdoc.Root.Add(element);
			foreach(var sport in xdoc.Root.Elements()) {
				var xname = sport.Element("name");
				var xkanji = xname.Attribute("kanji");
				var xteammembers = sport.Element("teammembers");
				var xfirstplayed = sport.Element("firstplayed");
				Console.WriteLine("{0} {1} {2} {3}", xname.Value,xkanji.Value, xteammembers.Value, xfirstplayed.Value);
			}
		}
	}
}
