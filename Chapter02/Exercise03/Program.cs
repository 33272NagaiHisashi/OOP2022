﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
	class Program {
		static void Main(string[] args) {
			int select = 0;
			var sales = new SalesCounter("sales.csv");

			IDictionary<string, int> amountPerStore = null;

			while (true) {
				Console.WriteLine("売上高の表示選択");
				Console.WriteLine("1.店舗別");
				Console.WriteLine("2.商品カテゴリー別");
				Console.Write(">");

				//int a = int.Parse(Console.ReadLine());
				select = int.Parse(Console.ReadLine());

				switch (select) {
					case 1:
						amountPerStore = sales.GetPerStoreSales();
						break;

					case 2:
						amountPerStore = sales.GetPerCategorySales();
						break;

					case 999:
						Console.WriteLine("終了");
						return;
				}

				foreach (var obj in amountPerStore) {
					Console.WriteLine("{0} {1}", obj.Key, obj.Value);
				}
			}
			/*if (a == 1) {
				var amountPerStore = sales.GetPerStoreSales();
				foreach (var obj in amountPerStore) {
					Console.WriteLine("{0} {1}", obj.Key, obj.Value);
				}
			}
			if (a == 2) {
				var amountPerCategory = sales.GetPerCategorySales();
				foreach (var obj in amountPerStor) {
					Console.WriteLine("{0} {1}", obj.Key, obj.Value);
				}
			if (a == 999) {
				Console.WriteLine("終了");
			}
			}*/
		}
	}
}
