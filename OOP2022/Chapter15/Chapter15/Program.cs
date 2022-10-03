using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
	class Program {
		static void Main(string[] args) {
			var years = new List<int> { };
			Console.WriteLine("出力したい西暦を入力(終了：-1)");
			while (true) {
				years.Add(int.Parse(Console.ReadLine()));
				if (years.Contains(-1)) break;
			}
			Console.WriteLine();
			Console.Write("昇順：１ 降順：２　:");
			var num = int.Parse(Console.ReadLine());
			if (num == 1) {
				var books = Library.Books.Where(b => years.Contains(b.PublishedYear))
										 .OrderBy(b => b.PublishedYear);
				var groups = Library.Books.GroupBy(b => b.PublishedYear)
										  .OrderBy(g => g.Key);
				foreach (var b in books) {
					Console.WriteLine(b);
					Console.WriteLine();
				}
				foreach (var g in groups) {
					Console.WriteLine($"{g.Key}年");
					foreach(var b in books) {
						Console.WriteLine("	{0} {1} {2}",b.Title,b.CategoryId,b.Price);
					}
				}
			}
			if (num == 2) {
				var books = Library.Books.Where(b => years.Contains(b.PublishedYear))
										 .OrderByDescending(b => b.PublishedYear);
				var groups = Library.Books.GroupBy(b => b.PublishedYear)
										  .OrderByDescending(g => g.Key);
				foreach (var b in books) {
					Console.WriteLine(b);
					Console.WriteLine();
				}
				foreach (var g in groups) {
					Console.WriteLine($"{g.Key}年");
					foreach (var b in books) {
						Console.WriteLine("	{0} {1} {2}", b.Title, b.CategoryId, b.Price);
					}
				}
			} 
		}
	}
}

