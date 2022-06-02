using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
	class Program {
		static void Main(string[] args) {
			int num;
			Console.Write("数字を入力してください：");
			var str = Console.ReadLine();
			if (int.TryParse(str, out num)) {
				// Console.WriteLine(num.ToString("#,0"));
				Console.WriteLine("{0:#:#}", num);
			} else {
				Console.WriteLine("数値文字列でありません");
			}
		}
	}
}
