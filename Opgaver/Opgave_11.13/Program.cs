using System;

namespace Application
{
    class Program
    {
		enum Months {January, February, March, April, May, June, July, August, September, October, November, December}; // enums to call back to
		enum The {st = 1, nd = 2, rd = 3, th}; // Same her 
        static void Main(string[] args)
        {
			int month = 0;  // Some variables to call to
			int[] day = {31,28,31,30,31,30,31,31,30,31,30,31};
			bool isNumber; 
			int numericalvalue = 0;
			string userInput = receiveInput();
			
			Console.WriteLine("Enter the amount of days"); 	//The start of the program
			
			
			string receiveInput()  //to get a string input
			{
				string input = Console.ReadLine();
				return input;
			}
			
			int numberInput()
			{				
				if (int.TryParse(userInput, out numericalvalue))  //to translate the string string
				{
					if (numericalvalue < 0)
					{
						Console.WriteLine("can't use negativ numbers");
						userInput = receiveInput();
					}
						Console.Write("There contains numbers, so the date is:");						
				}
				else
				{	
					Console.WriteLine("Input contains things other than numbers");
					userInput = receiveInput();									
				}
				return numericalvalue;
			}
			
			
		
			int theNumber()
			{
				if (numberInput() < 4)
				{
					return;
				}
				else 
				{
					return 4;
				}
			}
			
			Console.WriteLine(theNumber);
			
			string output()
			{
				if (numericalvalue > day[month])
				{
					while (numericalvalue > day[month])
					{
						numericalvalue -= day[month];
						month++;
					}
					Console.WriteLine((Months)month + " " + numericalvalue + (The)theNumber());
					return (Months)month + " " + numericalvalue + (The)theNumber();
				}
				else
				{
					return ((Months)month + " " + numericalvalue + (The)theNumber());
				}
			}*/
		}
			
		static void Sub(string[] args)
		{

		}
	}
}
	

//Hvilken datastruktur skal bruges
//Hvilke variabler skal bruges og hvordan skal de initialiseres