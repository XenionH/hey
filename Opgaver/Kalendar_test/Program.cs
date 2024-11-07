using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading; 
using System.Threading.Tasks; 

enum Months {January, February, March, April, May, June, July, August, September, October, November, December}; // enums to call back to
enum The {st = 1, nd = 2, rd = 3, th}; // Same her

class Program 
{
    static void Main()
    {
	   
	   


	   // Some variables to call to
        int[] days = {31,28,31,30,31,30,31,31,30,31,30,31};
        string userInput = receiveInput();
        var (month, day) = monthCalc();
		int i;
        while (numberInput() == 0 || numberInput() < 0)
        {
            numberInput();
        }

        //The start of the program
        
		
		
        int numberInput()
        {	
			int numericalvalue = 0;
			while (numericalvalue == 0 && numericalvalue < 0)
			{			
				if (int.TryParse(userInput, out numericalvalue))  //to translate the string to integer
				{
					if (numericalvalue < 0)
					{
						Console.WriteLine("can't use negativ numbers");
						userInput = receiveInput();
						continue;
					}
                    else
                    {
                        break;
                    }
					Console.WriteLine("The date is:");
					return numericalvalue;
					
				}
				else
				{	
					Console.WriteLine("Input contains things other than numbers");
					userInput = receiveInput();	
				}
			}


			return numericalvalue;
        }
        //Console.WriteLine(numberInput(numericalvalue));
        //Console.WriteLine(numberInput());

        

        (int month, int day) monthCalc()
        {            
            int month = 0;
            int day = numberInput();
            if (day != 0)
			{
				if (day > days[month])
				{
					while (day > days[month] && month < 11)
					{
						day -= days[month];
						month++;
					}
					
					return (month, day);
				}  
				return (month, day);
			}	
			else
			{
				day = numberInput();
				if (day > days[month])
				{
					while (day > days[month] && month < 11)
					{
						day -= days[month];
						month++;
					}
					
					return (month, day);
				}  
				return (month, day);
			}
        }

        int theNumber()
        {
            i = day;
            //numberInput(numericalvalue);
            if (i < 4)
            {
				return i;
            }
            else 
            {
				return 4;
            }
        }

         
        Console.WriteLine((Months)month + " " + day + "" + (The)theNumber());
        
        string receiveInput ()
        {
			Console.WriteLine("Enter the amount of days");
			userInput = Console.ReadLine();
			return userInput;
        }
            //Console.WriteLine(input);
            //return input;
		
       
    }    
}
