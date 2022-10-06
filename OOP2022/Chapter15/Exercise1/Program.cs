using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine("----------");
            Exercise1_3();
            Console.WriteLine("----------");
            Exercise1_4();
            Console.WriteLine("----------");
            Exercise1_5();
            Console.WriteLine("----------");
            Exercise1_6();
            Console.WriteLine("----------");
            Exercise1_7();
            Console.WriteLine("----------");
            Exercise1_8();

            Console.ReadLine();
        }

		private static void Exercise1_2() {
			var selected = Library.Books.Where(b => b.Price == Library.Books.Max(x => x.Price))
										.First();
			Console.WriteLine(selected);
		}

		private static void Exercise1_3() {
			var countYears = Library.Books.OrderBy(b => b.PublishedYear)
										  .GroupBy(b => b.PublishedYear)
										  .Select(s => new {
											  Year = s.Key,
											  Count = s.Count()
										  });
			foreach (var c in countYears) {
				Console.WriteLine($"{c.Year}年 {c.Count}冊");
			}
		}

		private static void Exercise1_4() {
			var selected = Library.Books.OrderByDescending(b => b.PublishedYear)
										.ThenByDescending(b => b.Price)
										.Join(Library.Categories, book => book.CategoryId,
																  category => category.Id,
																  (book, category) => new {
																	  Title = book.Title,
																	  Name = category.Name,
																	  PublishedYear = book.PublishedYear,
																	  Price = book.Price,
																  });
			foreach (var book in selected) {
				Console.WriteLine($"{book.PublishedYear}年 {book.Price}円 {book.Title} ({book.Name})");
			}
		}

		private static void Exercise1_5() {
			var selected = Library.Books.Where(b => b.PublishedYear == 2016)
										.Join(Library.Categories, book => book.CategoryId,
																  category => category.Id,
																  (book, category) => new {
																	  Name = category.Name
																  });		
			foreach (var s in selected.GroupBy(g => g.Name)) {
				Console.WriteLine(s.Key);
			}
		}

		private static void Exercise1_6() {
			
		}

		private static void Exercise1_7() {
			
		}

		private static void Exercise1_8() {
			
		}
	}
}
