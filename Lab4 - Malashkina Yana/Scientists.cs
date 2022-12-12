using System.Collections.Generic;
using System.IO;

namespace Lab4___Malashkina_Yana
{
	internal class Scientists
	{
		private List<Scientist> list;
		private string filePath;
		public Scientists() 
		{
			list = new List<Scientist>();
			filePath = Path.Combine(Path.GetTempPath(),  "Yana.txt");
		}

		public void SaveToFile()
		{
			Helper.SaveToFile(list, filePath);
		}

		public void OpenFromFile() 
		{
			list = Helper.OpenFromFile(filePath);
		}

		public List<Scientist> List
		{
			get { return list; }
			set { list = value; }
		}

	}
}
