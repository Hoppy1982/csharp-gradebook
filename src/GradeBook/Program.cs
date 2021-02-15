﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
	class Program
	{
		static void Main(string[] args)
		{
			var book = new Book("Mark's Grade Book");

			while(true)
			{
				Console.WriteLine("Enter a grade or 'q' to quit");
				var input = Console.ReadLine();

				if(input == "q")
				{
					break;
				}

				try
				{
					var grade= double.Parse(input);
					book.AddGrade(grade);
				}
				catch(ArgumentException ex)
				{
					Console.WriteLine(ex.Message);
				}
				catch(FormatException ex)
				{
					Console.WriteLine(ex.Message);
				}
				finally
				{
					Console.WriteLine("**");
				}
			}

			var stats = book.GetStatistics();
			
			Console.WriteLine($"For the book named {book.Name}");
			Console.WriteLine($"The lowest grade: {stats.Low}");
			Console.WriteLine($"The highest grade: {stats.High}");
			Console.WriteLine($"The average result: {stats.Average:N1}");
			System.Console.WriteLine($"The letter grade is {stats.Letter}");
		}
	}
}