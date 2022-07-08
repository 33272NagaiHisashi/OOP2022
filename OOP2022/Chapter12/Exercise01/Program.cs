﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
	class Program {
		static void Main(string[] args) {

			Exercise1_1("employee.xml");

			// これは確認用
			Console.WriteLine(File.ReadAllText("employee.xml"));
			Console.WriteLine();

			Exercise1_2("employees.xml");
			Exercise1_3("employees.xml");
			Console.WriteLine();

			Exercise1_4("employees.json");

			// これは確認用
			//Console.WriteLine(File.ReadAllText("employees.json"));
		}

		private static void Exercise1_1(string v) {
			var employee = new Employee[] {
				new Employee {
				Id = 33272,
				Name = "Nagai Hisashi",
				HireDate = new DateTime(2021,4,1),
				}
			};
			var settings = new XmlWriterSettings {
				Encoding = new System.Text.UTF8Encoding(false),
				Indent = true,
				IndentChars = " ",
			};
			using(var writer = XmlWriter.Create("employee.xml", settings)) {
				var serializer = new XmlSerializer(employee.GetType());
				serializer.Serialize(writer, employee);
			}
		}

		private static void Exercise1_2(string v) {
			var employees = new Employee[] {
				new Employee {
					Id = 33188,
					Name = "Shinohara Shousei",
					HireDate = new DateTime(2021,4,10),
				},
				new Employee {
					Id = 33272,
					Name = "Nagai Hisashi",
					HireDate = new DateTime(2021,4,1),
				},
			};
		}

		private static void Exercise1_3(string v) {
			
		}

		private static void Exercise1_4(string v) {
			
		}
	}
}
