using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFunction
{
	class Program
	{
		static void Main(string[] args)
		{
		// SayHello();
		// Console.ReadKey();

		// void SayHello()

		//Console.WriteLine("   ");
		// Console.WriteLine("   Welcome to CST College!!");
		//}


		   string mystr = "Tom";
		   string resultStr;

		   resultStr= SayHello(mystr);

		   Console.WriteLine(resultStr);
		   Console.ReadKey();

		   string SayHello(string str);
		   {

	           string message = "Welcome to CST College:" + str;
		       return message;
		 
		   }


        }

			



			

		
	}
}
