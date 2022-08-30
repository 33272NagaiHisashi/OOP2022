using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
	public abstract class ConverterBase {

		public abstract bool IsMyUnit(string name);

		//メートルの比率（この比率を掛けるとメートルに交換できる）
		protected abstract double Ratio { get; }

		//距離の単位名（例えば、"メートル","フィード"など）
		public abstract string UnitName { get; }

		//メートルからの交換
		public double FromMeter(double meter) {
			return meter / Ratio;
		}

		//メートルへの交換
		public double ToMeter(double feet) {
			return feet * Ratio;
		}
	}
}
