﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
	class Program {
		static void Main(string[] args) {
			Console.Write("文字を入力してください：");
			string letter1 = Console.ReadLine();
			Console.Write("文字を入力してください：");
			string letter2 = Console.ReadLine();
			if (String.Compare(letter1, letter2, true) == 0) {
				Console.WriteLine("等しい");
			} else {
				Console.WriteLine("等しくない");
			}
		}
	}
}