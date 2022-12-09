using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4___Malashkina_Yana
{
	public class Scientist
	{
		[DisplayName("Ім'я")]
		public string Name { get; set; }

		[DisplayName("Факультет")]
		public string Faculty { get; set; }

		[DisplayName("Кафедра")]
		public string Department { get; set; }

		[DisplayName("Посада")]
		public string Position { get; set; }

		[DisplayName("Посадовий оклад")]
		public decimal Salary { get; set; }

		[DisplayName("Час перебування на посаді")]
		public decimal PositionDuration { get; set; }

	}
}
