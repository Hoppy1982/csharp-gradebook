using System;
using System.Collections.Generic;

namespace GradeBook
{
	class Program
	{
		static void Main(string[] args)
		{
			var book = new Book("Mark's Grade Book");
			book.AddGrade(89.1);
			book.AddGrade(90.5);
			book.AddGrade(77.5);

			var stats = book.GetStatistics();
			
			Console.WriteLine($"The lowest grade: {stats.Low}");
			Console.WriteLine($"The highest grade: {stats.High}");
			Console.WriteLine($"The average result: {stats.Average:N1}");
		}
	}
}