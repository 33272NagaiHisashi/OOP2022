using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
	class Program {
		static void Main(string[] args) {
			var price = Library.Books
				.OrderBy(b=>b.CategoryId)
				.ThenByDescending(b=>b.PublishedYear);
			foreach (var p in price) {
				Console.WriteLine(p);
			}
		}
	}
}
