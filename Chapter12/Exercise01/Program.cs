using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;



namespace Exercise01 {
	class Program {
		
		static void Main(string[] args) {

			Exercise1_1("employee.xml");

			// これは確認用
			//Console.WriteLine(File.ReadAllText("employee.xml"));
			Console.WriteLine();

			Exercise1_2("employees.xml");
			//Console.WriteLine(File.ReadAllText("employee.xml"));
			Console.WriteLine();

			Exercise1_3("employees.xml");
			Console.WriteLine();

			Exercise1_4("employees.json");

			// これは確認用
			Console.WriteLine(File.ReadAllText("employees.json"));
		}

		private static void Exercise1_1(string v) {
			var emp = new Employee {
				Id = 33272,
				Name = "Nagai Hisashi",
				HireDate = new DateTime(2021,4,1),
			};
			//シリアル化
			using (var worker = XmlWriter.Create(v)) {
				var serializer = new XmlSerializer(emp.GetType());
				serializer.Serialize(worker, emp);
			}
			//逆シリアル化
			using (var reader = XmlReader.Create(v)) {
                var serializer = new XmlSerializer(typeof(Employee));
                var employee = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(employee); 
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
			using (var worker = XmlWriter.Create(v)) {
				var serializer = new DataContractSerializer(employees.GetType());
				serializer.WriteObject(worker, employees);
			}
		}

		private static void Exercise1_3(string file) {
			using (var reader = XmlReader.Create(file)) {
				var serializer = new DataContractSerializer(typeof(Employee[]));
				var emps = serializer.ReadObject(reader) as Employee[];
				foreach (var e in emps) {
					Console.WriteLine(e);
				}
			}
		}
		
		private static void Exercise1_4(string v) {
			var employees = new EmployeeJ[] {
				new EmployeeJ {
					Id = 33188,
					Name = "Shinohara Shousei",
					HireDate = new DateTime(2021,4,10),
				},
				new EmployeeJ {
					Id = 33272,
					Name = "Nagai Hisashi",
					HireDate = new DateTime(2021,4,1),
				},
			};
			var settings = new DataContractJsonSerializerSettings {
				DateTimeFormat = new DateTimeFormat("yyyy-MM-dd")
			};
			using (var stream = new FileStream(v, FileMode.Create, FileAccess.Write)) {
				var serializer = new DataContractJsonSerializer(employees.GetType(),settings);
				/*var serializer = new DataContractJsonSerializer(employees.GetType(),new DataContractJsonSerializerSettings { 
					DateTimeFormat = new DateTimeFormat("yyyy-MM-dd")
				});*/
				serializer.WriteObject(stream, employees);
			}
		}
	}
}
