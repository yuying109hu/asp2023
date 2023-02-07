using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysoftheMonth
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please input year___");
			try
			{   // year try begin
				int year = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please input month ___");
				try
				{  // month try begin
					int month = Convert.ToInt32(Console.ReadLine());
					if (month >= 1 && month <= 12)
					{
						int day;
						switch (month)
						{  // switch begin
							case 1:
							case 3:
							case 5:
							case 7:
							case 8:
							case 10:
							case 12:
								day = 31;
								break;
							case 2:
								if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
								{
									day = 29;
								}
								else
								{
									day = 28;
								}
								break;     // default month ---4,6,9,11
							default:
								day = 30;
								break;
						}  // switch end

						Console.WriteLine("year{0}, month{1}, day{2}", year, month, day);
					}  // if end
					else
					{
						Console.WriteLine("the month__{0} you input is invalid", month);
					}  // end of month
				}  // month try end
				catch  //month
				{
					Console.WriteLine("the month input is invalid, program exit!!");
				}

		}  // year try end
			catch
			{
				Console.WriteLine("the year input is invalid, program exit!!");
			}
		}
	}
}
