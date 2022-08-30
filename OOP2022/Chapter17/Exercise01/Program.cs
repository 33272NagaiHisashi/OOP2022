using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace Exercise01 {
	class Program {
		static void Main(string[] args) {
			using (var sr = new StreamReader(args[0], Encoding.UTF8)) {
				int Count = 0;
				while (!sr.EndOfStream) {
					string line = sr.ReadLine();
					Count++;
				}
				Console.WriteLine(Count);
			}
		}
	}
}
