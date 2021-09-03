using System;

namespace UserDetails
{
    class Program
    {
        static void Main(string[] args)
        {
			string name, education, city, todaysDate = "01/09/2021";

			Console.WriteLine($"Todays's date : {todaysDate}");

			Console.WriteLine("Enter the Name of user : ");
			name = Console.ReadLine();

			Console.WriteLine("Enter the Education of user : ");
			education = Console.ReadLine();

		    enterValidDate:
			Console.WriteLine("Enter Date of Birth in format [DD/MM/YYYY] : ");
			string dateOfBirth;
			try
			{
				DateTime birthDate = new DateTime();
				birthDate = DateTime.Parse(Console.ReadLine());
				dateOfBirth = birthDate.ToShortDateString();
			}
			catch
			{
				Console.WriteLine($"Invalid date, please enter in valid format");
				goto enterValidDate;
			}

			Console.WriteLine("Enter the Location of user : ");
			city = Console.ReadLine();

			Console.WriteLine("\nUser's Details are ");

			Console.WriteLine($"Name          : {name}");
			Console.WriteLine($"Education     : {education}");
			Console.WriteLine($"Date of Birth : {dateOfBirth}");
			Console.WriteLine($"Native place  : {city}");

			Console.ReadLine();
		}
    }
}
