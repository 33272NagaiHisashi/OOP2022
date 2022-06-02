using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
	class Program {
		static void Main(string[] args) {

			// 4.2.1
			var ymCollection = new YearMonth[5] {
				new YearMonth(2018, 1),
				new YearMonth(2019, 2),
				new YearMonth(2020, 3),
				new YearMonth(2021, 4),
				new YearMonth(2022, 5),
			};
			// 4.2.2
			Exercise2_2(ymCollection);
			Console.WriteLine("-------------");

			// 4.2.4
			Exercise2_4(ymCollection);
			Console.WriteLine("-------------");

			// 4.2.5
			Exercise2_5(ymCollection);
			Console.WriteLine("-------------");

			// 4.2.6
			Exercise2_6(ymCollection);
			Console.WriteLine("-------------");
		}

		// 4.2.3
		static YearMonth FindFirst21C(YearMonth[] yms) {
			foreach (var ym in yms) {
				if (ym.Is21Century) {
					return ym;
				}
			}
			return null;
		}

		// ①月で昇順に出力　②偶数年のみ昇順に出力 ③閏年のみを出力　④すべての年から１２月に１番近い月出力
		private static void Exercise2_6(YearMonth[] ymCollection) {
			// foreach(var ym in ymCollection.OrderBy(ym => ym.Month)) {
			// foreach (var ym in ymCollection.Where(ym => ym.Year % 2 == 0).OrderBy(ym => ym.Year)) {
			// foreach (var ym in ymCollection.Where(ym => DateTime.IsLeapYear( ym.Year ))) {
			foreach (var ym in ymCollection.Where(ym => DateTime.IsLeapYear(ym.Year))) {
				Console.WriteLine(ym);
			}
			var data = ymCollection.Max(ym => ym.Month);
			Console.WriteLine(data);
		}

		private static void Exercise2_2(YearMonth[] ymCollection) {
			foreach (var ym in ymCollection) {
				Console.WriteLine(ym);
			}
		}

		private static void Exercise2_4(YearMonth[] ymCollection) {
			var ff = FindFirst21C(ymCollection);
			if (ff == null) {
				Console.WriteLine("21世紀のデータはありません");
			} else {
				Console.WriteLine(ff);
			}
		}

		private static void Exercise2_5(YearMonth[] ymCollection) {
			var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
			foreach (var ym in array) {
				Console.WriteLine(ym);
			}
		}
	}
}
