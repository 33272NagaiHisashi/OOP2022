using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
	class Program {
		static void Main(string[] args) {

			var str = "Jackdaws love my big sphinx of quartz";

			// 5.3.1
			Exercise3_1(str);
			Console.WriteLine("-------------");

			// 5.3.2
			Exercise3_2(str);
			Console.WriteLine("-------------");

			// 5.3.3
			Exercise3_3(str);
			Console.WriteLine("-------------");

			// 5.3.4
			Exercise3_4(str);
			Console.WriteLine("-------------");

			// 5.3.5
			Exercise3_5(str);
			Console.WriteLine("-------------");
		}

		private static void Exercise3_1(string str) {
			var count = str.Where(s => s == ' ').Count();
			Console.WriteLine(count);
		}

		private static void Exercise3_2(string str) {
			var replace = str.Replace("big", "small");
			Console.WriteLine(replace);
		}

		private static void Exercise3_3(string str) {
			var words = str.Split(' ').Count();
			Console.WriteLine(words);
		}

		private static void Exercise3_4(string str) {
			var value = str.Split(' ').Where(v => v.Length <= 4);
			foreach (var v in value) {
				Console.WriteLine(v);
			}
		}

		private static void Exercise3_5(string str) {
			var split = str.Split(' ');
			var sb = new StringBuilder();
			foreach (var s in split) {
				sb.Append(s + " ");
			}
			var text = sb.ToString();
			Console.WriteLine(text);
		}
	}
}
