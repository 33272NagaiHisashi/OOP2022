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
				/*var groups = Library.Books.GroupBy(b => b.PublishedYear)
										  .OrderBy(g => g.Key);*/
				/*var selected = Library.Books.GroupBy(b => b.PublishedYear)
											.Select(group => group.OrderByDescending(b => b.Price).First())
											.OrderBy(o => o.PublishedYear);*/
				var selected = Library.Books.Where(b=>years.Contains(b.PublishedYear))
											.OrderBy(b => b.CategoryId)
											.ThenBy(b => b.PublishedYear)
											.Join(Library.Categories, book => book.CategoryId
																	, category => category.Id
																	, (book, category) => new {
																		Title = book.Title,
																		Category = category.Name,
																		PublishedYear = book.PublishedYear,
																		Price = book.Price
																	});
				
				foreach (var b in books) {
					Console.WriteLine(b);
				}
				Console.WriteLine();
				/*foreach (var g in groups) {
					Console.WriteLine($"{g.Key}年");
					foreach(var b in g) {
						Console.WriteLine($"	{b}");
					}
				}*/
				/*foreach(var s in selected) {
					//Console.WriteLine($"{s.PublishedYear}年 {s.Title} ({s.Price})");
					//Console.WriteLine($"{s.Title},{s.Category},{s.PublishedYear}");
				}*/
				foreach (var s in selected.OrderByDescending(b => b.PublishedYear)
										  .ThenBy(b => b.Category)) { 
					Console.WriteLine($"{s.PublishedYear}年,{s.Title},{s.Category},{s.Price}");
				}
				Console.WriteLine("金額の合計：" + books.Sum(b => b.Price));
			}
			if (num == 2) {
				var books = Library.Books.Where(b => years.Contains(b.PublishedYear))
										 .OrderByDescending(b => b.PublishedYear);
				var groups = Library.Books.GroupBy(b => b.PublishedYear)
										  .OrderByDescending(g => g.Key);
				foreach (var b in books) {
					Console.WriteLine(b);
				}
				foreach (var g in groups) {
					Console.WriteLine($"{g.Key}年");
					foreach (var b in g) {
						Console.WriteLine($"	{b}");
					}
				}
			} 
		}
	}
}

