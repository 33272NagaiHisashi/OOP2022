﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
	class Program {
		static void Main(string[] args) {

			var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

			Exercise1_1(numbers);
			Console.WriteLine("----------");

			Exercise1_2(numbers);
			Console.WriteLine("----------");

			Exercise1_3(numbers);
			Console.WriteLine("----------");

			Exercise1_4(numbers);
			Console.WriteLine("----------");

			Exercise1_5(numbers);
			Console.WriteLine("----------");
		}

		private static void Exercise1_1(int[] numbers) {
			var max = numbers.Max();
			Console.WriteLine(max);
		}

		private static void Exercise1_2(int[] numbers) {
			var last2 = numbers.Skip(numbers.Length - 2);
			foreach (var n in last2) {
				Console.WriteLine(n);
			}
		}

		private static void Exercise1_3(int[] numbers) {
			var strs = numbers.Select(n => n.ToString());
			foreach (var s in strs) {
				//var str = n.ToString();
				Console.WriteLine(s);
			}
		}

		private static void Exercise1_4(int[] numbers) {
			var asc = numbers.OrderBy(n => n).Take(3);
			foreach (var a in asc) {
				Console.WriteLine(a);
			}
		}

		private static void Exercise1_5(int[] numbers) {
			var distinct = numbers.Distinct().Where(n => n > 10).Count();
			Console.WriteLine(distinct);
		}
	}
}
