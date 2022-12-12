using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Lab4___Malashkina_Yana
{
	internal class Helper
	{
		public static List<Scientist> Filter(List<Scientist>  scientists, string surname, string faculty, string kafedra)
		{
			return scientists
				.Where(item => item.Name.Contains(surname) || surname.Trim() == String.Empty)
				.Where(item => item.Faculty.Contains(faculty) || faculty.Trim() == String.Empty)
				.Where(item => item.Department.Contains(kafedra) || kafedra.Trim() == String.Empty).ToList();
		}

		public static void SaveToFile(List<Scientist> list, string filePath)
		{
			string jsonString = JsonConvert.SerializeObject(list);
			File.WriteAllText(filePath, jsonString);
		}

		public static List<Scientist> OpenFromFile(string filePath)
		{
			List<Scientist> list = null;

			if (File.Exists(filePath))
			{
				string jsonString = File.ReadAllText(filePath);
				if (jsonString != null)
					list = JsonConvert.DeserializeObject<List<Scientist>>(jsonString);
			}

			if (list == null)
			{
				list = new List<Scientist>();
			}

			return list;
		}

	}
}
