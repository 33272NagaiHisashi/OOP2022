using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
	class Program {
		public static void Main(string[] args) {
			PrintFeetToMeterList(1, 10);
		}
		static void PrintFeetToMeterList(int start, int stop) {
			//フィートからメートルへの対応表を出力
			//FeetConverter fc = new FeetConverter();		
			for (int inch = 1; inch <= 10; inch++) {
				double meter = InchConverter.ToMeter(inch);
				Console.WriteLine("{0} in = {1:0.0000} m", inch, meter);
			}
		}
	}
}
