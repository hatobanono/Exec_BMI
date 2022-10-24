using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double height = 173;
			int weight = 80;
			double bmi = weight / Math.Pow((height / 100.00), 2);
			Console.WriteLine($"{bmi:0.00}");
			

		}
	}
}
