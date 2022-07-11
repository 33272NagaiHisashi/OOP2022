using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Exercise01 {
	[DataContract(Name = "EmployeeJ")]
	class EmployeeJ {
		public int Id { get; set; }
		[DataMember(Name = "name")]
		public string Name { get; set; }
		[DataMember(Name = "HireDate")]
		public DateTime HireDate { get; set; }
		public override string ToString() {
			return string.Format("[Id={0},Name={1},HireDate={2}]", Id, Name, HireDate);
		}
	}
}
