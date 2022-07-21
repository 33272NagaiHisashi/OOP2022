﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
	class Program {
		static void Main(string[] args) {
			var names = new List<string> {
			   "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
			};

			Exercise2_1(names);
			Console.WriteLine("----------");
			Exercise2_2(names);
			Console.WriteLine("----------");
			Exercise2_3(names);
			Console.WriteLine("----------");
			Exercise2_4(names);
			Console.WriteLine("----------");
		}

		private static void Exercise2_1(List<string> names) {
			Console.WriteLine("都市名を入力。空行で終了");
			do {
				var line = Console.ReadLine(); //入力取り込み
				if (string.IsNullOrEmpty(line)) {
					break;
				}
				var index = names.FindIndex(s => s == line);
				Console.WriteLine(index);
			} while (true); //無限ループ
			Console.WriteLine();
		}

		private static void Exercise2_2(List<string> names) {
			var line = Console.ReadLine();
			var count = names.Where(s => s.Contains(line)).Count();
			Console.WriteLine(count);
		}

		private static void Exercise2_3(List<string> names) {
			var line = Console.ReadLine();
			var selected = names.Where(s => s.Contains(line)).ToArray();
			foreach (var name in selected)
				Console.WriteLine(name);
		}

		private static void Exercise2_4(List<string> names) {
			var line = Console.ReadLine();
			var selected = names.Where(s => s.StartsWith(line)).Select(s => new { s.Length, s }); //このやり方が多い
			foreach (var name in selected)
				Console.WriteLine(name.s + ", " + name.Length);
		}
	}
}
