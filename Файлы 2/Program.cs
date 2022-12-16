using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Файлы_2 {
	class Program {
		static void Main(string[] args) {
			StreamReader reader = new StreamReader("..\\..\\..\\..\\text.txt");
			while (true) {
				string a = reader.ReadLine();
				if(a == null)break;
				if(a.Contains(' ')) {
					Console.WriteLine(a);
				}
			}
			reader.Close();

		}
	}
}
