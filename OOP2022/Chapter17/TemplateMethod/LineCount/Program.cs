using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace LineCounter {
	class Program {
		static void Main(string[] args) {
			TextProcessor.Run<LineCounterProcessor>(@"C:\Users\infosys\OneDrive - 学校法人太田アカデミー\デスクトップ\33272NagaiHisashi\OOP2022\Chapter11\XmlSample\Program.cs");
		}
	}
}
