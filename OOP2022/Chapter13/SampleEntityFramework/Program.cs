using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
	class Program {
        static void Main(string[] args) {
            //InsertBooks();
            //AddAuthors();
            //AddBooks();
            Console.WriteLine();
            Console.WriteLine("13.1.2");
            Console.WriteLine();
            var books = GetAllBooks();
            foreach (var b in books) {
                Console.WriteLine("{0} {1} {2} ({3:yyyy/MM/dd})",
                    b.Title, b.PublishedYear, b.Author.Name, b.Author.Birthday
                );
            }
            Console.WriteLine();
            Console.WriteLine("13.1.3");
            Console.WriteLine();
            var longest = GetBooksLongest();
            foreach (var l in longest) {
                Console.WriteLine("{0} {1} {2}({3:yyyy/MM/dd})",
                    l.Title,l.PublishedYear,l.Author.Name,l.Author.Birthday);
            }
            Console.WriteLine();
            Console.WriteLine("13.1.4");
            Console.WriteLine();
            var top3 = GetBooksOrder();
            foreach (var o in top3) {
                Console.WriteLine("{0} {1}",
                    o.Title, o.Author.Name);
            }
            Console.WriteLine();
            Console.WriteLine("13.1.5");
            Console.WriteLine();
            var authors = GetBooksAuthors();
            foreach (var a in authors) {
                Console.WriteLine("{0} {1:yyyy/MM}",a.Name,a.Birthday);
				foreach (var b in a.Books) {
                    Console.WriteLine("   {0} {1}", b.Title, b.PublishedYear);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }   
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };

                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };

                db.Books.Add(book2);
                db.SaveChanges(); //データベースの更新
            }
        }

        static IEnumerable<Book> GetAllBooks() {
            using(var db = new BooksDbContext()) {
                return db.Books.Include(nameof(Author)).ToList();
			}
		}

        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext()) {
                return db.Books.Where(b => b.Author.Name.StartsWith("夏")).ToList();
            }
        }

        static IEnumerable<Book> GetBooksLongest() {
            using (var db = new BooksDbContext()) {
                return db.Books
                    .Include(nameof(Author))
                    .Where(b => b.Title.Length == db.Books.Max(x=>x.Title.Length))
                    .ToList();
            }
        }

        static IEnumerable<Book> GetBooksOrder() {
            using (var db = new BooksDbContext()) {
                return db.Books
                    .Include(nameof(Author))
                    .OrderBy(b => b.PublishedYear)
                    .Take(3)
                    .ToList();
            }
        }

        static IEnumerable<Author> GetBooksAuthors() {
            using (var db = new BooksDbContext()) {
                return db.Authors
                    .Include(nameof(Book))
                    .OrderByDescending(b => b.Birthday)
                    .ToList();
            }
        }

        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                /*var author1 = new Author {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author1);
                var author2 = new Author {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };
                db.Authors.Add(author2);*/
                var author3 = new Author {
                    Birthday = new DateTime(1888,12,25),
                    Gender = "M",
                    Name = "菊池寛"
                };
                db.Authors.Add(author3);
                var author4 = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };
                db.Authors.Add(author4);
                db.SaveChanges();
            }
        }

        // List 13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                /*var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);
                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);*/
                var author3 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book3 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author3,
                };
                db.Books.Add(book3);
                var author4 = db.Authors.Single(a => a.Name == "川端康成");
                var book4 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author4,
                };
                db.Books.Add(book4);
                var author5 = db.Authors.Single(a => a.Name == "菊池寛");
                var book5 = new Book {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = author5,
                };
                db.Books.Add(book5);
                var author6 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book6 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author6,
                };
                db.Books.Add(book6);
                db.SaveChanges();
            }
        }
    }
}
